using Pharmacy_Managment_Application.Admin;
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
using static Pharmacy_Managment_Application.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace Pharmacy_Managment_Application
{
    public partial class Dashboard : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        private ToolTip toolTip;
        public Dashboard()
        {
            InitializeComponent();
            welcome_load();
            BindMergedDataToGrid();
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

            lbl_welcome.Text = "Welcome,"+userName+"!";
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
                        lbl_ip_addres.Text = ip.ToString();
                        return;
                    }
                }

                label1.Text = "No IPv4 address found.";
            }
            catch (Exception ex)
            {
                lbl_ip_addres.Text = "Error: " + ex.Message;
            }
        }

        public void dateTime()
        {
            lbl_datetime.Text = DateTime.Now.ToString();
        }

        private void exit_btn_click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        public void category_db()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from Category_Name";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            category_tbl.DataSource = dataTable;
        }

        private void BindMergedDataToGrid()
        {            
            string storedProcedure = "sp_MergeCategoryItems";
            
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(storedProcedure, conn)
                {                    
                    SelectCommand = { CommandType = CommandType.StoredProcedure }
                };
                
                DataTable resultTable = new DataTable();

                try
                {                    
                    dataAdapter.Fill(resultTable);                    
                    totalstocks_tbl.DataSource = resultTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur during the database operation
                    MessageBox.Show($"Error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DBDataSet.tbl_orderlist' table. You can move, or remove it, as needed.
            
            options_panel.Visible = false;
            IpAddress();
            dateTime();
            category_db();
            BindMergedDataToGrid();
            toolTip = new ToolTip(); // Initialize tooltip
            

            // Set tooltip for textboxes
            toolTip.SetToolTip(side_overview, "click to view overview information");
            toolTip.SetToolTip(side_orderlist, "click to view order list details");
            toolTip.SetToolTip(side_stocks, "click to view total stocks details");
            
            toolTip.SetToolTip(lbl_surgical, "click to view surgical stocks details");
            toolTip.SetToolTip(lbl_tablets, "click to view tablet stocks details");
            toolTip.SetToolTip(lbl_syrup, "click to view syrup stocks details");
            toolTip.SetToolTip(side_feedback, "feedback Page");

        }

        private void side_orderlist_Click(object sender, EventArgs e)
        {
            Order_List order_List = new Order_List();
            order_List.Show();
            this.Hide();
        }

        private void side_stocks_Click(object sender, EventArgs e)
        {
            options_panel.Visible = true;
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            Feedback_Page feedback_Page = new Feedback_Page();
            feedback_Page.Show();
            this.Hide();
        }

        private void lbl_syrup_Click(object sender, EventArgs e)
        {
            Syrup_Page srp = new Syrup_Page();
            srp.Show();
            this.Hide();
        }

        private void Dashboard_click(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void side_panel_click(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void lbl_tablets_Click_1(object sender, EventArgs e)
        {
            Tablets_Page tablets = new Tablets_Page();
            tablets.Show();
            this.Hide();
        }

        private void lbl_surgical_Click_1(object sender, EventArgs e)
        {
            Surgical_Items_Page surgical_Items_Page = new Surgical_Items_Page();
            surgical_Items_Page.Show();
            this.Hide();
        }

        private void lbl_logout(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void category_nameTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = category_tbl.Rows[e.RowIndex];

                // Assuming your DataGridView column is named "cat_name"
                lbl_id.Text = row.Cells["cat_id"].Value?.ToString();
                txt_catName.Text = row.Cells["cat_name"].Value?.ToString();
                btn_add.Enabled = false; // Hide Add button
            }


        }      

        

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_catName.Text))
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "INSERT INTO Category_Name (cat_name) VALUES (@cat_name)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cat_name", txt_catName.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Category Added Successfully!");
                category_db(); // Refresh DataGridView
                txt_catName.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lbl_id.Text) && !string.IsNullOrWhiteSpace(txt_catName.Text))
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "UPDATE Category_Name SET cat_name = @cat_name WHERE cat_id = @cat_id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cat_name", txt_catName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat_id", int.Parse(lbl_id.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Category Updated Successfully!");
                category_db();
                lbl_id.Text = "";
                txt_catName.Text = "";
                btn_add.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lbl_id.Text))
            {
                var result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        string query = "DELETE FROM Category_Name WHERE cat_id = @cat_id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@cat_id", int.Parse(lbl_id.Text));

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    MessageBox.Show("Category Deleted Successfully!");
                    category_db();
                    lbl_id.Text = "";
                    txt_catName.Text = "";
                    btn_add.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }

        private void lbl_billing_click(object sender, EventArgs e)
        {
            BillingDetails billingDetails = new BillingDetails();
            billingDetails.Show();
            this.Hide();
        }
    }
}

