namespace Pharmacy_Managment_Application.Forms
{
    partial class FormOrder_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder_Request));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_ptname = new System.Windows.Forms.TextBox();
            this.cmb_catname = new System.Windows.Forms.ComboBox();
            this.categoryname = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.Label();
            this.lbl_ptname = new System.Windows.Forms.Label();
            this.btn_cus_order = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox_prescrip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_prescrip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order Here";
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_quant.Location = new System.Drawing.Point(294, 255);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(192, 30);
            this.txt_quant.TabIndex = 34;
            // 
            // txt_ptname
            // 
            this.txt_ptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ptname.Location = new System.Drawing.Point(294, 120);
            this.txt_ptname.Name = "txt_ptname";
            this.txt_ptname.Size = new System.Drawing.Size(192, 30);
            this.txt_ptname.TabIndex = 36;
            // 
            // cmb_catname
            // 
            this.cmb_catname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_catname.FormattingEnabled = true;
            this.cmb_catname.Location = new System.Drawing.Point(294, 187);
            this.cmb_catname.Name = "cmb_catname";
            this.cmb_catname.Size = new System.Drawing.Size(192, 33);
            this.cmb_catname.TabIndex = 33;
            // 
            // categoryname
            // 
            this.categoryname.AutoSize = true;
            this.categoryname.BackColor = System.Drawing.Color.Thistle;
            this.categoryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.categoryname.ForeColor = System.Drawing.Color.Black;
            this.categoryname.Location = new System.Drawing.Point(119, 195);
            this.categoryname.Name = "categoryname";
            this.categoryname.Size = new System.Drawing.Size(162, 25);
            this.categoryname.TabIndex = 29;
            this.categoryname.Text = "Category Name";
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.BackColor = System.Drawing.Color.Thistle;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.qty.ForeColor = System.Drawing.Color.Black;
            this.qty.Location = new System.Drawing.Point(188, 260);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(93, 25);
            this.qty.TabIndex = 31;
            this.qty.Text = "Quantity";
            // 
            // lbl_ptname
            // 
            this.lbl_ptname.AutoSize = true;
            this.lbl_ptname.BackColor = System.Drawing.Color.Thistle;
            this.lbl_ptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptname.ForeColor = System.Drawing.Color.Black;
            this.lbl_ptname.Location = new System.Drawing.Point(133, 123);
            this.lbl_ptname.Name = "lbl_ptname";
            this.lbl_ptname.Size = new System.Drawing.Size(148, 25);
            this.lbl_ptname.TabIndex = 32;
            this.lbl_ptname.Text = "Product Name";
            // 
            // btn_cus_order
            // 
            this.btn_cus_order.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_cus_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus_order.Location = new System.Drawing.Point(294, 420);
            this.btn_cus_order.Name = "btn_cus_order";
            this.btn_cus_order.Size = new System.Drawing.Size(192, 45);
            this.btn_cus_order.TabIndex = 39;
            this.btn_cus_order.Text = "Place Your Order";
            this.btn_cus_order.UseVisualStyleBackColor = false;
            this.btn_cus_order.Click += new System.EventHandler(this.btn_cus_order_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Prescription";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(495, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 39;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 486);
            this.panel1.TabIndex = 41;
            // 
            // picbox_prescrip
            // 
            this.picbox_prescrip.Location = new System.Drawing.Point(294, 311);
            this.picbox_prescrip.Name = "picbox_prescrip";
            this.picbox_prescrip.Size = new System.Drawing.Size(192, 80);
            this.picbox_prescrip.TabIndex = 40;
            this.picbox_prescrip.TabStop = false;
            // 
            // FormOrder_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 486);
            this.Controls.Add(this.picbox_prescrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cus_order);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.txt_ptname);
            this.Controls.Add(this.cmb_catname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryname);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.lbl_ptname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder_Request";
            this.Text = "FormOrders_Request";
            this.Load += new System.EventHandler(this.FormOrder_Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_prescrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_ptname;
        private System.Windows.Forms.ComboBox cmb_catname;
        private System.Windows.Forms.Label categoryname;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.Label lbl_ptname;
        private System.Windows.Forms.Button btn_cus_order;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picbox_prescrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}