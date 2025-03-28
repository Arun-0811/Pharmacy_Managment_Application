using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static Pharmacy_Managment_Application.Login;

namespace Pharmacy_Managment_Application.Customer.Forms
{
    public partial class Cus_Feedback : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public Cus_Feedback()
        {
            InitializeComponent(); IpAddress();
            dateTime();
            lbl_welcome.Text = "Welcome, " + GlobalUser.LoggedInUser + "!";
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

        private void feedback_mousehover(object sender, EventArgs e)
        {
            btn_sendfeedback.ForeColor=Color.GreenYellow;
        }

        private void btn_sendfeedback_Click(object sender, EventArgs e)
        {
            string Name = txt_name.Text.Trim();
            string email = txt_email.Text.Trim();
            string phone = txt_phoneno.Text.Trim();
            string place = txt_place.Text.Trim();
            string feedback = txt_feedback.Text.Trim();


            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(place) || string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {

                SqlConnection con = new SqlConnection(connectionstring);
                string query = "insert into tbl_feedback values (@name,@email,@phone,@place,@feedback)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@place", place);
                cmd.Parameters.AddWithValue("@feedback", feedback);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully");



                txt_name.Text = string.Empty;
                txt_email.Text = string.Empty;
                txt_phoneno.Text = string.Empty;
                txt_place.Text = string.Empty;
                txt_feedback.Text = string.Empty;


            }
        }
    }
}
