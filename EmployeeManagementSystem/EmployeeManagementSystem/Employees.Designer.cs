
namespace EmployeeManagementSystem
{
    partial class Employees
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.icn_exit = new System.Windows.Forms.PictureBox();
            this.icn_back = new System.Windows.Forms.PictureBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_showpos = new System.Windows.Forms.Button();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.txt_empfin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_empsname = new System.Windows.Forms.TextBox();
            this.lbl_sname = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_empphone = new System.Windows.Forms.TextBox();
            this.cb_empposid = new System.Windows.Forms.ComboBox();
            this.dtp_empbirth = new System.Windows.Forms.DateTimePicker();
            this.lbl_bday = new System.Windows.Forms.Label();
            this.lbl_posid = new System.Windows.Forms.Label();
            this.txt_empadd = new System.Windows.Forms.TextBox();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.lbl_add = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_pos = new System.Windows.Forms.DataGridView();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.icn_add = new System.Windows.Forms.PictureBox();
            this.icn_update = new System.Windows.Forms.PictureBox();
            this.icn_delete = new System.Windows.Forms.PictureBox();
            this.icn_clear = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.cmbox_dil = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_clear)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.icn_exit);
            this.panel1.Controls.Add(this.icn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 66);
            this.panel1.TabIndex = 0;
            // 
            // icn_exit
            // 
            this.icn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_exit.Image = ((System.Drawing.Image)(resources.GetObject("icn_exit.Image")));
            this.icn_exit.Location = new System.Drawing.Point(1293, 0);
            this.icn_exit.Name = "icn_exit";
            this.icn_exit.Size = new System.Drawing.Size(70, 66);
            this.icn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_exit.TabIndex = 2;
            this.icn_exit.TabStop = false;
            this.icn_exit.Click += new System.EventHandler(this.icn_exit_Click);
            // 
            // icn_back
            // 
            this.icn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_back.Image = ((System.Drawing.Image)(resources.GetObject("icn_back.Image")));
            this.icn_back.Location = new System.Drawing.Point(0, 0);
            this.icn_back.Name = "icn_back";
            this.icn_back.Size = new System.Drawing.Size(70, 66);
            this.icn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_back.TabIndex = 1;
            this.icn_back.TabStop = false;
            this.icn_back.Click += new System.EventHandler(this.icn_back_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pass.Location = new System.Drawing.Point(325, 541);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(47, 24);
            this.lbl_pass.TabIndex = 62;
            this.lbl_pass.Text = "Şifrə";
            this.lbl_pass.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(325, 572);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(240, 27);
            this.txt_pass.TabIndex = 61;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(35, 541);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(61, 24);
            this.lbl_email.TabIndex = 60;
            this.lbl_email.Text = "Email ";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(37, 572);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 27);
            this.txt_email.TabIndex = 59;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // btn_showpos
            // 
            this.btn_showpos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showpos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_showpos.ForeColor = System.Drawing.Color.White;
            this.btn_showpos.Location = new System.Drawing.Point(325, 468);
            this.btn_showpos.Name = "btn_showpos";
            this.btn_showpos.Size = new System.Drawing.Size(213, 48);
            this.btn_showpos.TabIndex = 58;
            this.btn_showpos.Text = "Mövqeləri Göstər";
            this.btn_showpos.UseVisualStyleBackColor = false;
            this.btn_showpos.Click += new System.EventHandler(this.btn_showpos_Click);
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fin.Location = new System.Drawing.Point(35, 191);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(75, 24);
            this.lbl_fin.TabIndex = 57;
            this.lbl_fin.Text = "FIN Kod";
            this.lbl_fin.Click += new System.EventHandler(this.lbl_fin_Click);
            // 
            // txt_empfin
            // 
            this.txt_empfin.Location = new System.Drawing.Point(35, 223);
            this.txt_empfin.MaxLength = 8;
            this.txt_empfin.Name = "txt_empfin";
            this.txt_empfin.Size = new System.Drawing.Size(240, 27);
            this.txt_empfin.TabIndex = 56;
            this.txt_empfin.TextChanged += new System.EventHandler(this.txt_empfin_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(35, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 55;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_empsname
            // 
            this.txt_empsname.Location = new System.Drawing.Point(323, 148);
            this.txt_empsname.Name = "txt_empsname";
            this.txt_empsname.Size = new System.Drawing.Size(240, 27);
            this.txt_empsname.TabIndex = 54;
            this.txt_empsname.TextChanged += new System.EventHandler(this.txt_empsname_TextChanged);
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sname.Location = new System.Drawing.Point(323, 116);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(60, 24);
            this.lbl_sname.TabIndex = 53;
            this.lbl_sname.Text = "Soyad";
            this.lbl_sname.Click += new System.EventHandler(this.lbl_sname_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.Location = new System.Drawing.Point(323, 191);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(134, 24);
            this.lbl_phone.TabIndex = 52;
            this.lbl_phone.Text = "Əlaqə Nömrəsi";
            this.lbl_phone.Click += new System.EventHandler(this.lbl_phone_Click);
            // 
            // txt_empphone
            // 
            this.txt_empphone.Location = new System.Drawing.Point(325, 222);
            this.txt_empphone.MaxLength = 10;
            this.txt_empphone.Name = "txt_empphone";
            this.txt_empphone.Size = new System.Drawing.Size(240, 27);
            this.txt_empphone.TabIndex = 51;
            this.txt_empphone.TextChanged += new System.EventHandler(this.txt_empphone_TextChanged);
            // 
            // cb_empposid
            // 
            this.cb_empposid.FormattingEnabled = true;
            this.cb_empposid.Items.AddRange(new object[] {
            ""});
            this.cb_empposid.Location = new System.Drawing.Point(35, 468);
            this.cb_empposid.Name = "cb_empposid";
            this.cb_empposid.Size = new System.Drawing.Size(240, 28);
            this.cb_empposid.TabIndex = 50;
            this.cb_empposid.SelectedIndexChanged += new System.EventHandler(this.cb_empposid_SelectedIndexChanged);
            // 
            // dtp_empbirth
            // 
            this.dtp_empbirth.Location = new System.Drawing.Point(35, 386);
            this.dtp_empbirth.Name = "dtp_empbirth";
            this.dtp_empbirth.Size = new System.Drawing.Size(262, 27);
            this.dtp_empbirth.TabIndex = 49;
            this.dtp_empbirth.ValueChanged += new System.EventHandler(this.dtp_empbirth_ValueChanged);
            // 
            // lbl_bday
            // 
            this.lbl_bday.AutoSize = true;
            this.lbl_bday.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bday.Location = new System.Drawing.Point(35, 348);
            this.lbl_bday.Name = "lbl_bday";
            this.lbl_bday.Size = new System.Drawing.Size(119, 24);
            this.lbl_bday.TabIndex = 48;
            this.lbl_bday.Text = "Doğum Tarixi";
            this.lbl_bday.Click += new System.EventHandler(this.lbl_bday_Click);
            // 
            // lbl_posid
            // 
            this.lbl_posid.AutoSize = true;
            this.lbl_posid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_posid.Location = new System.Drawing.Point(35, 433);
            this.lbl_posid.Name = "lbl_posid";
            this.lbl_posid.Size = new System.Drawing.Size(110, 24);
            this.lbl_posid.TabIndex = 47;
            this.lbl_posid.Text = "Mövqe ID-si";
            this.lbl_posid.Click += new System.EventHandler(this.lbl_pos_Click);
            // 
            // txt_empadd
            // 
            this.txt_empadd.Location = new System.Drawing.Point(35, 298);
            this.txt_empadd.Name = "txt_empadd";
            this.txt_empadd.Size = new System.Drawing.Size(240, 27);
            this.txt_empadd.TabIndex = 46;
            this.txt_empadd.TextChanged += new System.EventHandler(this.txt_empadd_TextChanged);
            // 
            // txt_empname
            // 
            this.txt_empname.Location = new System.Drawing.Point(35, 148);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(240, 27);
            this.txt_empname.TabIndex = 45;
            this.txt_empname.TextChanged += new System.EventHandler(this.txt_empname_TextChanged);
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_add.Location = new System.Drawing.Point(35, 266);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(58, 24);
            this.lbl_add.TabIndex = 44;
            this.lbl_add.Text = "Adres";
            this.lbl_add.Click += new System.EventHandler(this.lbl_add_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(35, 116);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(33, 24);
            this.lbl_name.TabIndex = 43;
            this.lbl_name.Text = "Ad";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // dgv_pos
            // 
            this.dgv_pos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pos.Location = new System.Drawing.Point(602, 481);
            this.dgv_pos.Name = "dgv_pos";
            this.dgv_pos.RowHeadersWidth = 51;
            this.dgv_pos.RowTemplate.Height = 29;
            this.dgv_pos.Size = new System.Drawing.Size(761, 280);
            this.dgv_pos.TabIndex = 51;
            this.dgv_pos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pos_CellContentClick);
            // 
            // dgv_emp
            // 
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Location = new System.Drawing.Point(602, 72);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.ReadOnly = true;
            this.dgv_emp.RowHeadersWidth = 51;
            this.dgv_emp.RowTemplate.Height = 29;
            this.dgv_emp.Size = new System.Drawing.Size(761, 403);
            this.dgv_emp.TabIndex = 50;
            this.dgv_emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellClick);
            // 
            // icn_add
            // 
            this.icn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_add.Image = ((System.Drawing.Image)(resources.GetObject("icn_add.Image")));
            this.icn_add.Location = new System.Drawing.Point(38, 652);
            this.icn_add.Name = "icn_add";
            this.icn_add.Size = new System.Drawing.Size(81, 81);
            this.icn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_add.TabIndex = 63;
            this.icn_add.TabStop = false;
            this.icn_add.Click += new System.EventHandler(this.icn_add_Click);
            // 
            // icn_update
            // 
            this.icn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_update.Image = ((System.Drawing.Image)(resources.GetObject("icn_update.Image")));
            this.icn_update.Location = new System.Drawing.Point(143, 652);
            this.icn_update.Name = "icn_update";
            this.icn_update.Size = new System.Drawing.Size(81, 81);
            this.icn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_update.TabIndex = 64;
            this.icn_update.TabStop = false;
            this.icn_update.Click += new System.EventHandler(this.icn_update_Click);
            // 
            // icn_delete
            // 
            this.icn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_delete.Image = ((System.Drawing.Image)(resources.GetObject("icn_delete.Image")));
            this.icn_delete.Location = new System.Drawing.Point(248, 652);
            this.icn_delete.Name = "icn_delete";
            this.icn_delete.Size = new System.Drawing.Size(81, 81);
            this.icn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_delete.TabIndex = 65;
            this.icn_delete.TabStop = false;
            this.icn_delete.Click += new System.EventHandler(this.icn_delete_Click);
            // 
            // icn_clear
            // 
            this.icn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_clear.Image = ((System.Drawing.Image)(resources.GetObject("icn_clear.Image")));
            this.icn_clear.Location = new System.Drawing.Point(355, 652);
            this.icn_clear.Name = "icn_clear";
            this.icn_clear.Size = new System.Drawing.Size(81, 81);
            this.icn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_clear.TabIndex = 66;
            this.icn_clear.TabStop = false;
            this.icn_clear.Click += new System.EventHandler(this.icn_clear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(510, 652);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 24);
            this.label11.TabIndex = 68;
            this.label11.Text = "ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_empid
            // 
            this.txt_empid.Location = new System.Drawing.Point(481, 679);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(85, 27);
            this.txt_empid.TabIndex = 67;
            this.txt_empid.TextChanged += new System.EventHandler(this.txt_empid_TextChanged);
            // 
            // cmbox_dil
            // 
            this.cmbox_dil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbox_dil.Enabled = false;
            this.cmbox_dil.FormattingEnabled = true;
            this.cmbox_dil.Items.AddRange(new object[] {
            "Az",
            "Eng"});
            this.cmbox_dil.Location = new System.Drawing.Point(497, 72);
            this.cmbox_dil.Name = "cmbox_dil";
            this.cmbox_dil.Size = new System.Drawing.Size(66, 28);
            this.cmbox_dil.TabIndex = 69;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 773);
            this.Controls.Add(this.cmbox_dil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.icn_clear);
            this.Controls.Add(this.icn_delete);
            this.Controls.Add(this.icn_update);
            this.Controls.Add(this.icn_add);
            this.Controls.Add(this.dgv_pos);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.dgv_emp);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_showpos);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.txt_empfin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_empsname);
            this.Controls.Add(this.lbl_sname);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_empphone);
            this.Controls.Add(this.cb_empposid);
            this.Controls.Add(this.dtp_empbirth);
            this.Controls.Add(this.lbl_bday);
            this.Controls.Add(this.lbl_posid);
            this.Controls.Add(this.txt_empadd);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_clear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox icn_exit;
        private System.Windows.Forms.PictureBox icn_back;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_showpos;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.TextBox txt_empfin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_empsname;
        private System.Windows.Forms.Label lbl_sname;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_empphone;
        private System.Windows.Forms.ComboBox cb_empposid;
        private System.Windows.Forms.DateTimePicker dtp_empbirth;
        private System.Windows.Forms.Label lbl_bday;
        private System.Windows.Forms.Label lbl_posid;
        private System.Windows.Forms.TextBox txt_empadd;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_pos;
        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.PictureBox icn_add;
        private System.Windows.Forms.PictureBox icn_update;
        private System.Windows.Forms.PictureBox icn_delete;
        private System.Windows.Forms.PictureBox icn_clear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.ComboBox cmbox_dil;
    }
}

