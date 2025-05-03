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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Managment_Application
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        public static class GlobalUser
        {
            public static string LoggedInUser { get; set; }
            
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please enter User-email and Password");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    
                    string email = txt_email.Text.Trim();
                    string emailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    string password = txt_password.Text.Trim();


                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("@email", email);
                        if (!Regex.IsMatch(email, emailpattern))
                        {
                            MessageBox.Show("Invalid email format");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@pwd", password);

                        con.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (email == "admin@gmail.com" && password == "admin432")
                        {
                            if(count == 1)
                            {
                                MessageBox.Show("Permission Granted!");
                                GlobalUser.LoggedInUser = email;
                                new Dashboard().Show();
                                this.Hide();
                            }
                            
                        }
                        else if (count == 1)
                        {
                            MessageBox.Show("Permission Granted!");
                            GlobalUser.LoggedInUser = email;
                            new Customer_Dashboard().Show();
                            this.Hide();
                        }
                        
                        else
                        {
                            MessageBox.Show("Invalid Email or Password");
                            txt_email.Clear();
                            txt_password.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();

        }

        private void lnk_lbl_forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password_Page FPP = new Forgot_Password_Page(); 
            FPP.Show();
            this.Hide();
        }

        private void btn1_register1_Click(object sender, EventArgs e)
        {
            Register_Page RP = new Register_Page();
            RP.Show();
            this.Hide();
        }

        
    }
}
