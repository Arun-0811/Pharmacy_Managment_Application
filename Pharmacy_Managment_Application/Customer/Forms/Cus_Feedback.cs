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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Managment_Application.Customer.Forms
{
    public partial class Cus_Feedback : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public Cus_Feedback()
        {
            InitializeComponent(); IpAddress();
            dateTime();
            welcome_load();
            txt_name.ReadOnly = true;

        }

        public void welcome_load()
        {

            string email = GlobalUser.LoggedInUser; // the email you stored earlier
            string userName = "";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT user_name FROM User_Login WHERE User_Email = @email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    var result = cmd.ExecuteScalar(); // only expecting a single value

                    if (result != null)
                    {
                        userName = result.ToString();
                    }
                }
            }

            lbl_welcome.Text = "Welcome, " + userName + "!";
            txt_name.Text = userName.Trim();

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
            string username = txt_name.Text.Trim();
            string feedback = txt_feedback.Text.Trim();


            if (string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Please fill the field");
                return;
            }
            else
            {

                SqlConnection con = new SqlConnection(connectionstring);
                string query = "sp_CustomerInsertFeedback";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", username);
                
                cmd.Parameters.AddWithValue("@feedback", feedback);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully");



                txt_name.Text = string.Empty;
                
                txt_feedback.Text = string.Empty;


            }
        }
    }
}
