namespace Pharmacy_Managment_Application.Customer.Forms
{
    partial class Cus_Feedback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_Feedback));
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_feedback = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_syrupname = new System.Windows.Forms.Label();
            this.btn_sendfeedback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_price.Location = new System.Drawing.Point(63, 362);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(107, 25);
            this.lbl_price.TabIndex = 82;
            this.lbl_price.Text = "Feedback";
            // 
            // txt_feedback
            // 
            this.txt_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedback.Location = new System.Drawing.Point(200, 338);
            this.txt_feedback.Multiline = true;
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.Size = new System.Drawing.Size(563, 173);
            this.txt_feedback.TabIndex = 77;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(200, 232);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(563, 45);
            this.txt_name.TabIndex = 78;
            // 
            // lbl_syrupname
            // 
            this.lbl_syrupname.AutoSize = true;
            this.lbl_syrupname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_syrupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_syrupname.ForeColor = System.Drawing.Color.Black;
            this.lbl_syrupname.Location = new System.Drawing.Point(102, 242);
            this.lbl_syrupname.Name = "lbl_syrupname";
            this.lbl_syrupname.Size = new System.Drawing.Size(68, 25);
            this.lbl_syrupname.TabIndex = 73;
            this.lbl_syrupname.Text = "Name";
            // 
            // btn_sendfeedback
            // 
            this.btn_sendfeedback.BackColor = System.Drawing.Color.Transparent;
            this.btn_sendfeedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sendfeedback.BackgroundImage")));
            this.btn_sendfeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sendfeedback.FlatAppearance.BorderSize = 0;
            this.btn_sendfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sendfeedback.Location = new System.Drawing.Point(403, 566);
            this.btn_sendfeedback.Name = "btn_sendfeedback";
            this.btn_sendfeedback.Size = new System.Drawing.Size(147, 67);
            this.btn_sendfeedback.TabIndex = 83;
            this.btn_sendfeedback.UseVisualStyleBackColor = false;
            this.btn_sendfeedback.Click += new System.EventHandler(this.btn_sendfeedback_Click);
            this.btn_sendfeedback.MouseHover += new System.EventHandler(this.feedback_mousehover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(294, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 73;
            this.label1.Text = "Customer Feedback";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.Location = new System.Drawing.Point(21, 91);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(18, 20);
            this.lbl_ip.TabIndex = 48;
            this.lbl_ip.Text = "?";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(21, 25);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(18, 20);
            this.lbl_welcome.TabIndex = 47;
            this.lbl_welcome.Text = "?";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(629, 25);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(18, 20);
            this.lbl_date.TabIndex = 46;
            this.lbl_date.Text = "?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lbl_syrupname);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.btn_sendfeedback);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Controls.Add(this.txt_feedback);
            this.panel1.Controls.Add(this.lbl_ip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 710);
            this.panel1.TabIndex = 84;
            // 
            // Cus_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(917, 710);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cus_Feedback";
            this.Text = "Cus_Feedback";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sendfeedback;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_feedback;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_syrupname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel1;
    }
}