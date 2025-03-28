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

namespace Pharmacy_Managment_Application
{
    public partial class Syrup_Page : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        private ToolTip toolTip;

        private int selectedOrderID;
        public Syrup_Page()
        {
            InitializeComponent();
            picture_upload.Image = null;
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

        }
        public void order_listDB()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from tbl_syrup";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            syruplist_tbl.DataSource = dataTable;
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


        private void syruplist_tbl_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = syruplist_tbl.Rows[e.RowIndex];
                txt_tbid.Text = row.Cells["syrup_id"].Value?.ToString();
                txt_tbname.Text = row.Cells["syrup_name"].Value?.ToString();
                cmb_catname.Text = row.Cells["category_name"].Value?.ToString();
                txt_tbquant.Text = row.Cells["syrup_quantity"].Value?.ToString();
                txt_price.Text = row.Cells["syrup_price"].Value?.ToString();
                mfg_dateTime.Text = row.Cells["default_date"].Value?.ToString();
                txt_expirydate.Text = row.Cells["syrup_expiry"].Value?.ToString();
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
                // Store OrderID for update
                selectedOrderID = Convert.ToInt32(row.Cells["syrup_id"].Value);
                ToggleControls(true);
                btn_insert_disable(true);
            }
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

        private void side_billing_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void side_feedback_Click(object sender, EventArgs e)
        {
            Feedback_Page feedback = new Feedback_Page();
            feedback.Show();
            this.Hide();
        }

        private void Syrup_Page_Load(object sender, EventArgs e)
        {
            options_panel.Visible = false;
            category_db();
            order_listDB();
            ToggleControls(false);
            IpAddress();
            dateTime();
            toolTip = new ToolTip(); // Initialize tooltip

            txt_totalprice.Enabled = false;
            lbl_totalprice.Enabled = false;
           

            // Set tooltip for textboxes
            toolTip.SetToolTip(side_overview, "click to view overview information");
            toolTip.SetToolTip(side_orderlist, "click to view order list details");
            toolTip.SetToolTip(side_stocks, "click to view total stocks details");
            toolTip.SetToolTip(lbl_surgical, "click to view surgical stocks details");
            toolTip.SetToolTip(lbl_tablets, "click to view tablet stocks details");
            toolTip.SetToolTip(lbl_syrup, "click to view syrup stocks details");
            toolTip.SetToolTip(side_billing, "After taken Order Go to Purchase Page");
            toolTip.SetToolTip(side_feedback, "feedback Page");
            toolTip.SetToolTip(btn_insert, "After Given data click insert");
            toolTip.SetToolTip(btn_update, "After Given data click update");
            toolTip.SetToolTip(btn_delete, "After Given data click delete");
            toolTip.SetToolTip(lbl_ip_address, "Your IP Address");
            toolTip.SetToolTip(btn_exit, "exit button");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void Syrup_Page_click(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }       

        private void side_stocks_Click(object sender, EventArgs e)
        {
            options_panel.Visible = true;
        }

        private void side_panel_click(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void oder_add_click(object sender, EventArgs e)
        {
            string Product_Name = txt_tbname.Text.Trim();
            string Category_Name = cmb_catname.Text.Trim();
            string Quantity = txt_tbquant.Text.Trim();
            string Price = txt_price.Text.Trim();
            string Mfgdate = mfg_dateTime.Text.Trim();
            string Expirydate = txt_expirydate.Text.Trim();

            byte[] imageData = null;

            try
            {
                // Check if the PictureBox contains an image
                if (picture_upload.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        var clonedImage = (System.Drawing.Image)picture_upload.Image.Clone(); // Clone the image
                        clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save the cloned image
                        imageData = ms.ToArray();
                    }
                }

                // Validate inputs
                if (!string.IsNullOrWhiteSpace(Product_Name) &&
                    !string.IsNullOrWhiteSpace(Category_Name) &&
                    !string.IsNullOrWhiteSpace(Quantity) &&
                    !string.IsNullOrWhiteSpace(Price) &&
                    !string.IsNullOrWhiteSpace(Mfgdate) &&
                    !string.IsNullOrWhiteSpace(Expirydate) &&
                    imageData != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        string query = "INSERT INTO tbl_syrup (syrup_name, category_name, syrup_quantity, syrup_price, default_date, syrup_expiry, picture_upload) VALUES (@name, @cat_name, @quanty, @price,@mfgdate, @expiry, @pic_upload)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", Product_Name);
                            cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                            cmd.Parameters.AddWithValue("@quanty", Quantity);
                            cmd.Parameters.AddWithValue("@price", Price);
                            cmd.Parameters.AddWithValue("@mfgdate", Mfgdate);
                            cmd.Parameters.AddWithValue("@expiry", Expirydate);
                            cmd.Parameters.AddWithValue("@pic_upload", imageData);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    MessageBox.Show("Data Inserted Successfully");
                    order_listDB(); // Refresh the DataGridView

                    txt_tbname.Text = string.Empty;
                    cmb_catname.SelectedIndex = 0;
                    txt_tbquant.Text = string.Empty;
                    txt_price.Text = string.Empty;
                    mfg_dateTime.Text = string.Empty;
                    txt_expirydate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    picture_upload.Image = null; // Clear the PictureBox
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

        private void order_save_click(object sender, EventArgs e)
        {
            if (syruplist_tbl.SelectedRows.Count > 0) // Ensure a row is selected
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

                // Convert PictureBox image to byte[] if present
                if (picture_upload.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picture_upload.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save as PNG format
                        imageData = ms.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show("Please upload an image before saving.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "UPDATE tbl_syrup SET syrup_name = @name, category_name = @cat_name, syrup_quantity = @quantity, syrup_price = @price, default_date=@mfgdate, syrup_expiry = @expiry, picture_upload = @pic_upload WHERE syrup_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
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
                order_listDB(); // Refresh the DataGridView
                ToggleControls(false);

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
            if (syruplist_tbl.SelectedRows.Count > 0) // Ensure a row is selected
            {
                int product_Id = selectedOrderID;
                string Product_Name = txt_tbname.Text.Trim();
                string Category_Name = cmb_catname.Text.Trim();
                int Quantity = int.Parse(txt_tbquant.Text.Trim()); // Convert to int
                decimal Price = decimal.Parse(txt_price.Text.Trim()); // Convert to decimal
                string Mfgdate = mfg_dateTime.Text.Trim();
                string Expirydate = txt_expirydate.Text.Trim();
                string Total_price = txt_totalprice.Text.Trim();

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "delete from  tbl_syrup WHERE syrup_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", product_Id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("Data Deleted Successfully");
                order_listDB(); // Refresh the GridView
                ToggleControls(false);
                txt_tbname.Text = string.Empty;
                cmb_catname.SelectedIndex = 0;
                txt_tbquant.Text = string.Empty;
                txt_price.Text = string.Empty;
                mfg_dateTime.Text = string.Empty;
                txt_expirydate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txt_totalprice.Text = string.Empty;
                picture_upload.Image = null;
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
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


        private void btn_clear_Click(object sender, EventArgs e)
        {
            picture_upload.Image = null;
        }

        
    }
}
