using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class Forgot_Password_Page : Form
    {
        String randcode;
        String to;
        public Forgot_Password_Page()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //My Code
            if (to != null)
            {
                String from, pass, messagebox;
                Random rand = new Random();
                randcode = (rand.Next(999999).ToString());

                MailMessage message = new MailMessage();
                to = (txt_new_Email.Text).ToString();
                from = "type8meenu@gmail.com";
                pass = "xjrn gjre jwky liwh";

                messagebox = "Your Verification OTP : " + randcode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebox;
                message.Subject = "OTP Verification";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("OTP sent Successfully...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Email...!");

            }
        }

        private void btn_verfiy_Click(object sender, EventArgs e)
        {

            //my code

            if (randcode == txt_otpverify.Text.ToString())
            {
                MessageBox.Show("OTP Verified Successfully");
                Reset_Password Reset_Pass = new Reset_Password();
                Reset_Pass.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Plese Provide Valid Email and OTP...!");
            }

        }        

        private void login_move_cliked(object sender, EventArgs e)
        {
            Login Login_Page = new Login();
            Login_Page.Show();
            this.Hide();
        }
    }
}
