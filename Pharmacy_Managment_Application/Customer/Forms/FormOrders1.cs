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
using static Pharmacy_Managment_Application.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Managment_Application.Forms
{
    public partial class FormOrder_Request : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public FormOrder_Request()
        {
            InitializeComponent();
            IpAddress();
            dateTime();
            welcome_load();
        }

        public void welcome_load()
        {
            string email = GlobalUser.LoggedInUser; // the email you stored earlier
            string userName = "";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "SELECT user_name FROM User_Login WHERE User_Email = @email";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    var result = cmd.ExecuteScalar(); // only expecting a single value

                    if (result != null)
                    {
                        userName = result.ToString();
                    }
                }
            }

            lbl_welcome.Text = "Welcome," + userName + "!";
            txt_name.Text = userName;
            txt_name.ReadOnly = true;
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
            cmb_catname.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void FormOrder_Request_Load(object sender, EventArgs e)
        {
            category_db();
            picbox_prescrip.Image = null;
        }

        private void btn_cus_order_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text.Trim();
            string Product_Name = txt_ptname.Text.Trim();
            string Category_Name = cmb_catname.Text.Trim();
            string Quantity = txt_quant.Text.Trim();
            byte[] imageData = null;

            try
            {
                if (picbox_prescrip.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(picbox_prescrip.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageData = ms.ToArray();
                        }
                    }
                }


                // Validate inputs (except imageData, which is optional now)
                if (!string.IsNullOrWhiteSpace(username) &&
                    !string.IsNullOrWhiteSpace(Product_Name) &&
                    !string.IsNullOrWhiteSpace(Category_Name) &&
                    !string.IsNullOrWhiteSpace(Quantity))
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        string query = "sp_CustomerInsertOrderList";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@cus_name", username);
                            cmd.Parameters.AddWithValue("@name", Product_Name);
                            cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                            cmd.Parameters.AddWithValue("@quanty", Quantity);

                            if (imageData != null)
                            {
                                cmd.Parameters.AddWithValue("@pic_upload", imageData);
                            }
                            else
                            {
                                cmd.Parameters.Add("@pic_upload", SqlDbType.VarBinary).Value = DBNull.Value;
                            }


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
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



    }
}
