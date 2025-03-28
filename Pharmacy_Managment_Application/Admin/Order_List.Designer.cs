namespace Pharmacy_Managment_Application
{
    partial class Order_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_List));
            this.orderlist_tbl = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_ip_address = new System.Windows.Forms.Label();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.lbl_ptname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.side_stocks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_billing = new System.Windows.Forms.Label();
            this.side_feedback = new System.Windows.Forms.Label();
            this.side_orderlist = new System.Windows.Forms.Label();
            this.side_overview = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_catname = new System.Windows.Forms.ComboBox();
            this.txt_ptname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_ptid1 = new System.Windows.Forms.Label();
            this.txt_ptid = new System.Windows.Forms.TextBox();
            this.options_panel = new System.Windows.Forms.Panel();
            this.lbl_surgical = new System.Windows.Forms.Label();
            this.lbl_syrup = new System.Windows.Forms.Label();
            this.lbl_tablets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderlist_tbl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.options_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderlist_tbl
            // 
            this.orderlist_tbl.AllowUserToAddRows = false;
            this.orderlist_tbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.orderlist_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderlist_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderlist_tbl.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.orderlist_tbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderlist_tbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderlist_tbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderlist_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderlist_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderlist_tbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderlist_tbl.EnableHeadersVisualStyles = false;
            this.orderlist_tbl.Location = new System.Drawing.Point(237, 159);
            this.orderlist_tbl.Name = "orderlist_tbl";
            this.orderlist_tbl.ReadOnly = true;
            this.orderlist_tbl.RowHeadersWidth = 51;
            this.orderlist_tbl.RowTemplate.Height = 24;
            this.orderlist_tbl.Size = new System.Drawing.Size(627, 421);
            this.orderlist_tbl.TabIndex = 24;
            this.orderlist_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderlist_tbl_cellclick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(232, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "Requested Order Listed Below";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1232, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 32);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_ip_address
            // 
            this.lbl_ip_address.AutoSize = true;
            this.lbl_ip_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip_address.ForeColor = System.Drawing.Color.White;
            this.lbl_ip_address.Location = new System.Drawing.Point(263, 50);
            this.lbl_ip_address.Name = "lbl_ip_address";
            this.lbl_ip_address.Size = new System.Drawing.Size(0, 29);
            this.lbl_ip_address.TabIndex = 19;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.Color.White;
            this.lbl_datetime.Location = new System.Drawing.Point(918, 49);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(0, 29);
            this.lbl_datetime.TabIndex = 20;
            // 
            // lbl_ptname
            // 
            this.lbl_ptname.AutoSize = true;
            this.lbl_ptname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptname.ForeColor = System.Drawing.Color.White;
            this.lbl_ptname.Location = new System.Drawing.Point(884, 192);
            this.lbl_ptname.Name = "lbl_ptname";
            this.lbl_ptname.Size = new System.Drawing.Size(148, 25);
            this.lbl_ptname.TabIndex = 21;
            this.lbl_ptname.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.side_billing);
            this.panel1.Controls.Add(this.side_feedback);
            this.panel1.Controls.Add(this.side_orderlist);
            this.panel1.Controls.Add(this.side_overview);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 606);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.side_panelclick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.side_stocks);
            this.panel2.Location = new System.Drawing.Point(11, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 61);
            this.panel2.TabIndex = 30;
            // 
            // side_stocks
            // 
            this.side_stocks.AutoSize = true;
            this.side_stocks.BackColor = System.Drawing.Color.Transparent;
            this.side_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_stocks.ForeColor = System.Drawing.Color.White;
            this.side_stocks.Location = new System.Drawing.Point(4, 15);
            this.side_stocks.Name = "side_stocks";
            this.side_stocks.Size = new System.Drawing.Size(105, 32);
            this.side_stocks.TabIndex = 1;
            this.side_stocks.Text = "Stocks";
            this.side_stocks.Click += new System.EventHandler(this.stocks_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.toplogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // side_billing
            // 
            this.side_billing.AutoSize = true;
            this.side_billing.BackColor = System.Drawing.Color.Transparent;
            this.side_billing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_billing.ForeColor = System.Drawing.Color.White;
            this.side_billing.Location = new System.Drawing.Point(15, 382);
            this.side_billing.Name = "side_billing";
            this.side_billing.Size = new System.Drawing.Size(100, 32);
            this.side_billing.TabIndex = 1;
            this.side_billing.Text = "Billing";
            this.side_billing.Click += new System.EventHandler(this.billing_click);
            // 
            // side_feedback
            // 
            this.side_feedback.AutoSize = true;
            this.side_feedback.BackColor = System.Drawing.Color.Transparent;
            this.side_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_feedback.ForeColor = System.Drawing.Color.White;
            this.side_feedback.Location = new System.Drawing.Point(15, 443);
            this.side_feedback.Name = "side_feedback";
            this.side_feedback.Size = new System.Drawing.Size(150, 32);
            this.side_feedback.TabIndex = 1;
            this.side_feedback.Text = "FeedBack";
            // 
            // side_orderlist
            // 
            this.side_orderlist.AutoSize = true;
            this.side_orderlist.BackColor = System.Drawing.Color.Transparent;
            this.side_orderlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_orderlist.ForeColor = System.Drawing.Color.White;
            this.side_orderlist.Location = new System.Drawing.Point(11, 256);
            this.side_orderlist.Name = "side_orderlist";
            this.side_orderlist.Size = new System.Drawing.Size(148, 32);
            this.side_orderlist.TabIndex = 1;
            this.side_orderlist.Text = "Order List";
            // 
            // side_overview
            // 
            this.side_overview.AutoSize = true;
            this.side_overview.BackColor = System.Drawing.Color.Transparent;
            this.side_overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side_overview.ForeColor = System.Drawing.Color.White;
            this.side_overview.Location = new System.Drawing.Point(11, 199);
            this.side_overview.Name = "side_overview";
            this.side_overview.Size = new System.Drawing.Size(153, 32);
            this.side_overview.TabIndex = 1;
            this.side_overview.Text = "Over View";
            this.side_overview.Click += new System.EventHandler(this.lbl_overview_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(584, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 42);
            this.label8.TabIndex = 21;
            this.label8.Text = "Order List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(870, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Category Name";
            // 
            // cmb_catname
            // 
            this.cmb_catname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_catname.FormattingEnabled = true;
            this.cmb_catname.Location = new System.Drawing.Point(1045, 256);
            this.cmb_catname.Name = "cmb_catname";
            this.cmb_catname.Size = new System.Drawing.Size(192, 33);
            this.cmb_catname.TabIndex = 25;
            // 
            // txt_ptname
            // 
            this.txt_ptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ptname.Location = new System.Drawing.Point(1045, 189);
            this.txt_ptname.Name = "txt_ptname";
            this.txt_ptname.Size = new System.Drawing.Size(192, 30);
            this.txt_ptname.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(939, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Quantity";
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_quant.Location = new System.Drawing.Point(1045, 324);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(192, 30);
            this.txt_quant.TabIndex = 26;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_price.Location = new System.Drawing.Point(1045, 387);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(192, 30);
            this.txt_price.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(971, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Price";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insert.BackgroundImage")));
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(1163, 461);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(77, 71);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.oder_add_click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1059, 461);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 71);
            this.btn_update.TabIndex = 29;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.order_save_click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(929, 461);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 71);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.order_delete_click);
            // 
            // lbl_ptid1
            // 
            this.lbl_ptid1.AutoSize = true;
            this.lbl_ptid1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ptid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptid1.ForeColor = System.Drawing.Color.White;
            this.lbl_ptid1.Location = new System.Drawing.Point(918, 124);
            this.lbl_ptid1.Name = "lbl_ptid1";
            this.lbl_ptid1.Size = new System.Drawing.Size(110, 25);
            this.lbl_ptid1.TabIndex = 21;
            this.lbl_ptid1.Text = "Product Id";
            // 
            // txt_ptid
            // 
            this.txt_ptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ptid.Location = new System.Drawing.Point(1045, 119);
            this.txt_ptid.Name = "txt_ptid";
            this.txt_ptid.Size = new System.Drawing.Size(192, 30);
            this.txt_ptid.TabIndex = 26;
            // 
            // options_panel
            // 
            this.options_panel.BackColor = System.Drawing.Color.Transparent;
            this.options_panel.Controls.Add(this.lbl_surgical);
            this.options_panel.Controls.Add(this.lbl_syrup);
            this.options_panel.Controls.Add(this.lbl_tablets);
            this.options_panel.Location = new System.Drawing.Point(209, 306);
            this.options_panel.Name = "options_panel";
            this.options_panel.Size = new System.Drawing.Size(218, 196);
            this.options_panel.TabIndex = 30;
            // 
            // lbl_surgical
            // 
            this.lbl_surgical.AutoSize = true;
            this.lbl_surgical.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surgical.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_surgical.ForeColor = System.Drawing.Color.White;
            this.lbl_surgical.Location = new System.Drawing.Point(4, 138);
            this.lbl_surgical.Name = "lbl_surgical";
            this.lbl_surgical.Size = new System.Drawing.Size(207, 32);
            this.lbl_surgical.TabIndex = 1;
            this.lbl_surgical.Text = "Surgical Items";
            this.lbl_surgical.Click += new System.EventHandler(this.lbl_surgical_click);
            // 
            // lbl_syrup
            // 
            this.lbl_syrup.AutoSize = true;
            this.lbl_syrup.BackColor = System.Drawing.Color.Transparent;
            this.lbl_syrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_syrup.ForeColor = System.Drawing.Color.White;
            this.lbl_syrup.Location = new System.Drawing.Point(4, 77);
            this.lbl_syrup.Name = "lbl_syrup";
            this.lbl_syrup.Size = new System.Drawing.Size(174, 32);
            this.lbl_syrup.TabIndex = 1;
            this.lbl_syrup.Text = "Syrup Items";
            this.lbl_syrup.Click += new System.EventHandler(this.lbl_syrup_click);
            // 
            // lbl_tablets
            // 
            this.lbl_tablets.AutoSize = true;
            this.lbl_tablets.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tablets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_tablets.ForeColor = System.Drawing.Color.White;
            this.lbl_tablets.Location = new System.Drawing.Point(4, 15);
            this.lbl_tablets.Name = "lbl_tablets";
            this.lbl_tablets.Size = new System.Drawing.Size(196, 32);
            this.lbl_tablets.TabIndex = 1;
            this.lbl_tablets.Text = "Tablets Items";
            this.lbl_tablets.Click += new System.EventHandler(this.lbl_tablets_click);
            // 
            // Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 607);
            this.ControlBox = false;
            this.Controls.Add(this.options_panel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.txt_ptid);
            this.Controls.Add(this.txt_ptname);
            this.Controls.Add(this.cmb_catname);
            this.Controls.Add(this.orderlist_tbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_ip_address);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_ptid1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_ptname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Order_List_Load);
            this.Click += new System.EventHandler(this.form_click_Event);
            ((System.ComponentModel.ISupportInitialize)(this.orderlist_tbl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.options_panel.ResumeLayout(false);
            this.options_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderlist_tbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_ip_address;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label lbl_ptname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label side_billing;
        private System.Windows.Forms.Label side_feedback;
        private System.Windows.Forms.Label side_orderlist;
        private System.Windows.Forms.Label side_overview;
        private System.Windows.Forms.Label side_stocks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_catname;
        private System.Windows.Forms.TextBox txt_ptname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_ptid1;
        private System.Windows.Forms.TextBox txt_ptid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel options_panel;
        private System.Windows.Forms.Label lbl_surgical;
        private System.Windows.Forms.Label lbl_syrup;
        private System.Windows.Forms.Label lbl_tablets;
    }
}