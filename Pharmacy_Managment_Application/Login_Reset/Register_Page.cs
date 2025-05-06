using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class Register_Page : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        public Register_Page()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {

            // Regular expression for email validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txt_email_id.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if email is invalid
            }
            string username = txt_name.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Register", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add parameters
                    cmd.Parameters.AddWithValue("@useremail", txt_email_id.Text);
                    cmd.Parameters.AddWithValue("@password", txt_pwd.Text);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@phoneno", txt_phoneno.Text);
                    cmd.Parameters.AddWithValue("@place", txt_place.Text);
                    

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            Login login_Page = new Login();
                            login_Page.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No data was inserted.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }

                }
            }
        }

        //private void lnl_Login_redirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Login login_Pageobj = new Login();
        //    login_Pageobj.Show();
        //    this.Hide();
        //}

        
              
        private void lnk_lbl_Account_have_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void close_click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
    }
}
