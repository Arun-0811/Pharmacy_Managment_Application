using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class Order_List : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        
        private int selectedOrderID;        

        private ToolTip toolTip;

        public Order_List()
        {
            InitializeComponent();

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

        private void oder_add_click(object sender, EventArgs e)
        {
            string Product_Name = txt_ptname.Text.Trim();
            string Category_Name = cmb_catname.Text.Trim();
            string Quantity = txt_quant.Text.Trim();
            string Price = txt_price.Text.Trim();

            if (string.IsNullOrWhiteSpace(Product_Name) || string.IsNullOrWhiteSpace(Category_Name) || string.IsNullOrWhiteSpace(Quantity) || string.IsNullOrWhiteSpace(Price))
            {
                MessageBox.Show("Please fill all the fields");
                return;                
            }
            else
            {

                SqlConnection con = new SqlConnection(connectionstring);
                string query = "insert into tbl_orderlist (pt_name, cat_name, pt_quantity,pt_price) values (@name,@cat_name,@quanty,@price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", Product_Name);
                cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                cmd.Parameters.AddWithValue("@quanty", Quantity);
                cmd.Parameters.AddWithValue("@price", Price);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully");
                order_listDB();


                txt_ptname.Text = string.Empty;
                cmb_catname.SelectedIndex=0;
                txt_quant.Text = string.Empty;
                txt_price.Text = string.Empty;

            }
        }
        private void ToggleControls(bool isEditing)
        {
            if (isEditing)
            {
               txt_ptid.Visible = true;
               lbl_ptid1.Visible = true;
            }
            else
            {
                txt_ptid.Visible = false;
                lbl_ptid1.Visible = false;
            }
        }

        private void btn_insert_disable(bool isEditing)
        {
            if (isEditing)
            {
                btn_insert.Enabled = false;
            }
            else
            {
                btn_insert.Enabled = true;
            }
        }


        private void order_save_click(object sender, EventArgs e)
        {
            if (orderlist_tbl.SelectedRows.Count > 0) // Ensure a row is selected
            {
                int product_Id = selectedOrderID;
                string Product_Name = txt_ptname.Text.Trim();
                string Category_Name = cmb_catname.Text.Trim();
                int Quantity = int.Parse(txt_quant.Text.Trim()); // Convert to int
                decimal Price = decimal.Parse(txt_price.Text.Trim()); // Convert to decimal

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "UPDATE tbl_orderlist SET pt_name = @name, cat_name = @cat_name, pt_quantity = @quantity, pt_price = @price WHERE pt_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", product_Id);
                        cmd.Parameters.AddWithValue("@name", Product_Name);
                        cmd.Parameters.AddWithValue("@cat_name", Category_Name);
                        cmd.Parameters.AddWithValue("@quantity", Quantity);
                        cmd.Parameters.AddWithValue("@price", Price);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    
                }

                MessageBox.Show("Data Updated Successfully");
                order_listDB(); // Refresh the GridView
                ToggleControls(false);
                txt_ptname.Text = string.Empty;
                cmb_catname.SelectedIndex = 0;
                txt_quant.Text = string.Empty;
                txt_price.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
                        
        }

        private void order_delete_click(object sender, EventArgs e)
        {
            if (orderlist_tbl.SelectedRows.Count > 0) // Ensure a row is selected
            {
                int product_Id = selectedOrderID;
                string Product_Name = txt_ptname.Text.Trim();
                string Category_Name = cmb_catname.Text.Trim();
                int Quantity = int.Parse(txt_quant.Text.Trim()); // Convert to int
                decimal Price = decimal.Parse(txt_price.Text.Trim()); // Convert to decimal

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "delete from  tbl_orderlist WHERE pt_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", product_Id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("Data Updated Successfully");
                order_listDB(); // Refresh the GridView
                ToggleControls(false);
                txt_ptname.Text = string.Empty;
                cmb_catname.SelectedIndex = 0;
                txt_quant.Text = string.Empty;
                txt_price.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
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
        public void order_listDB()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from tbl_orderlist";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            orderlist_tbl.DataSource = dataTable;
        }
        private void Order_List_Load(object sender, EventArgs e)
        {
            options_panel.Visible = false;
            category_db();
            order_listDB();
            ToggleControls(false);
            IpAddress();
            dateTime();
            toolTip = new ToolTip(); // Initialize tooltip

            // Set tooltip for textboxes
            toolTip.SetToolTip(side_overview, "click to view overview information");
            toolTip.SetToolTip(side_orderlist, "click to view order list details");
            toolTip.SetToolTip(side_stocks, "click to view total stocks details");
            toolTip.SetToolTip(side_billing, "After taken Order Go to Purchase Page");
            toolTip.SetToolTip(btn_insert, "After Given data click insert");
            toolTip.SetToolTip(btn_update, "After Given data click update");
            toolTip.SetToolTip(btn_delete, "After Given data click delete");
            toolTip.SetToolTip(lbl_ip_address, "Your IP Address");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void orderlist_tbl_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = orderlist_tbl.Rows[e.RowIndex];
                txt_ptid.Text = row.Cells["pt_id"].Value?.ToString();
                txt_ptname.Text = row.Cells["pt_name"].Value?.ToString();
                cmb_catname.Text = row.Cells["cat_name"].Value?.ToString();
                txt_quant.Text = row.Cells["pt_quantity"].Value?.ToString();
                txt_price.Text = row.Cells["pt_price"].Value?.ToString();

                // Store OrderID for update
                selectedOrderID = Convert.ToInt32(row.Cells["pt_id"].Value);
                ToggleControls(true);
                btn_insert_disable(true);
            }
        }

        private void lbl_overview_click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void stocks_click(object sender, EventArgs e)
        {
            options_panel.Visible = true;
        }

        private void billing_click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void form_click_Event(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }

        private void lbl_tablets_click(object sender, EventArgs e)
        {
            Tablets_Page tablets = new Tablets_Page();
            tablets.Show();
            this.Hide();
        }

        private void lbl_syrup_click(object sender, EventArgs e)
        {
            Syrup_Page syrup = new Syrup_Page();
            syrup.Show();
            this.Hide();
        }

        private void lbl_surgical_click(object sender, EventArgs e)
        {
            Surgical_Items_Page surgical_Items_Page = new Surgical_Items_Page();
            surgical_Items_Page.Show();
            this.Hide();
        }    

        private void side_panelclick(object sender, EventArgs e)
        {
            options_panel.Visible = false;
        }
    }
}
