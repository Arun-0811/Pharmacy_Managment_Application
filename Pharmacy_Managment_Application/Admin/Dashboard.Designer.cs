namespace Pharmacy_Managment_Application
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.side_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_billing = new System.Windows.Forms.Label();
            this.side_feedback = new System.Windows.Forms.Label();
            this.side_orderlist = new System.Windows.Forms.Label();
            this.side_overview = new System.Windows.Forms.Label();
            this.side_stocks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ip_addres = new System.Windows.Forms.Label();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.category_tbl = new System.Windows.Forms.DataGridView();
            this.categoryNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryNameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.options_panel = new System.Windows.Forms.Panel();
            this.lbl_surgical = new System.Windows.Forms.Label();
            this.lbl_syrup = new System.Windows.Forms.Label();
            this.lbl_tablets = new System.Windows.Forms.Label();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            this.options_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_panel
            // 
            this.side_panel.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.bg;
            this.side_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.side_panel.Controls.Add(this.pictureBox1);
            this.side_panel.Controls.Add(this.side_billing);
            this.side_panel.Controls.Add(this.side_feedback);
            this.side_panel.Controls.Add(this.side_orderlist);
            this.side_panel.Controls.Add(this.side_overview);
            this.side_panel.Controls.Add(this.side_stocks);
            this.side_panel.Location = new System.Drawing.Point(1, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(202, 606);
            this.side_panel.TabIndex = 0;
            this.side_panel.Click += new System.EventHandler(this.side_panel_click);
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
            this.side_billing.Location = new System.Drawing.Point(11, 381);
            this.side_billing.Name = "side_billing";
            this.side_billing.Size = new System.Drawing.Size(100, 32);
            this.side_billing.TabIndex = 1;
            this.side_billing.Text = "Billing";
            this.side_billing.Click += new System.EventHandler(this.side_billing_Click);
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
            this.side_feedback.Click += new System.EventHandler(this.label5_Click);
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
            this.side_orderlist.Click += new System.EventHandler(this.side_orderlist_Click);
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
            // 
            // side_stocks
            // 
            this.side_stocks.AutoSize = true;
            this.side_stocks.BackColor = System.Drawing.Color.Transparent;
            this.side_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.side_stocks.ForeColor = System.Drawing.Color.White;
            this.side_stocks.Location = new System.Drawing.Point(11, 320);
            this.side_stocks.Name = "side_stocks";
            this.side_stocks.Size = new System.Drawing.Size(105, 32);
            this.side_stocks.TabIndex = 1;
            this.side_stocks.Text = "Stocks";
            this.side_stocks.Click += new System.EventHandler(this.side_stocks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(584, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // lbl_ip_addres
            // 
            this.lbl_ip_addres.AutoSize = true;
            this.lbl_ip_addres.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ip_addres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip_addres.ForeColor = System.Drawing.Color.White;
            this.lbl_ip_addres.Location = new System.Drawing.Point(263, 49);
            this.lbl_ip_addres.Name = "lbl_ip_addres";
            this.lbl_ip_addres.Size = new System.Drawing.Size(0, 29);
            this.lbl_ip_addres.TabIndex = 1;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.Color.White;
            this.lbl_datetime.Location = new System.Drawing.Point(918, 48);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(0, 29);
            this.lbl_datetime.TabIndex = 1;
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
            this.btn_exit.Location = new System.Drawing.Point(1232, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 32);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.exit_btn_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(232, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Category ";
            // 
            // category_tbl
            // 
            this.category_tbl.AllowUserToAddRows = false;
            this.category_tbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.category_tbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.category_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category_tbl.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.category_tbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_tbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.category_tbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.category_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.category_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_tbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_tbl.EnableHeadersVisualStyles = false;
            this.category_tbl.Location = new System.Drawing.Point(237, 138);
            this.category_tbl.Name = "category_tbl";
            this.category_tbl.ReadOnly = true;
            this.category_tbl.RowHeadersWidth = 51;
            this.category_tbl.RowTemplate.Height = 24;
            this.category_tbl.Size = new System.Drawing.Size(330, 169);
            this.category_tbl.TabIndex = 17;
            // 
            // categoryNameBindingSource
            // 
            this.categoryNameBindingSource.DataMember = "Category_Name";
            // 
            // categoryNameBindingSource1
            // 
            this.categoryNameBindingSource1.DataMember = "Category_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(611, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Requested Order List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ptidDataGridViewTextBoxColumn,
            this.ptnameDataGridViewTextBoxColumn,
            this.catnameDataGridViewTextBoxColumn,
            this.ptquantityDataGridViewTextBoxColumn,
            this.ptpriceDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;

            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(616, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 169);
            this.dataGridView1.TabIndex = 17;
            // 
            // ptidDataGridViewTextBoxColumn
            // 
            this.ptidDataGridViewTextBoxColumn.DataPropertyName = "pt_id";
            this.ptidDataGridViewTextBoxColumn.HeaderText = "pt_id";
            this.ptidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptidDataGridViewTextBoxColumn.Name = "ptidDataGridViewTextBoxColumn";
            this.ptidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptnameDataGridViewTextBoxColumn
            // 
            this.ptnameDataGridViewTextBoxColumn.DataPropertyName = "pt_name";
            this.ptnameDataGridViewTextBoxColumn.HeaderText = "pt_name";
            this.ptnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptnameDataGridViewTextBoxColumn.Name = "ptnameDataGridViewTextBoxColumn";
            this.ptnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // catnameDataGridViewTextBoxColumn
            // 
            this.catnameDataGridViewTextBoxColumn.DataPropertyName = "cat_name";
            this.catnameDataGridViewTextBoxColumn.HeaderText = "cat_name";
            this.catnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catnameDataGridViewTextBoxColumn.Name = "catnameDataGridViewTextBoxColumn";
            this.catnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.catnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptquantityDataGridViewTextBoxColumn
            // 
            this.ptquantityDataGridViewTextBoxColumn.DataPropertyName = "pt_quantity";
            this.ptquantityDataGridViewTextBoxColumn.HeaderText = "pt_quantity";
            this.ptquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptquantityDataGridViewTextBoxColumn.Name = "ptquantityDataGridViewTextBoxColumn";
            this.ptquantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptquantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptpriceDataGridViewTextBoxColumn
            // 
            this.ptpriceDataGridViewTextBoxColumn.DataPropertyName = "pt_price";
            this.ptpriceDataGridViewTextBoxColumn.HeaderText = "pt_price";
            this.ptpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptpriceDataGridViewTextBoxColumn.Name = "ptpriceDataGridViewTextBoxColumn";
            this.ptpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblorderlistBindingSource
            // 

            // 
            // pharmacy_DBDataSet
            // 

            // 
            // tbl_orderlistTableAdapter
            // 

            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(210, 15);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 22);
            this.lbl_welcome.TabIndex = 18;
            // 
            // options_panel
            // 
            this.options_panel.BackColor = System.Drawing.Color.Transparent;
            this.options_panel.Controls.Add(this.lbl_surgical);
            this.options_panel.Controls.Add(this.lbl_syrup);
            this.options_panel.Controls.Add(this.lbl_tablets);
            this.options_panel.Location = new System.Drawing.Point(209, 303);
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
            this.lbl_syrup.Click += new System.EventHandler(this.lbl_syrup_Click);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy_Managment_Application.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 607);
            this.ControlBox = false;
            this.Controls.Add(this.options_panel);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.category_tbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_ip_addres);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Click += new System.EventHandler(this.Dashboard_click);
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_tbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.options_panel.ResumeLayout(false);
            this.options_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Label side_billing;
        private System.Windows.Forms.Label side_feedback;
        private System.Windows.Forms.Label side_overview;
        private System.Windows.Forms.Label side_stocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label side_orderlist;
        private System.Windows.Forms.Label lbl_ip_addres;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView category_tbl;
        private System.Windows.Forms.BindingSource categoryNameBindingSource;
        private System.Windows.Forms.BindingSource categoryNameBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel options_panel;
        private System.Windows.Forms.Label lbl_surgical;
        private System.Windows.Forms.Label lbl_syrup;
        private System.Windows.Forms.Label lbl_tablets;
    }
}