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
using static Pharmacy_Managment_Application.Login;

namespace Pharmacy_Managment_Application
{
    public partial class Reset_Password : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public Reset_Password()
        {
            InitializeComponent();
            txt_new_reset_email.Text = GlobalUser.LoggedInUser;
        }

        



        private void btn_reset_submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UPDATE tbl_login SET password = @password WHERE user_email = @Useremail", con))
            {
                // Regular expression for email validation
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(txt_new_reset_email.Text, emailPattern))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if email is invalid
                }
                String useremail = txt_new_reset_email.Text;
                String newPassword = txt_new_reset_password1.Text;
                // Add parameters
                //if(txt_new_reset_password2.Text != null && newPassword != null)
                if (!string.IsNullOrWhiteSpace(txt_new_reset_password2.Text) && !string.IsNullOrWhiteSpace(newPassword))
                {
                    if (newPassword == txt_new_reset_password2.Text)
                    {
                        cmd.Parameters.AddWithValue("@Useremail", useremail);
                        cmd.Parameters.AddWithValue("@Password", newPassword);

                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully...!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Login login = new Login();
                                login.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Password not updated....!", "Feilds Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password Not Same...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (string.IsNullOrWhiteSpace(useremail) && string.IsNullOrWhiteSpace(newPassword) && string.IsNullOrWhiteSpace(txt_new_reset_password2.Text))
                {
                    MessageBox.Show("Plese Enter all Feilds...!", "Empty Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void lnk_move_loginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void clik_close(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
    }
}
