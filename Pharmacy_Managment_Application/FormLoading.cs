using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Pharmacy_Managment_Application
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private int progressValue = 0; // Keep track of progress

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment progress and update the progress bar
            if (progressValue <= 100)
            {
                CircleProgressBar1.Value = progressValue;
                label1.Text = "Loading " + progressValue.ToString() + "%";
                progressValue += 2;
            }
            else
            {
                timer1.Stop(); // Stop the timer when progress is complete
                Login login = new Login();
                login.Show(); // Show the login form
                this.Hide(); // Hide the loading form
            }
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            // Configure the ProgressBar
            CircleProgressBar1.Minimum = 0;
            CircleProgressBar1.Maximum = 100;
            progressValue = 0; // Initialize progress

            timer1.Interval = 50; // Set timer interval (50 milliseconds)
            timer1.Start(); // Start the timer
        }
    }
}
