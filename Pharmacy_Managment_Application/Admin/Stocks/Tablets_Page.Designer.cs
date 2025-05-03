namespace Pharmacy_Managment_Application
{
    partial class Tablets_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablets_Page));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.options_panel = new System.Windows.Forms.Panel();
            this.lbl_surgical = new System.Windows.Forms.Label();
            this.lbl_syrup = new System.Windows.Forms.Label();
            this.lbl_tablets = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_tbprice = new System.Windows.Forms.Label();
            this.txt_tbquant = new System.Windows.Forms.TextBox();
            this.txt_tbid = new System.Windows.Forms.TextBox();
            this.txt_tbname = new System.Windows.Forms.TextBox();
            this.cmb_catname = new System.Windows.Forms.ComboBox();
            this.tablets_tbl = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_ip_address = new System.Windows.Forms.Label();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cat_name = new System.Windows.Forms.Label();
            this.lbl_tbid = new System.Windows.Forms.Label();
            this.lbl_tbquantity = new System.Windows.Forms.Label();
            this.lbl_tbname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.side_stocks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_feedback = new System.Windows.Forms.Label();
            this.side_orderlist = new System.Windows.Forms.Label();
            this.side_overview = new System.Windows.Forms.Label();
            this.btn_picture = new System.Windows.Forms.Button();
            this.picture_upload = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.lbl_expiry = new System.Windows.Forms.Label();
            this.txt_expirydate = new System.Windows.Forms.DateTimePicker();
            this.lbl_mfgdate = new System.Windows.Forms.Label();
            this.mfg_dateTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_billingDetails = new System.Windows.Forms.Label();
            this.options_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablets_tbl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_upload)).BeginInit();
            this.SuspendLayout();
            // 
            // options_panel
            // 
            this.options_panel.BackColor = System.Drawing.Color.Transparent;
            this.options_panel.Controls.Add(this.lbl_surgical);
            this.options_panel.Controls.Add(this.lbl_syrup);
            this.options_panel.Controls.Add(this.lbl_tablets);
            this.options_panel.Location = new System.Drawing.Point(208, 328);
            this.options_panel.Name = "options_panel";
            this.options_panel.Size = new System.Drawing.Size(218, 196);
            this.options_panel.TabIndex = 51;
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
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1110, 402);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 53);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.order_delete_click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1111, 284);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(67, 53);
            this.btn_update.TabIndex = 49;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.order_save_click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insert.BackgroundImage")));
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(1111, 152);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(66, 53);
            this.btn_insert.TabIndex = 48;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.oder_add_click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_price.Location = new System.Drawing.Point(659, 340);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(192, 30);
            this.txt_price.TabIndex = 47;
            // 
            // lbl_tbprice
            // 
            this.lbl_tbprice.AutoSize = true;
            this.lbl_tbprice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_tbprice.ForeColor = System.Drawing.Color.White;
            this.lbl_tbprice.Location = new System.Drawing.Point(654, 312);
            this.lbl_tbprice.Name = "lbl_tbprice";
            this.lbl_tbprice.Size = new System.Drawing.Size(149, 25);
            this.lbl_tbprice.TabIndex = 46;
            this.lbl_tbprice.Text = "Price per Strip";
            // 
            // txt_tbquant
            // 
            this.txt_tbquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_tbquant.Location = new System.Drawing.Point(875, 262);
            this.txt_tbquant.Name = "txt_tbquant";
            this.txt_tbquant.Size = new System.Drawing.Size(192, 30);
            this.txt_tbquant.TabIndex = 45;
            // 
            // txt_tbid
            // 
            this.txt_tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tbid.Location = new System.Drawing.Point(659, 165);
            this.txt_tbid.Name = "txt_tbid";
            this.txt_tbid.Size = new System.Drawing.Size(192, 30);
            this.txt_tbid.TabIndex = 44;
            // 
            // txt_tbname
            // 
            this.txt_tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tbname.Location = new System.Drawing.Point(658, 255);
            this.txt_tbname.Name = "txt_tbname";
            this.txt_tbname.Size = new System.Drawing.Size(192, 30);
            this.txt_tbname.TabIndex = 43;
            // 
            // cmb_catname
            // 
            this.cmb_catname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_catname.FormattingEnabled = true;
            this.cmb_catname.Location = new System.Drawing.Point(873, 165);
            this.cmb_catname.Name = "cmb_catname";
            this.cmb_catname.Size = new System.Drawing.Size(192, 33);
            this.cmb_catname.TabIndex = 42;
            // 
            // tablets_tbl
            // 
            this.tablets_tbl.AllowUserToAddRows = false;
            this.tablets_tbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tablets_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablets_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablets_tbl.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.tablets_tbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablets_tbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablets_tbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablets_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablets_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablets_tbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablets_tbl.EnableHeadersVisualStyles = false;
            this.tablets_tbl.Location = new System.Drawing.Point(230, 165);
            this.tablets_tbl.Name = "tablets_tbl";
            this.tablets_tbl.ReadOnly = true;
            this.tablets_tbl.RowHeadersWidth = 51;
            this.tablets_tbl.RowTemplate.Height = 24;
            this.tablets_tbl.Size = new System.Drawing.Size(382, 339);
            this.tablets_tbl.TabIndex = 41;
            this.tablets_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablet_list_tbl_cellclick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 27);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tablet Listed Below";
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
            this.btn_exit.Location = new System.Drawing.Point(1190, -3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 32);
            this.btn_exit.TabIndex = 39;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_ip_address
            // 
            this.lbl_ip_address.AutoSize = true;
            this.lbl_ip_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip_address.ForeColor = System.Drawing.Color.White;
            this.lbl_ip_address.Location = new System.Drawing.Point(273, 56);
            this.lbl_ip_address.Name = "lbl_ip_address";
            this.lbl_ip_address.Size = new System.Drawing.Size(0, 29);
            this.lbl_ip_address.TabIndex = 32;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.Color.White;
            this.lbl_datetime.Location = new System.Drawing.Point(898, 52);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(0, 29);
            this.lbl_datetime.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(594, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 42);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tablet List";
            // 
            // cat_name
            // 
            this.cat_name.AutoSize = true;
            this.cat_name.BackColor = System.Drawing.Color.Transparent;
            this.cat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cat_name.ForeColor = System.Drawing.Color.White;
            this.cat_name.Location = new System.Drawing.Point(868, 137);
            this.cat_name.Name = "cat_name";
            this.cat_name.Size = new System.Drawing.Size(162, 25);
            this.cat_name.TabIndex = 36;
            this.cat_name.Text = "Category Name";
            // 
            // lbl_tbid
            // 
            this.lbl_tbid.AutoSize = true;
            this.lbl_tbid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tbid.ForeColor = System.Drawing.Color.White;
            this.lbl_tbid.Location = new System.Drawing.Point(654, 137);
            this.lbl_tbid.Name = "lbl_tbid";
            this.lbl_tbid.Size = new System.Drawing.Size(97, 25);
            this.lbl_tbid.TabIndex = 35;
            this.lbl_tbid.Text = "Tablet Id";
            // 
            // lbl_tbquantity
            // 
            this.lbl_tbquantity.AutoSize = true;
            this.lbl_tbquantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tbquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_tbquantity.ForeColor = System.Drawing.Color.White;
            this.lbl_tbquantity.Location = new System.Drawing.Point(870, 234);
            this.lbl_tbquantity.Name = "lbl_tbquantity";
            this.lbl_tbquantity.Size = new System.Drawing.Size(160, 25);
            this.lbl_tbquantity.TabIndex = 34;
            this.lbl_tbquantity.Text = "Quantity (Strip)";
            // 
            // lbl_tbname
            // 
            this.lbl_tbname.AutoSize = true;
            this.lbl_tbname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tbname.ForeColor = System.Drawing.Color.White;
            this.lbl_tbname.Location = new System.Drawing.Point(654, 225);
            this.lbl_tbname.Name = "lbl_tbname";
            this.lbl_tbname.Size = new System.Drawing.Size(135, 25);
            this.lbl_tbname.TabIndex = 38;
            this.lbl_tbname.Text = "Tablet Name";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_billingDetails);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.side_feedback);
            this.panel1.Controls.Add(this.side_orderlist);
            this.panel1.Controls.Add(this.side_overview);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 605);
            this.panel1.TabIndex = 31;
            this.panel1.Click += new System.EventHandler(this.side_panelclick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.side_stocks);
            this.panel2.Location = new System.Drawing.Point(9, 343);
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
            this.side_stocks.Click += new System.EventHandler(this.side_stocks_Click);
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
            // side_feedback
            // 
            this.side_feedback.AutoSize = true;
            this.side_feedback.BackColor = System.Drawing.Color.Transparent;
            this.side_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_feedback.ForeColor = System.Drawing.Color.White;
            this.side_feedback.Location = new System.Drawing.Point(12, 495);
            this.side_feedback.Name = "side_feedback";
            this.side_feedback.Size = new System.Drawing.Size(150, 32);
            this.side_feedback.TabIndex = 1;
            this.side_feedback.Text = "FeedBack";
            this.side_feedback.Click += new System.EventHandler(this.side_feedback_Click);
            // 
            // side_orderlist
            // 
            this.side_orderlist.AutoSize = true;
            this.side_orderlist.BackColor = System.Drawing.Color.Transparent;
            this.side_orderlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_orderlist.ForeColor = System.Drawing.Color.White;
            this.side_orderlist.Location = new System.Drawing.Point(9, 294);
            this.side_orderlist.Name = "side_orderlist";
            this.side_orderlist.Size = new System.Drawing.Size(148, 32);
            this.side_orderlist.TabIndex = 1;
            this.side_orderlist.Text = "Order List";
            this.side_orderlist.Click += new System.EventHandler(this.side_orderlist_Click);
            // 
            // side_overview
            // 
            this.side_overview.AutoSize = true;
            this.side_overview.BackColor = System.Drawing.Color.Transparent;
            this.side_overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side_overview.ForeColor = System.Drawing.Color.White;
            this.side_overview.Location = new System.Drawing.Point(9, 237);
            this.side_overview.Name = "side_overview";
            this.side_overview.Size = new System.Drawing.Size(153, 32);
            this.side_overview.TabIndex = 1;
            this.side_overview.Text = "Over View";
            this.side_overview.Click += new System.EventHandler(this.side_overview_Click);
            // 
            // btn_picture
            // 
            this.btn_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_picture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_picture.ForeColor = System.Drawing.Color.White;
            this.btn_picture.Location = new System.Drawing.Point(658, 482);
            this.btn_picture.Name = "btn_picture";
            this.btn_picture.Size = new System.Drawing.Size(181, 42);
            this.btn_picture.TabIndex = 52;
            this.btn_picture.Text = "Picture Upload";
            this.btn_picture.UseVisualStyleBackColor = false;
            this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
            // 
            // picture_upload
            // 
            this.picture_upload.BackColor = System.Drawing.Color.Transparent;
            this.picture_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_upload.Location = new System.Drawing.Point(882, 482);
            this.picture_upload.Name = "picture_upload";
            this.picture_upload.Size = new System.Drawing.Size(178, 108);
            this.picture_upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_upload.TabIndex = 54;
            this.picture_upload.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(764, 530);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 33);
            this.btn_clear.TabIndex = 55;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.AutoSize = true;
            this.lbl_totalprice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_totalprice.ForeColor = System.Drawing.Color.White;
            this.lbl_totalprice.Location = new System.Drawing.Point(871, 397);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.Size = new System.Drawing.Size(116, 25);
            this.lbl_totalprice.TabIndex = 46;
            this.lbl_totalprice.Text = "Total Price";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_totalprice.Location = new System.Drawing.Point(875, 425);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(192, 30);
            this.txt_totalprice.TabIndex = 47;
            // 
            // lbl_expiry
            // 
            this.lbl_expiry.AutoSize = true;
            this.lbl_expiry.BackColor = System.Drawing.Color.Transparent;
            this.lbl_expiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_expiry.ForeColor = System.Drawing.Color.White;
            this.lbl_expiry.Location = new System.Drawing.Point(653, 394);
            this.lbl_expiry.Name = "lbl_expiry";
            this.lbl_expiry.Size = new System.Drawing.Size(123, 25);
            this.lbl_expiry.TabIndex = 46;
            this.lbl_expiry.Text = "Expiry Date";
            // 
            // txt_expirydate
            // 
            this.txt_expirydate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expirydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expirydate.Location = new System.Drawing.Point(658, 427);
            this.txt_expirydate.Name = "txt_expirydate";
            this.txt_expirydate.Size = new System.Drawing.Size(200, 28);
            this.txt_expirydate.TabIndex = 56;
            // 
            // lbl_mfgdate
            // 
            this.lbl_mfgdate.AutoSize = true;
            this.lbl_mfgdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mfgdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_mfgdate.ForeColor = System.Drawing.Color.White;
            this.lbl_mfgdate.Location = new System.Drawing.Point(871, 312);
            this.lbl_mfgdate.Name = "lbl_mfgdate";
            this.lbl_mfgdate.Size = new System.Drawing.Size(105, 25);
            this.lbl_mfgdate.TabIndex = 46;
            this.lbl_mfgdate.Text = "Mfg. Date";
            // 
            // mfg_dateTime
            // 
            this.mfg_dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfg_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfg_dateTime.Location = new System.Drawing.Point(875, 342);
            this.mfg_dateTime.Name = "mfg_dateTime";
            this.mfg_dateTime.Size = new System.Drawing.Size(200, 28);
            this.mfg_dateTime.TabIndex = 56;
            // 
            // lbl_billingDetails
            // 
            this.lbl_billingDetails.AutoSize = true;
            this.lbl_billingDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbl_billingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billingDetails.ForeColor = System.Drawing.Color.White;
            this.lbl_billingDetails.Location = new System.Drawing.Point(3, 428);
            this.lbl_billingDetails.Name = "lbl_billingDetails";
            this.lbl_billingDetails.Size = new System.Drawing.Size(175, 29);
            this.lbl_billingDetails.TabIndex = 57;
            this.lbl_billingDetails.Text = "Billing Details";
            this.lbl_billingDetails.Click += new System.EventHandler(this.lbl_billingDetails_Click);
            // 
            // Tablets_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 602);
            this.ControlBox = false;
            this.Controls.Add(this.mfg_dateTime);
            this.Controls.Add(this.txt_expirydate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.picture_upload);
            this.Controls.Add(this.btn_picture);
            this.Controls.Add(this.options_panel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_mfgdate);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.lbl_totalprice);
            this.Controls.Add(this.lbl_expiry);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_tbprice);
            this.Controls.Add(this.txt_tbquant);
            this.Controls.Add(this.txt_tbid);
            this.Controls.Add(this.txt_tbname);
            this.Controls.Add(this.cmb_catname);
            this.Controls.Add(this.tablets_tbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_ip_address);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cat_name);
            this.Controls.Add(this.lbl_tbid);
            this.Controls.Add(this.lbl_tbquantity);
            this.Controls.Add(this.lbl_tbname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tablets_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tablets_Page_Load);
            this.Click += new System.EventHandler(this.Tablets_Page_click);
            this.options_panel.ResumeLayout(false);
            this.options_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablets_tbl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_upload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel options_panel;
        private System.Windows.Forms.Label lbl_surgical;
        private System.Windows.Forms.Label lbl_syrup;
        private System.Windows.Forms.Label lbl_tablets;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_tbprice;
        private System.Windows.Forms.TextBox txt_tbquant;
        private System.Windows.Forms.TextBox txt_tbid;
        private System.Windows.Forms.TextBox txt_tbname;
        private System.Windows.Forms.ComboBox cmb_catname;
        private System.Windows.Forms.DataGridView tablets_tbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_ip_address;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cat_name;
        private System.Windows.Forms.Label lbl_tbid;
        private System.Windows.Forms.Label lbl_tbquantity;
        private System.Windows.Forms.Label lbl_tbname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label side_stocks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label side_feedback;
        private System.Windows.Forms.Label side_orderlist;
        private System.Windows.Forms.Label side_overview;
        private System.Windows.Forms.Button btn_picture;
        private System.Windows.Forms.PictureBox picture_upload;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Label lbl_expiry;
        private System.Windows.Forms.DateTimePicker txt_expirydate;
        private System.Windows.Forms.Label lbl_mfgdate;
        private System.Windows.Forms.DateTimePicker mfg_dateTime;
        private System.Windows.Forms.Label lbl_billingDetails;
    }
}