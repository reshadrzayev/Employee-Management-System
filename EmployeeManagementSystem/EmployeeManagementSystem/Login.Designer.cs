
namespace EmployeeManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.checkBox_rem = new System.Windows.Forms.CheckBox();
            this.checkBox_pass = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_forgotpass = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.icn_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_loginuser = new System.Windows.Forms.LinkLabel();
            this.cmbox_dil = new System.Windows.Forms.ComboBox();
            this.btn_set = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_rem
            // 
            this.checkBox_rem.AutoSize = true;
            this.checkBox_rem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_rem.Location = new System.Drawing.Point(195, 275);
            this.checkBox_rem.Name = "checkBox_rem";
            this.checkBox_rem.Size = new System.Drawing.Size(116, 25);
            this.checkBox_rem.TabIndex = 27;
            this.checkBox_rem.Text = "Məni Xatırla";
            this.checkBox_rem.UseVisualStyleBackColor = true;
            this.checkBox_rem.CheckedChanged += new System.EventHandler(this.checkBox_rem_CheckedChanged);
            // 
            // checkBox_pass
            // 
            this.checkBox_pass.AutoSize = true;
            this.checkBox_pass.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_pass.Location = new System.Drawing.Point(195, 244);
            this.checkBox_pass.Name = "checkBox_pass";
            this.checkBox_pass.Size = new System.Drawing.Size(124, 25);
            this.checkBox_pass.TabIndex = 26;
            this.checkBox_pass.Text = "Şifrəni göstər";
            this.checkBox_pass.UseVisualStyleBackColor = true;
            this.checkBox_pass.CheckedChanged += new System.EventHandler(this.checkBox_pass_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(195, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 1);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(195, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 1);
            this.panel1.TabIndex = 24;
            // 
            // lbl_forgotpass
            // 
            this.lbl_forgotpass.AutoSize = true;
            this.lbl_forgotpass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_forgotpass.LinkColor = System.Drawing.Color.Black;
            this.lbl_forgotpass.Location = new System.Drawing.Point(140, 311);
            this.lbl_forgotpass.Name = "lbl_forgotpass";
            this.lbl_forgotpass.Size = new System.Drawing.Size(171, 24);
            this.lbl_forgotpass.TabIndex = 23;
            this.lbl_forgotpass.TabStop = true;
            this.lbl_forgotpass.Text = "Şifrəni Unutmuşam";
            this.lbl_forgotpass.VisitedLinkColor = System.Drawing.Color.Black;
            this.lbl_forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_forgotpass_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(337, 275);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(162, 60);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "Daxil Ol";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(195, 85);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(277, 39);
            this.txt_email.TabIndex = 18;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pass.Location = new System.Drawing.Point(62, 196);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(68, 35);
            this.lbl_pass.TabIndex = 20;
            this.lbl_pass.Text = "Şifrə";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(56, 89);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 35);
            this.lbl_email.TabIndex = 21;
            this.lbl_email.Text = "Email";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(195, 192);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(277, 39);
            this.txt_password.TabIndex = 19;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // icn_exit
            // 
            this.icn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_exit.Image = ((System.Drawing.Image)(resources.GetObject("icn_exit.Image")));
            this.icn_exit.Location = new System.Drawing.Point(698, 0);
            this.icn_exit.Name = "icn_exit";
            this.icn_exit.Size = new System.Drawing.Size(57, 53);
            this.icn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_exit.TabIndex = 28;
            this.icn_exit.TabStop = false;
            this.icn_exit.Click += new System.EventHandler(this.icn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_loginuser
            // 
            this.lbl_loginuser.AutoSize = true;
            this.lbl_loginuser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_loginuser.LinkColor = System.Drawing.Color.Black;
            this.lbl_loginuser.Location = new System.Drawing.Point(553, 273);
            this.lbl_loginuser.Name = "lbl_loginuser";
            this.lbl_loginuser.Size = new System.Drawing.Size(146, 24);
            this.lbl_loginuser.TabIndex = 30;
            this.lbl_loginuser.TabStop = true;
            this.lbl_loginuser.Text = "İşçi Kimi Daxil Ol";
            this.lbl_loginuser.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // cmbox_dil
            // 
            this.cmbox_dil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_dil.FormattingEnabled = true;
            this.cmbox_dil.Items.AddRange(new object[] {
            "Az",
            "Eng"});
            this.cmbox_dil.Location = new System.Drawing.Point(553, 330);
            this.cmbox_dil.Name = "cmbox_dil";
            this.cmbox_dil.Size = new System.Drawing.Size(66, 28);
            this.cmbox_dil.TabIndex = 31;
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_set.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_set.Location = new System.Drawing.Point(630, 330);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(69, 29);
            this.btn_set.TabIndex = 32;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 411);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.cmbox_dil);
            this.Controls.Add(this.lbl_loginuser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icn_exit);
            this.Controls.Add(this.checkBox_rem);
            this.Controls.Add(this.checkBox_pass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_forgotpass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_rem;
        private System.Windows.Forms.CheckBox checkBox_pass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_forgotpass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox icn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_loginuser;
        private System.Windows.Forms.ComboBox cmbox_dil;
        private System.Windows.Forms.Button btn_set;
    }
}