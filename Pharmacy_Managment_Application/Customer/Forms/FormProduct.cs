using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace Pharmacy_Management_Application
{
    public partial class FormProduct1 : Form
    {
        // Connection string from app.config
        private string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        public FormProduct1()
        {
            InitializeComponent();
            LoadCategoryComboBox(); // Load data into the first ComboBox


        }

        // Method to populate the first ComboBox with category names
        private void LoadCategoryComboBox()
        {
            SqlConnection conn = new SqlConnection(connectionString);            
            string query = "SELECT cat_name, cat_id FROM Category_Name";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open(); // Open the database connection
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DataRow placeholderRow = dt.NewRow();
            
            placeholderRow["cat_name"] = "Select Item"; // Placeholder text
            dt.Rows.InsertAt(placeholderRow, 0);

            // Bind the DataTable to the ComboBox
            // Add a placeholder item at the top of the DataTable
            cmb_cat_name.DataSource = dt;
            cmb_cat_name.DisplayMember = "cat_name"; // Column to display in the ComboBox
            cmb_cat_name.ValueMember = "cat_id"; // Column to use as the value

            cmb_cat_name.SelectedIndex = -1;

            



        }
        private void cmb_category_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmb_cat_name.SelectedValue != null && cmb_cat_name.SelectedValue != DBNull.Value)
            {
                // Parse SelectedValue to integer
                var selectedItemId = Convert.ToInt32(cmb_cat_name.SelectedIndex);
                LoadComboBox(selectedItemId);
                

                MessageBox.Show($"Selected Item ID: {selectedItemId}");
                
            }
            else
            {
                MessageBox.Show("Please select a valid item.");
            }
        }

        

        private void LoadComboBox(int selectedItemId)
        {
            if (selectedItemId <= 0)
            {
                MessageBox.Show("Invalid Category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "GetProductsByCategory";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryId", selectedItemId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }

               

                cmb_item_name.DataSource = dt;
                cmb_item_name.DisplayMember = "ItemName";
                //cmb_item_name.ValueMember = "ItemID";

                // Set default to placeholder
                cmb_item_name.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if(ex.Equals(0) || ex.Equals(null))
                    {
                    cmb_item_name.Text= string.Empty;
                }
                MessageBox.Show($"No Items Available in this Index", "Choose Another", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_item_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item_name.SelectedValue != null && cmb_item_name.SelectedValue != DBNull.Value)
            {
                // Parse SelectedValue to integer
                var selectedItemname = cmb_item_name.Text.ToString();

                LoadItemPic(selectedItemname);

                MessageBox.Show($"Selected Item ID: {selectedItemname}");

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
                        cmd.Parameters.AddWithValue("@Itemname", selectedItemname); // Pass the parameter value

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve image data from database
                                byte[] imageData = reader["ItemPic"] as byte[];
                                DateTime expiryDate;
                                decimal price;

                                // Check if ExpiryDate is valid and convert to DateTime
                                if (!Convert.IsDBNull(reader["ExpiryDate"]) && DateTime.TryParse(reader["ExpiryDate"].ToString(), out expiryDate))
                                {
                                    dateTimePicker1.Value = expiryDate; // Set valid DateTime to DateTimePicker
                                }
                                else
                                {
                                    dateTimePicker1.Value = DateTime.Now; // Default to current date if invalid
                                    MessageBox.Show("Invalid or missing expiry date for the selected product.");
                                }

                                // Handle Price
                                if (!Convert.IsDBNull(reader["PricePerQty"]) && decimal.TryParse(reader["PricePerQty"].ToString(), out price))
                                {
                                    btn_price.Text = price.ToString("0.00"); // Display price in label
                                }
                                else
                                {
                                    btn_price.Text = "Price: N/A"; // Default message if price is invalid
                                    MessageBox.Show("Invalid or missing price for the selected product.");
                                }


                                if (imageData != null && imageData.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pic_dynamic_product.Image = Image.FromStream(ms); // Set image dynamically
                                    }
                                }
                                else
                                {
                                    pic_dynamic_product.Image = null; // Clear PictureBox
                                    MessageBox.Show("No image available for the selected product.");
                                }
                            }
                            else
                            {
                                pic_dynamic_product.Image = null; // Clear PictureBox
                                dateTimePicker1.Value = DateTime.Now; // Default to current date
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
            if (decimal.TryParse(textBox4.Text, out decimal quantity) && decimal.TryParse(btn_price.Text, out decimal price))
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

        private void btn_buy_Click(object sender, EventArgs e)
        {
            string Product_Name = textBox1.Text.Trim();
            string Category_Name = cmb_cat_name.Text.Trim();
            string Item_name = cmb_item_name.Text.Trim();
            string Quantity = textBox4.Text.Trim();          
            string Expirydate = dateTimePicker1.Text.Trim();
            string PricePerQty = btn_price.Text.Trim();
            string TotalPrice = txt_total.Text.Trim();

            byte[] imageData = null;

            try
            {
                // Check if the PictureBox contains an image
                if (pic_dynamic_product.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        var clonedImage = (System.Drawing.Image)pic_dynamic_product.Image.Clone(); // Clone the image
                        clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save the cloned image
                        imageData = ms.ToArray();
                    }
                }

                // Validate inputs
                if (!string.IsNullOrWhiteSpace(Product_Name) &&
                    !string.IsNullOrWhiteSpace(Category_Name) &&
                    !string.IsNullOrWhiteSpace(Item_name) &&
                    !string.IsNullOrWhiteSpace(Quantity) &&
                    !string.IsNullOrWhiteSpace(PricePerQty) &&                    
                    !string.IsNullOrWhiteSpace(Expirydate) &&
                    !string.IsNullOrWhiteSpace(TotalPrice) &&
                    imageData != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO cus_purchase_tbl (cus_name, cat_name, item_name,quantity,expiry_date, cost, total_cost, product_img) VALUES (@name, @cat_name,@item, @quanty, @expiry, @cost, @totalcost,  @img)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", Product_Name);
                            cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                            cmd.Parameters.AddWithValue("@item", Item_name);
                            cmd.Parameters.AddWithValue("@quanty", Quantity);                                                       
                            cmd.Parameters.AddWithValue("@expiry", Expirydate);
                            cmd.Parameters.AddWithValue("@cost", PricePerQty);
                            cmd.Parameters.AddWithValue("@totalcost", TotalPrice);
                            cmd.Parameters.AddWithValue("@img", imageData);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    MessageBox.Show("Data Inserted Successfully");
                    UpdateInventory();
                    textBox1.Text = string.Empty;
                    cmb_cat_name.SelectedIndex = -1;
                    cmb_item_name.Text = string.Empty;
                    textBox4.Text = string.Empty;                    
                    dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    btn_price.Text=string.Empty;
                    txt_total.Text = string.Empty;
                    pic_dynamic_product.Image = null; // Clear the PictureBox
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void UpdateInventory()
        {           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateInventory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
              

        
    }
}


