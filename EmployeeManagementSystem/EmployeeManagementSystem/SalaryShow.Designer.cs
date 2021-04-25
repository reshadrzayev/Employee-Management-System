
namespace EmployeeManagementSystem
{
    partial class SalaryShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryShow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.icn_exit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_sname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printSalaryDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printSalaryDoc = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.icn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 72);
            this.panel1.TabIndex = 59;
            // 
            // icn_exit
            // 
            this.icn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_exit.Image = ((System.Drawing.Image)(resources.GetObject("icn_exit.Image")));
            this.icn_exit.Location = new System.Drawing.Point(458, 0);
            this.icn_exit.Name = "icn_exit";
            this.icn_exit.Size = new System.Drawing.Size(76, 72);
            this.icn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_exit.TabIndex = 4;
            this.icn_exit.TabStop = false;
            this.icn_exit.Click += new System.EventHandler(this.icn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mövqe";
            // 
            // txt_pos
            // 
            this.txt_pos.Enabled = false;
            this.txt_pos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pos.Location = new System.Drawing.Point(183, 338);
            this.txt_pos.Multiline = true;
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.ReadOnly = true;
            this.txt_pos.Size = new System.Drawing.Size(196, 42);
            this.txt_pos.TabIndex = 76;
            this.txt_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 75;
            this.label2.Text = "Bonus Maaş";
            // 
            // txt_bonus
            // 
            this.txt_bonus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bonus.Location = new System.Drawing.Point(184, 453);
            this.txt_bonus.Multiline = true;
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(74, 42);
            this.txt_bonus.TabIndex = 74;
            this.txt_bonus.Text = "0";
            this.txt_bonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bonus.Click += new System.EventHandler(this.txt_bonus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 73;
            this.label1.Text = "İşçi İD";
            // 
            // txt_empid
            // 
            this.txt_empid.Enabled = false;
            this.txt_empid.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_empid.Location = new System.Drawing.Point(182, 171);
            this.txt_empid.Multiline = true;
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.ReadOnly = true;
            this.txt_empid.Size = new System.Drawing.Size(74, 39);
            this.txt_empid.TabIndex = 72;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_salary.Location = new System.Drawing.Point(52, 390);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(116, 28);
            this.lbl_salary.TabIndex = 71;
            this.lbl_salary.Text = "Aylıq Maaş";
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sname.Location = new System.Drawing.Point(99, 283);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(69, 28);
            this.lbl_sname.TabIndex = 70;
            this.lbl_sname.Text = "Soyad";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(130, 225);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 28);
            this.lbl_name.TabIndex = 69;
            this.lbl_name.Text = "Ad";
            // 
            // txt_salary
            // 
            this.txt_salary.Enabled = false;
            this.txt_salary.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_salary.Location = new System.Drawing.Point(183, 393);
            this.txt_salary.Multiline = true;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.ReadOnly = true;
            this.txt_salary.Size = new System.Drawing.Size(196, 42);
            this.txt_salary.TabIndex = 68;
            this.txt_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sname
            // 
            this.txt_sname.Enabled = false;
            this.txt_sname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sname.Location = new System.Drawing.Point(182, 283);
            this.txt_sname.Multiline = true;
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.ReadOnly = true;
            this.txt_sname.Size = new System.Drawing.Size(196, 42);
            this.txt_sname.TabIndex = 67;
            this.txt_sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(182, 225);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(196, 39);
            this.txt_name.TabIndex = 66;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(235, 530);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(122, 65);
            this.btn_print.TabIndex = 78;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // printSalaryDialog
            // 
            this.printSalaryDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printSalaryDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printSalaryDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printSalaryDialog.Document = this.printSalaryDoc;
            this.printSalaryDialog.Enabled = true;
            this.printSalaryDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printSalaryDialog.Icon")));
            this.printSalaryDialog.Name = "printSalaryDialog";
            this.printSalaryDialog.Visible = false;
            // 
            // printSalaryDoc
            // 
            this.printSalaryDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSalaryDoc_PrintPage);
            // 
            // SalaryShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_bonus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_sname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryShow";
            this.Load += new System.EventHandler(this.SalaryShow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Label lbl_sname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox icn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog printSalaryDialog;
        private System.Drawing.Printing.PrintDocument printSalaryDoc;
    }
}