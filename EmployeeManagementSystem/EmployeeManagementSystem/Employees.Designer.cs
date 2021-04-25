
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_showpos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_empfin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_empsname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_empphone = new System.Windows.Forms.TextBox();
            this.cb_empposid = new System.Windows.Forms.ComboBox();
            this.dtp_empbirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_empadd = new System.Windows.Forms.TextBox();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_pos = new System.Windows.Forms.DataGridView();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.icn_add = new System.Windows.Forms.PictureBox();
            this.icn_update = new System.Windows.Forms.PictureBox();
            this.icn_delete = new System.Windows.Forms.PictureBox();
            this.icn_clear = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(325, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "Şifrə";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(325, 556);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(240, 27);
            this.txt_pass.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Email ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(37, 556);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 27);
            this.txt_email.TabIndex = 59;
            // 
            // btn_showpos
            // 
            this.btn_showpos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showpos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_showpos.ForeColor = System.Drawing.Color.White;
            this.btn_showpos.Location = new System.Drawing.Point(325, 452);
            this.btn_showpos.Name = "btn_showpos";
            this.btn_showpos.Size = new System.Drawing.Size(173, 48);
            this.btn_showpos.TabIndex = 58;
            this.btn_showpos.Text = "Mövqeləri Göstər";
            this.btn_showpos.UseVisualStyleBackColor = false;
            this.btn_showpos.Click += new System.EventHandler(this.btn_showpos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 57;
            this.label10.Text = "FIN Kod";
            // 
            // txt_empfin
            // 
            this.txt_empfin.Location = new System.Drawing.Point(35, 207);
            this.txt_empfin.MaxLength = 8;
            this.txt_empfin.Name = "txt_empfin";
            this.txt_empfin.Size = new System.Drawing.Size(240, 27);
            this.txt_empfin.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(35, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 55;
            // 
            // txt_empsname
            // 
            this.txt_empsname.Location = new System.Drawing.Point(323, 132);
            this.txt_empsname.Name = "txt_empsname";
            this.txt_empsname.Size = new System.Drawing.Size(240, 27);
            this.txt_empsname.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(323, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Əlaqə Nömrəsi";
            // 
            // txt_empphone
            // 
            this.txt_empphone.Location = new System.Drawing.Point(325, 206);
            this.txt_empphone.MaxLength = 10;
            this.txt_empphone.Name = "txt_empphone";
            this.txt_empphone.Size = new System.Drawing.Size(240, 27);
            this.txt_empphone.TabIndex = 51;
            // 
            // cb_empposid
            // 
            this.cb_empposid.FormattingEnabled = true;
            this.cb_empposid.Items.AddRange(new object[] {
            ""});
            this.cb_empposid.Location = new System.Drawing.Point(35, 452);
            this.cb_empposid.Name = "cb_empposid";
            this.cb_empposid.Size = new System.Drawing.Size(240, 28);
            this.cb_empposid.TabIndex = 50;
            // 
            // dtp_empbirth
            // 
            this.dtp_empbirth.Location = new System.Drawing.Point(35, 370);
            this.dtp_empbirth.Name = "dtp_empbirth";
            this.dtp_empbirth.Size = new System.Drawing.Size(262, 27);
            this.dtp_empbirth.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Doğum Tarixi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Mövqe ID-si";
            // 
            // txt_empadd
            // 
            this.txt_empadd.Location = new System.Drawing.Point(35, 282);
            this.txt_empadd.Name = "txt_empadd";
            this.txt_empadd.Size = new System.Drawing.Size(240, 27);
            this.txt_empadd.TabIndex = 46;
            // 
            // txt_empname
            // 
            this.txt_empname.Location = new System.Drawing.Point(35, 132);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(240, 27);
            this.txt_empname.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ad";
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
            this.icn_add.Location = new System.Drawing.Point(38, 636);
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
            this.icn_update.Location = new System.Drawing.Point(143, 636);
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
            this.icn_delete.Location = new System.Drawing.Point(248, 636);
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
            this.icn_clear.Location = new System.Drawing.Point(355, 636);
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
            this.label11.Location = new System.Drawing.Point(510, 636);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 24);
            this.label11.TabIndex = 68;
            this.label11.Text = "ID";
            // 
            // txt_empid
            // 
            this.txt_empid.Location = new System.Drawing.Point(481, 663);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(85, 27);
            this.txt_empid.TabIndex = 67;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 773);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.icn_clear);
            this.Controls.Add(this.icn_delete);
            this.Controls.Add(this.icn_update);
            this.Controls.Add(this.icn_add);
            this.Controls.Add(this.dgv_pos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_emp);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_showpos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_empfin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_empsname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_empphone);
            this.Controls.Add(this.cb_empposid);
            this.Controls.Add(this.dtp_empbirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_empadd);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_showpos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_empfin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_empsname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_empphone;
        private System.Windows.Forms.ComboBox cb_empposid;
        private System.Windows.Forms.DateTimePicker dtp_empbirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_empadd;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_pos;
        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.PictureBox icn_add;
        private System.Windows.Forms.PictureBox icn_update;
        private System.Windows.Forms.PictureBox icn_delete;
        private System.Windows.Forms.PictureBox icn_clear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_empid;
    }
}

