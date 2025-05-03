using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Managment_Application.Admin
{
    public partial class BillingDetails : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        private int selectedOrderID;
        private System.Windows.Forms.ToolTip toolTip;
        public BillingDetails()
        {
            InitializeComponent();
            picture_upload.Image = null;
        }

        private void side_overview_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void side_orderlist_Click(object sender, EventArgs e)
        {
            Order_List order_List = new Order_List();
            order_List.Show();
            this.Hide();
        }

        private void side_feedback_Click(object sender, EventArgs e)
        {
            Feedback_Page feedback = new Feedback_Page();
            feedback.Show();
            this.Hide();
        }

        private void lbl_tablets_Click(object sender, EventArgs e)
        {
            Tablets_Page tablets = new Tablets_Page();
            tablets.Show();
            this.Hide();
        }

        private void lbl_surgical_Click(object sender, EventArgs e)
        {
            Surgical_Items_Page surgical_Items = new Surgical_Items_Page();
            surgical_Items.Show();
            this.Hide();
        }

        private void ToggleControls(bool isEditing)
        {
            if (isEditing)
            {
                txt_tbid.Visible = true;
                lbl_tbid.Visible = true;


            }
            else
            {
                txt_tbid.Visible = false;
                lbl_tbid.Visible = false;


            }
        }

        private void btn_insert_disable(bool isEditing)
        {
            if (isEditing)
            {
                btn_insert.Enabled = false;
            }
            else
            {
                btn_insert.Enabled = true;
            }
        }


        public void dateTime()
        {
            lbl_datetime.Text = DateTime.Now.ToString();
        }

        public void order_listDB()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from cus_purchase_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            billing_tbl.DataSource = dataTable;
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
                        lbl_ip_address.Text = ip.ToString();
                        return;
                    }
                }

                lbl_ip_address.Text = "No IPv4 address found.";
            }
            catch (Exception ex)
            {
                lbl_ip_address.Text = "Error: " + ex.Message;
            }
        }


        private void billing_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = billing_tbl.Rows[e.RowIndex];

                    // Safely retrieve and assign values from the row
                    txt_tbid.Text = row.Cells["cus_id"].Value?.ToString();         // Customer ID
                    txt_tbname.Text = row.Cells["cus_name"].Value?.ToString();     // Customer Name

                    // Ensure proper handling of quantity
                    if (row.Cells["quantity"].Value != null && int.TryParse(row.Cells["quantity"].Value.ToString(), out int quantity))
                    {
                        txt_cusqty.Text = quantity.ToString(); // Assign parsed quantity value
                    }
                    else
                    {
                        txt_cusqty.Text = "0"; // Assign a default value if invalid
                        MessageBox.Show("Quantity is missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txt_price.Text = row.Cells["cost"].Value?.ToString();          // Cost
                    txt_totalprice.Text = row.Cells["total_cost"].Value?.ToString(); // Total Cost

                    // Assign Purchase Date
                    if (DateTime.TryParse(row.Cells["Purchase_date"].Value?.ToString(), out DateTime purchaseDate))
                    {
                        mfg_dateTime.Text = purchaseDate.ToString("yyyy-MM-dd"); // Format date
                    }
                    else
                    {
                        mfg_dateTime.Text = "Invalid Date"; // Handle invalid date format
                        MessageBox.Show("Purchase Date is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Item Name
                    cmb_item.Text = row.Cells["item_name"].Value?.ToString();      // Item Name

                    // Load Product Image
                    byte[] imageData = row.Cells["product_img"].Value as byte[];
                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            picture_upload.Image = System.Drawing.Image.FromStream(ms); // Load image
                        }
                    }
                    else
                    {
                        picture_upload.Image = null; // No image
                    }

                    // Assign Category ID
                    if (row.Cells["cat_id"].Value != DBNull.Value && row.Cells["cat_id"].Value != null &&
                        int.TryParse(row.Cells["cat_id"].Value.ToString(), out int catId))
                    {
                        string categoryName = GetCategoryNameById(catId); // Retrieve category name
                        cmb_catname.Text = categoryName;
                    }
                    else
                    {
                        cmb_catname.Text = "Unknown Category"; // Handle missing category
                        MessageBox.Show("Category ID is missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Store Selected Order ID
                    selectedOrderID = int.TryParse(row.Cells["cus_id"].Value?.ToString(), out int orderId) ? orderId : 0;

                    ToggleControls(true);
                    btn_insert_disable(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method to fetch category name based on cat_id
        private string GetCategoryNameById(int catId)
        {
            string categoryName = string.Empty;
            string query = "SELECT cat_name FROM Category_Name WHERE cat_id = @catId";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@catId", catId);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        categoryName = reader["cat_name"].ToString();
                    }
                    con.Close();
                }
            }
            return categoryName;
        }

        

        private void billingdetails_Load(object sender, EventArgs e)
        {
            options_panel.Visible = false;
            category_db();
            order_listDB();
            ToggleControls(false);
            IpAddress();
            dateTime();
            toolTip = new System.Windows.Forms.ToolTip(); // Initialize tooltip

            txt_totalprice.Enabled = false;
            lbl_totalprice.Enabled = false;

            txt_totalprice.ReadOnly = true;
            txt_tbid.ReadOnly = true;

            // Set tooltip for textboxes
            toolTip.SetToolTip(side_overview, "click to view overview information");
            toolTip.SetToolTip(side_orderlist, "click to view order list details");
            toolTip.SetToolTip(side_stocks, "click to view total stocks details");

            toolTip.SetToolTip(btn_insert, "After Given data click insert");
            toolTip.SetToolTip(btn_update, "After Given data click update");
            toolTip.SetToolTip(btn_delete, "After Given data click delete");
            toolTip.SetToolTip(lbl_ip_address, "Your IP Address");
            toolTip.SetToolTip(btn_exit, "Exit Button");
            toolTip.SetToolTip(btn_clear, "clear Button");
        }
        public void category_db()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
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
            cmb_catname.DataSource = dt;
            cmb_catname.DisplayMember = "cat_name"; // Column to display in the ComboBox
            cmb_catname.ValueMember = "cat_id"; // Column to use as the value

            cmb_catname.SelectedIndex = -1;
            cmb_catname.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void side_panel_click(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void side_stocks_click(object sender, EventArgs e)
        {
            options_panel.Visible = true;
        }

        private void btn_picture_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    try
                    {
                        // Convert the image to binary (byte array)
                        byte[] imageData = File.ReadAllBytes(filePath);

                        // Optional: Load the image into a PictureBox
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            picture_upload.Image = System.Drawing.Image.FromStream(ms);
                        }

                        MessageBox.Show("Image loaded successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file path or file not found.");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picture_upload.Image = null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string customerName = txt_tbname.Text.Trim();
            string categoryName = cmb_catname.Text.Trim();
            string itemName = cmb_item.Text.Trim();
            string quantityText = txt_cusqty.Text.Trim();
            string costText = txt_price.Text.Trim();

            byte[] imageData = null;

            try
            {
                // Convert image to byte array
                if (picture_upload.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(picture_upload.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageData = ms.ToArray();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an image!");
                    return;
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(customerName) ||
                    string.IsNullOrWhiteSpace(categoryName) ||
                    string.IsNullOrWhiteSpace(itemName) ||
                    string.IsNullOrWhiteSpace(quantityText) ||
                    string.IsNullOrWhiteSpace(costText))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                int quantity = int.Parse(quantityText);
                decimal cost = decimal.Parse(costText);
                decimal totalCost = quantity * cost;

                int customerId = int.Parse(txt_tbid.Text.Trim()); // Assuming you have a textbox or way to get the customer ID

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCustomerPurchasedItems", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters exactly as your stored procedure expects
                        cmd.Parameters.AddWithValue("@cus_id", customerId);
                        cmd.Parameters.AddWithValue("@cus_name", customerName);
                        cmd.Parameters.AddWithValue("@cat_name", categoryName);
                        cmd.Parameters.AddWithValue("@item_name", itemName);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@total_cost", totalCost);
                        cmd.Parameters.AddWithValue("@pic_upload", imageData ?? (object)DBNull.Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Data Updated Successfully!");

                // Refresh your datagrid and reset the form
                order_listDB();
                txt_tbid.Clear(); // Reset the customer ID field
                txt_tbname.Clear();
                cmb_catname.SelectedIndex = -1;
                cmb_item.SelectedIndex = -1;
                txt_cusqty.Clear();
                txt_price.Clear();
                mfg_dateTime.Value = DateTime.Now;
                picture_upload.Image = null;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (FormatException fmtEx)
            {
                MessageBox.Show($"Invalid input format: {fmtEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(txt_tbid.Text.Trim()); // Assuming you have a textbox to enter the customer ID to delete

                // Validate if customer ID is provided
                if (customerId <= 0)
                {
                    MessageBox.Show("Please provide a valid Customer ID to delete.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteCustomerPurchase", con)) // You need a delete stored procedure
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameter for Customer ID
                        cmd.Parameters.AddWithValue("@cus_id", customerId);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer purchase record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided Customer ID.");
                        }
                    }
                }

                // Refresh your datagrid and reset the form
                order_listDB();
                txt_tbid.Clear(); // Reset the customer ID field
                txt_tbname.Clear();
                cmb_catname.SelectedIndex = -1;
                cmb_item.SelectedIndex = -1;
                txt_cusqty.Clear();
                txt_price.Clear();
                mfg_dateTime.Value = DateTime.Now;
                picture_upload.Image = null;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (FormatException fmtEx)
            {
                MessageBox.Show($"Invalid input format: {fmtEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string customerName = txt_tbname.Text.Trim();
            string categoryName = cmb_catname.Text.Trim();
            string itemName = cmb_item.Text.Trim();
            string quantityText = txt_cusqty.Text.Trim();
            string costText = txt_price.Text.Trim();

            byte[] imageData = null;

            try
            {
                // Convert image to byte array
                if (picture_upload.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(picture_upload.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageData = ms.ToArray();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an image!");
                    return;
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(customerName) ||
                    string.IsNullOrWhiteSpace(categoryName) ||
                    string.IsNullOrWhiteSpace(itemName) ||
                    string.IsNullOrWhiteSpace(quantityText) ||
                    string.IsNullOrWhiteSpace(costText))
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                int quantity = int.Parse(quantityText);
                decimal cost = decimal.Parse(costText);
                decimal totalCost = quantity * cost;

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertCustermerPurchase", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters exactly as your stored procedure expects
                        cmd.Parameters.AddWithValue("@cus_name", customerName);
                        cmd.Parameters.AddWithValue("@cat_name", categoryName);
                        cmd.Parameters.AddWithValue("@item_name", itemName);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@pic_upload", imageData ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@total_cost", totalCost);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Data Inserted Successfully!");

                // Refresh your datagrid and reset the form
                order_listDB();
                txt_tbid.Clear(); // Reset the customer ID field
                txt_tbname.Clear();
                cmb_catname.SelectedIndex = -1;
                cmb_item.SelectedIndex = -1;
                txt_cusqty.Clear();
                txt_price.Clear();
                mfg_dateTime.Value = DateTime.Now;
                picture_upload.Image = null;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (FormatException fmtEx)
            {
                MessageBox.Show($"Invalid input format: {fmtEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }



        private void cmb_catname_selectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_catname.SelectedValue != null && cmb_catname.SelectedValue != DBNull.Value)
            {
                // Parse SelectedValue to integer
                var selectedItemId = Convert.ToInt32(cmb_catname.SelectedIndex);
                LoadComboBox(selectedItemId);
                txt_cusqty.Text = string.Empty;
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
                using (SqlConnection conn = new SqlConnection(connectionstring))
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



                cmb_item.DataSource = dt;
                cmb_item.DisplayMember = "ItemName";
                //cmb_item_name.ValueMember = "ItemID";

                // Set default to placeholder
                cmb_item.SelectedIndex = 0;
                cmb_item.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                if (ex.Equals(0) || ex.Equals(null))
                {
                    cmb_item.Text = string.Empty;
                }
                MessageBox.Show($"No Items Available in this Index", "Choose Another", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbl_syrup_Click(object sender, EventArgs e)
        {
            Syrup_Page syrup_Page = new Syrup_Page();
            syrup_Page.Show();
            this.Hide();
        }
    }
}
