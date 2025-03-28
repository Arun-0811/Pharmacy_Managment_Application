using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application.Forms
{
    public partial class FormOrder_Request : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public FormOrder_Request()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                            picbox_prescrip.Image = System.Drawing.Image.FromStream(ms);
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

        private void button1_Click(object sender, EventArgs e)
        {
            picbox_prescrip.Image = null;
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

        private void FormOrder_Request_Load(object sender, EventArgs e)
        {
            category_db();
            picbox_prescrip.Image = null;
        }

        private void btn_cus_order_Click(object sender, EventArgs e)
        {
            string Product_Name = txt_ptname.Text.Trim();
            string Category_Name = cmb_catname.Text.Trim();
            string Quantity = txt_quant.Text.Trim();           
            byte[] imageData = null;

            try
            {
                // Check if the PictureBox contains an image
                if (picbox_prescrip.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        var clonedImage = (System.Drawing.Image)picbox_prescrip.Image.Clone(); // Clone the image
                        clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save the cloned image
                        imageData = ms.ToArray();
                    }
                }

                // Validate inputs
                if (!string.IsNullOrWhiteSpace(Product_Name) &&
                    !string.IsNullOrWhiteSpace(Category_Name) &&
                    !string.IsNullOrWhiteSpace(Quantity) &&                    
                    imageData != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        string query = "INSERT INTO tbl_orderlist (pt_name, cat_name, pt_quantity, prescription) VALUES (@name, @cat_name, @quanty, @pic_upload)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", Product_Name);
                            cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                            cmd.Parameters.AddWithValue("@quanty", Quantity);                            
                            cmd.Parameters.AddWithValue("@pic_upload", imageData);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    MessageBox.Show("Data Inserted Successfully");

                    txt_ptname.Text = string.Empty;
                    cmb_catname.SelectedIndex = 0;
                    txt_quant.Text = string.Empty;

                    picbox_prescrip.Image = null; // Clear the PictureBox
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

        
    }
}
