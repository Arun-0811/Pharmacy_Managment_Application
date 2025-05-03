using Pharmacy_Managment_Application.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class Tablets_Page : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        private int selectedOrderID;

        private ToolTip toolTip;

        public Tablets_Page()
        {
            InitializeComponent();

            picture_upload.Image = null;
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

        public void dateTime()
        {
            lbl_datetime.Text = DateTime.Now.ToString();
        }
        private void btn_picture_Click(object sender, EventArgs e)
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

        private void oder_add_click(object sender, EventArgs e)
        {
            string Product_Name = txt_tbname.Text.Trim();
            string Category_Name = cmb_catname.Text;
            string Quantity = txt_tbquant.Text.Trim();
            string Price = txt_price.Text.Trim();
            DateTime Mfgdate = mfg_dateTime.Value;
            DateTime Expirydate = DateTime.Parse(txt_expirydate.Text);

            byte[] imageData = null;

            try
            {
                // Convert PictureBox image into byte array
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
                    MessageBox.Show("No image selected!");
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(Product_Name) ||
                    string.IsNullOrWhiteSpace(Category_Name) ||
                    string.IsNullOrWhiteSpace(Quantity) ||
                    string.IsNullOrWhiteSpace(Price) ||
                    imageData == null)
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "InsertTablet";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Add parameters to command
                        cmd.Parameters.AddWithValue("@tab_name", Product_Name);
                        cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(Quantity));
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(Price));
                        cmd.Parameters.AddWithValue("@mfgdate", Mfgdate);
                        cmd.Parameters.AddWithValue("@expiry", Expirydate);
                        cmd.Parameters.AddWithValue("@pic_upload", imageData);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Data Inserted Successfully");
                tablet_listDB();

                // Reset fields
                txt_tbname.Clear();
                cmb_catname.SelectedIndex = 0;
                txt_tbquant.Clear();
                txt_price.Clear();
                mfg_dateTime.Value = DateTime.Now;
                txt_expirydate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                picture_upload.Image = null;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
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

        private void order_save_click(object sender, EventArgs e)
        {
            if (tablets_tbl.SelectedRows.Count > 0) // Ensure a row is selected
            {
                int product_Id = selectedOrderID;
                string Product_Name = txt_tbname.Text.Trim();
                string Category_Name = cmb_catname.Text.Trim();
                int Quantity = int.Parse(txt_tbquant.Text.Trim()); // Convert to int
                decimal Price = decimal.Parse(txt_price.Text.Trim()); // Convert to decimal
                string Mfgdate = mfg_dateTime.Text.Trim();
                string Expirydate = txt_expirydate.Text.Trim();
                string Total_price = txt_totalprice.Text.Trim();
                byte[] imageData = null;

                txt_tbid.ReadOnly = true;
                txt_totalprice.ReadOnly = true;
                

                if (picture_upload.Image != null)
                {
                    // Clone into a 24bpp RGB bitmap
                    using (var original = picture_upload.Image)
                    using (var clone = new Bitmap(original.Width, original.Height,
                                                  PixelFormat.Format24bppRgb))
                    {
                        using (var g = Graphics.FromImage(clone))
                        {
                            g.DrawImage(original, 0, 0, original.Width, original.Height);
                        }

                        // Now saving the clone will work
                        using (var ms = new MemoryStream())
                        {
                            clone.Save(ms, ImageFormat.Png);
                            imageData = ms.ToArray();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please upload an image before saving.");
                    return;
                }


                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "sp_UpdateTablet";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", product_Id);
                        cmd.Parameters.AddWithValue("@name", Product_Name);
                        cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                        cmd.Parameters.AddWithValue("@quantity", Quantity);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.Parameters.AddWithValue("@mfgdate", Mfgdate);
                        cmd.Parameters.AddWithValue("@expiry", Expirydate);
                        cmd.Parameters.AddWithValue("@pic_upload", imageData ?? (object)DBNull.Value); // Handle null image

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Updated Successfully");
                tablet_listDB(); // Refresh the DataGridView
                ToggleControls(false);
                cmb_catname.DropDownStyle = ComboBoxStyle.DropDownList;

                // Reset fields after update
                txt_tbname.Text = string.Empty;
                cmb_catname.SelectedIndex = 0;
                txt_tbquant.Text = string.Empty;
                txt_price.Text = string.Empty;
                mfg_dateTime.Text = string.Empty;
                txt_expirydate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txt_totalprice.Text = string.Empty;
                picture_upload.Image = null; // Clear PictureBox
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void order_delete_click(object sender, EventArgs e)
        {
            if (tablets_tbl.SelectedRows.Count > 0) // Ensure a row is selected
            {
                int product_Id = selectedOrderID;
                string Product_Name = txt_tbname.Text.Trim();
                string Category_Name = cmb_catname.Text.Trim();
                int Quantity = int.Parse(txt_tbquant.Text.Trim()); // Convert to int
                decimal Price = decimal.Parse(txt_price.Text.Trim()); // Convert to decimal
                string Mfgdate = mfg_dateTime.Text.Trim();
                string Expirydate = txt_expirydate.Text.Trim();
                string Total_price = txt_totalprice.Text.Trim();

                txt_tbid.ReadOnly = true;
                txt_totalprice.ReadOnly = true;
                txt_price.ReadOnly = true;


                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "DeleteTabletItem";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", product_Id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("Data Deleted Successfully");
                tablet_listDB(); // Refresh the GridView
                ToggleControls(false);
                txt_tbname.Text = string.Empty;
                cmb_catname.SelectedIndex = 0;
                txt_tbquant.Text = string.Empty;
                txt_price.Text = string.Empty;
                mfg_dateTime.Text = string.Empty;
                txt_expirydate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txt_totalprice.Text = string.Empty;
                picture_upload.Image = null;
                cmb_catname.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
        public void category_db()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select cat_name from Category_Name";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            cmb_catname.DataSource = null;
            cmb_catname.DataSource = dataTable;
            cmb_catname.DisplayMember = "cat_name";
            cmb_catname.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void tablet_listDB()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from tbl_tablets";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            tablets_tbl.DataSource = dataTable;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }


        private void lbl_syrup_click(object sender, EventArgs e)
        {
            Syrup_Page syrup = new Syrup_Page();
            syrup.Show();
            this.Hide();
        }

        private void lbl_surgical_click(object sender, EventArgs e)
        {
            Surgical_Items_Page surgical_Items_Page = new Surgical_Items_Page();
            surgical_Items_Page.Show();
            this.Hide();
        }

        private void side_panelclick(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void Tablets_Page_Load(object sender, EventArgs e)
        {
            options_panel.Visible = false;
            category_db();
            tablet_listDB();
            ToggleControls(false);
            IpAddress();
            dateTime();
            toolTip = new ToolTip(); // Initialize tooltip

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

        private void tablet_list_tbl_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablets_tbl.Rows[e.RowIndex];
                txt_tbid.Text = row.Cells["tab_id"].Value?.ToString();
                txt_tbname.Text = row.Cells["tab_name"].Value?.ToString();
                txt_tbquant.Text = row.Cells["tab_quantity"].Value?.ToString();
                txt_price.Text = row.Cells["tab_price"].Value?.ToString();
                mfg_dateTime.Text = row.Cells["default_date"].Value?.ToString();
                txt_expirydate.Text = row.Cells["tab_expiry"].Value?.ToString();
                txt_totalprice.Text = row.Cells["total_price"].Value?.ToString();

                // Retrieve binary data for the image
                byte[] imageData = row.Cells["picture_upload"].Value as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picture_upload.Image = System.Drawing.Image.FromStream(ms); // Convert to Image and load into PictureBox
                    }
                }
                else
                {
                    picture_upload.Image = null; // Clear PictureBox if no image is available
                }

                // Fetch cat_name based on cat_id
                int catId = Convert.ToInt32(row.Cells["cat_id"].Value);
                string categoryName = GetCategoryNameById(catId); // Fetch the category name using helper method
                cmb_catname.Text = categoryName; // Set the category name into the combobox

                // Store OrderID for update
                selectedOrderID = Convert.ToInt32(row.Cells["tab_id"].Value);
                ToggleControls(true);
                btn_insert_disable(true);
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

        private void side_overview_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        

        private void side_stocks_Click(object sender, EventArgs e)
        {
            options_panel.Visible = true;
        }

        private void Tablets_Page_click(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void side_orderlist_Click(object sender, EventArgs e)
        {
            Order_List order_List = new Order_List();
            order_List.Show();
            this.Hide();
        }

        private void side_feedback_Click(object sender, EventArgs e)
        {
            Feedback_Page feedback_Page = new Feedback_Page();
            feedback_Page.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picture_upload.Image = null;
        }

        private void lbl_billingDetails_Click(object sender, EventArgs e)
        {
            BillingDetails billingDetails = new BillingDetails();
            billingDetails.Show();
            this.Hide();
        }
    }
}

