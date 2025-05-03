using Pharmacy_Managment_Application.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class Purchase_History : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        private int id = 0;
        public Purchase_History()
        {
            InitializeComponent();
        }

        private void Purchase_History_Load(object sender, EventArgs e)
        {
            cus_tbl();
        }

        private void cus_tbl()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from cus_purchase_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandTimeout = 120; // timeout in seconds (example: 2 minutes)

            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            DataGridView1.DataSource = dataTable;
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.Hide();
                new Print_Invoice(id).Show();
            }
            else
            {
                MessageBox.Show("Please select a student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0) //(e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells[0].Value);
                //id = Convert.ToInt32(table_student.Rows[e.RowIndex].Cells[0].Value);

            }
        }
    }
}
