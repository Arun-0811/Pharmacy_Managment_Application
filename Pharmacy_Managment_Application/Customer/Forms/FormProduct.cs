using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static Pharmacy_Managment_Application.Login;


namespace Pharmacy_Management_Application
{
    public partial class FormProduct1 : Form
    {
        // Connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        public FormProduct1()
        {
            InitializeComponent();
            LoadCategoryComboBox(); 
            IpAddress();
            dateTime();
            welcome_load();
        }

        public void welcome_load()
        {
            
            string email = GlobalUser.LoggedInUser; // the email you stored earlier
            string userName = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_name FROM User_Login WHERE User_Email = @email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    var result = cmd.ExecuteScalar(); // only expecting a single value

                    if (result != null)
                    {
                        userName = result.ToString();
                    }
                }
            }

            lbl_welcome.Text = "Welcome, " + userName + "!";
            txt_cusName.Text = userName;
            txt_cusName.ReadOnly = true;
            btn_price.ReadOnly = true;
            txt_total.ReadOnly = true;

        }
        public void IpAddress()
        {
            try
            {
                // Get the host name
                string hostName = Dns.GetHostName();

                // Get the IP address list
                IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

                // Loop through and find IPv4 address
                foreach (IPAddress ip in ipAddresses)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        lbl_ip.Text = ip.ToString();
                        return;
                    }
                }

                label1.Text = "No IPv4 address found.";
            }
            catch (Exception ex)
            {
                lbl_ip.Text = "Error: " + ex.Message;
            }
        }

        public void dateTime()
        {
            lbl_date.Text = DateTime.Now.ToString();
        }


        // Method to populate the first ComboBox with category names
        private void LoadCategoryComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT cat_name FROM Category_Name";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());

                cmb_cat_name.DataSource = dt;
                cmb_cat_name.DisplayMember = "cat_name";
                cmb_cat_name.ValueMember = "cat_name";
                cmb_cat_name.SelectedIndex = -1;
                cmb_cat_name.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb_item_name.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Event when category selection changes
        private void cmb_cat_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cat_name.SelectedIndex != -1 && cmb_cat_name.SelectedItem != null)
            {
                string selectedCatName = cmb_cat_name.SelectedValue.ToString(); // Better use SelectedValue

                int selectedCatId = GetCategoryIdByName(selectedCatName);

                if (selectedCatId > 0)
                {
                    LoadComboBox(selectedCatId);
                }
                else
                {
                    MessageBox.Show("Category ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fetch cat_id by cat_name
        private int GetCategoryIdByName(string catName)
        {
            int catId = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT cat_id FROM Category_Name WHERE cat_name = @CatName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CatName", catName);
                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        catId = id;
                    }
                }
            }

            return catId;
        }

        // Load items based on selected category ID
        private void LoadComboBox(int selectedCatId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "GetProductsByCategory";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryId", selectedCatId);

                        DataTable dt = new DataTable();
                        conn.Open();
                        dt.Load(cmd.ExecuteReader());

                        if (dt.Rows.Count > 0)
                        {
                            cmb_item_name.DataSource = dt;
                            cmb_item_name.DisplayMember = "ItemName";
                            cmb_item_name.ValueMember = "ItemName"; // Use ItemName as value because no ItemID from SP
                            cmb_item_name.SelectedIndex = 0;
                        }
                        else
                        {
                            cmb_item_name.DataSource = null;
                            cmb_item_name.Items.Clear(); // Clear properly
                            cmb_item_name.Text = "";
                            MessageBox.Show("No items available for this category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cmb_item_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item_name.SelectedValue != null && cmb_item_name.SelectedValue != DBNull.Value)
            {
                // Parse SelectedValue to integer
                var selectedItemname = cmb_item_name.Text.ToString();

                LoadItemPic(selectedItemname);

                

            }
            else
            {
                MessageBox.Show("Please select a valid item.");
            }
        }

        private void LoadItemPic(string selectedItemname)
        {
            if (string.IsNullOrWhiteSpace(selectedItemname))
            {
                MessageBox.Show("Invalid Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "GetProductImageByCategory"; // Stored Procedure
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Itemname", selectedItemname);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageData = reader["ItemPic"] as byte[];
                                decimal price;

                                if (!Convert.IsDBNull(reader["PricePerQty"]) && decimal.TryParse(reader["PricePerQty"].ToString(), out price))
                                {
                                    btn_price.Text = price.ToString("0.00");
                                }
                                else
                                {
                                    btn_price.Text = "Price: N/A";
                                    MessageBox.Show("Invalid or missing price for the selected product.");
                                }

                                if (imageData != null && imageData.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pic_dynamic_product.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pic_dynamic_product.Image = null;
                                    MessageBox.Show("No image available for the selected product.");
                                }
                            }
                            else
                            {
                                pic_dynamic_product.Image = null;
                                MessageBox.Show("No data found for the selected product.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CalculateTotal()
        {
            if (decimal.TryParse(txt_qty.Text, out decimal quantity) && decimal.TryParse(btn_price.Text, out decimal price))
            {
                // Perform the multiplication and display the result in the total TextBox
                decimal total = quantity * price;
                txt_total.Text = total.ToString("0.00"); // Format the total to 2 decimal places
            }
            else
            {
                // Clear the total TextBox if input is invalid
                txt_total.Text = string.Empty;
            }
        }


        private void FormProduct1_Load(object sender, EventArgs e)
        {
            cmb_cat_name.Text = string.Empty;
            cmb_item_name.Text = string.Empty;
            pic_dynamic_product.Image = null;
            

        }

        
        private void qty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void UpdateInventory(string itemName, int quantityPurchased)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateInventory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        cmd.Parameters.AddWithValue("@Quantity", quantityPurchased);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_buy_Click(object sender, EventArgs e)
        {
            string Customer_Name = txt_cusName.Text.Trim();
            string Category_Name = cmb_cat_name.Text.Trim();
            string Item_Name = cmb_item_name.Text.Trim();
            string QuantityStr = txt_qty.Text.Trim();
            string CostStr = btn_price.Text.Trim();
            string TotalCostStr = txt_total.Text.Trim();

            byte[] imageData = null;

            // Variables for parsed values
            int Quantity = 0;
            decimal Cost = 0.0m;
            decimal Total_Cost = 0.0m;

            try
            {
                // Validate and convert image
                if (pic_dynamic_product.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(pic_dynamic_product.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageData = ms.ToArray();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No image selected!");
                    return;
                }

                // Validate inputs
                if (string.IsNullOrWhiteSpace(Customer_Name) ||
                    string.IsNullOrWhiteSpace(Category_Name) ||
                    string.IsNullOrWhiteSpace(Item_Name) ||
                    string.IsNullOrWhiteSpace(QuantityStr) ||
                    string.IsNullOrWhiteSpace(CostStr) ||
                    string.IsNullOrWhiteSpace(TotalCostStr) ||
                    imageData == null)
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                // Parse numeric fields
                if (!int.TryParse(QuantityStr, out Quantity))
                {
                    MessageBox.Show("Invalid quantity format.");
                    return;
                }

                if (!decimal.TryParse(CostStr, out Cost))
                {
                    MessageBox.Show("Invalid cost format.");
                    return;
                }

                if (!decimal.TryParse(TotalCostStr, out Total_Cost))
                {
                    MessageBox.Show("Invalid total cost format.");
                    return;
                }

                // Database operation
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "InsertCustermerPurchase";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@cus_name", Customer_Name);
                        cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                        cmd.Parameters.AddWithValue("@item_name", Item_Name);
                        cmd.Parameters.AddWithValue("@quantity", Quantity);
                        cmd.Parameters.AddWithValue("@pic_upload", imageData);
                        cmd.Parameters.AddWithValue("@cost", Cost);
                        cmd.Parameters.AddWithValue("@total_cost", Total_Cost);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Customer purchase inserted successfully!");
                // Reset fields
                UpdateInventory(Item_Name, Quantity);
                cmb_cat_name.SelectedIndex = -1;
                cmb_item_name.SelectedIndex = -1;
                txt_qty.Clear();
                btn_price.Text = string.Empty;
                txt_total.Text = string.Empty;
                pic_dynamic_product.Image = null;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}


