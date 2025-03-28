using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application.Customer
{
    public partial class Print_Invoice : Form
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;


        string date;
        private int id;

        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private Bitmap memoryImage;
        public Print_Invoice( int id)
        {
            InitializeComponent();
            this.id = id;
            Load_Cus_Db();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }     

        

        private void Load_Cus_Db()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "select * from cus_purchase_tbl where cus_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dataTable.Load(sdr);
            con.Close();


            if (dataTable.Rows.Count > 0)
            {
                cus_id.Text = dataTable.Rows[0][0].ToString();
                cus_name.Text = dataTable.Rows[0][1].ToString();
                cat_name.Text = dataTable.Rows[0][2].ToString();
                item.Text = dataTable.Rows[0][3].ToString();
                qty.Text = dataTable.Rows[0][4].ToString();
                mfg_date.Text = dataTable.Rows[0][5].ToString();
                expiry.Text = dataTable.Rows[0][6].ToString();
                cost.Text = dataTable.Rows[0][7].ToString();
                ttl_cost.Text = dataTable.Rows[0][8].ToString();                           
                
            }
            else
            {
                MessageBox.Show("No table found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void print_invoice_Load(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_date1.Text = date;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            // Capture the form content before printing
            CaptureForm();

            // Show print dialog before printing
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void CaptureForm()
        {
            // Create a bitmap with the same size as the form
            memoryImage = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(memoryImage, new Rectangle(0, 0, this.Width, this.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the captured image of the form
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

            CaptureForm();  // Capture the form content

            // Show the print preview dialog
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void hover_document(object sender, EventArgs e)
        {
            lbl_preview.ForeColor = Color.ForestGreen;
        }

        
    }
}
