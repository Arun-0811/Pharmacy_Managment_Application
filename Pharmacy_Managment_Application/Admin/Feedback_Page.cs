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
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class Feedback_Page : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        private ToolTip toolTip;

        public Feedback_Page()
        {
            InitializeComponent();
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

        private void Syrup_Page_Load(object sender, EventArgs e)
        {
            options_panel.Visible = false;
            
            IpAddress();
            dateTime();
            toolTip = new ToolTip(); // Initialize tooltip

            // Set tooltip for textboxes
            toolTip.SetToolTip(side_overview, "click to view overview information");
            toolTip.SetToolTip(side_orderlist, "click to view order list details");
            toolTip.SetToolTip(side_stocks, "click to view total stocks details");
            toolTip.SetToolTip(lbl_surgical, "click to view surgical stocks details");
            toolTip.SetToolTip(lbl_tablets, "click to view tablet stocks details");
            toolTip.SetToolTip(lbl_syrup, "click to view syrup stocks details");
            toolTip.SetToolTip(side_billing, "After taken Order Go to Purchase Page");
            toolTip.SetToolTip(side_feedback, "feedback Page");
           
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
    }

}
