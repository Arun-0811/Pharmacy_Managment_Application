namespace Pharmacy_Managment_Application
{
    partial class Register_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Page));
            this.lnk_lbl_Account_have = new System.Windows.Forms.LinkLabel();
            this.btn_reg = new System.Windows.Forms.Button();
            this.txt_email_id = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_email_id = new System.Windows.Forms.Label();
            this.lbl_place = new System.Windows.Forms.Label();
            this.lbl_phaoneno = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnk_lbl_Account_have
            // 
            this.lnk_lbl_Account_have.AutoSize = true;
            this.lnk_lbl_Account_have.BackColor = System.Drawing.Color.Transparent;
            this.lnk_lbl_Account_have.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lbl_Account_have.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_lbl_Account_have.LinkColor = System.Drawing.Color.White;
            this.lnk_lbl_Account_have.LinkVisited = true;
            this.lnk_lbl_Account_have.Location = new System.Drawing.Point(27, 440);
            this.lnk_lbl_Account_have.Name = "lnk_lbl_Account_have";
            this.lnk_lbl_Account_have.Size = new System.Drawing.Size(252, 25);
            this.lnk_lbl_Account_have.TabIndex = 24;
            this.lnk_lbl_Account_have.TabStop = true;
            this.lnk_lbl_Account_have.Text = "Already have an Account..?";
            this.lnk_lbl_Account_have.VisitedLinkColor = System.Drawing.Color.Lime;
            this.lnk_lbl_Account_have.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lbl_Account_have_LinkClicked);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.Transparent;
            this.btn_reg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reg.BackgroundImage")));
            this.btn_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reg.Location = new System.Drawing.Point(356, 431);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(180, 62);
            this.btn_reg.TabIndex = 23;
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // txt_email_id
            // 
            this.txt_email_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_email_id.Location = new System.Drawing.Point(318, 260);
            this.txt_email_id.Name = "txt_email_id";
            this.txt_email_id.Size = new System.Drawing.Size(259, 30);
            this.txt_email_id.TabIndex = 21;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_pwd.Location = new System.Drawing.Point(318, 321);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(259, 30);
            this.txt_pwd.TabIndex = 22;
            // 
            // txt_place
            // 
            this.txt_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_place.Location = new System.Drawing.Point(318, 195);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(259, 30);
            this.txt_place.TabIndex = 19;
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_phoneno.Location = new System.Drawing.Point(318, 138);
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(259, 30);
            this.txt_phoneno.TabIndex = 18;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_name.Location = new System.Drawing.Point(318, 87);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(259, 30);
            this.txt_name.TabIndex = 17;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pwd.Location = new System.Drawing.Point(173, 324);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(106, 25);
            this.lbl_pwd.TabIndex = 10;
            this.lbl_pwd.Text = "Password";
            // 
            // lbl_email_id
            // 
            this.lbl_email_id.AutoSize = true;
            this.lbl_email_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_email_id.Location = new System.Drawing.Point(203, 265);
            this.lbl_email_id.Name = "lbl_email_id";
            this.lbl_email_id.Size = new System.Drawing.Size(65, 25);
            this.lbl_email_id.TabIndex = 11;
            this.lbl_email_id.Text = "Email";
            // 
            // lbl_place
            // 
            this.lbl_place.AutoSize = true;
            this.lbl_place.BackColor = System.Drawing.Color.Transparent;
            this.lbl_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_place.Location = new System.Drawing.Point(203, 200);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.Size = new System.Drawing.Size(66, 25);
            this.lbl_place.TabIndex = 13;
            this.lbl_place.Text = "Place";
            // 
            // lbl_phaoneno
            // 
            this.lbl_phaoneno.AutoSize = true;
            this.lbl_phaoneno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phaoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_phaoneno.Location = new System.Drawing.Point(162, 143);
            this.lbl_phaoneno.Name = "lbl_phaoneno";
            this.lbl_phaoneno.Size = new System.Drawing.Size(107, 25);
            this.lbl_phaoneno.TabIndex = 14;
            this.lbl_phaoneno.Text = "Phone No";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(200, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 25);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "Name";
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Register.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.Location = new System.Drawing.Point(255, 9);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(248, 44);
            this.lbl_Register.TabIndex = 16;
            this.lbl_Register.Text = "Register Page";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(783, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 32);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.close_click);
            // 
            // Register_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 522);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lnk_lbl_Account_have);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txt_email_id);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_place);
            this.Controls.Add(this.txt_phoneno);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_email_id);
            this.Controls.Add(this.lbl_place);
            this.Controls.Add(this.lbl_phaoneno);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_lbl_Account_have;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox txt_email_id;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_email_id;
        private System.Windows.Forms.Label lbl_place;
        private System.Windows.Forms.Label lbl_phaoneno;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Button button2;
    }
}