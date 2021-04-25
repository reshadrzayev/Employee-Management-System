
namespace EmployeeManagementSystem
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.panel1 = new System.Windows.Forms.Panel();
            this.icn_exit = new System.Windows.Forms.PictureBox();
            this.icn_back = new System.Windows.Forms.PictureBox();
            this.dgv_dep = new System.Windows.Forms.DataGridView();
            this.dgv_pos = new System.Windows.Forms.DataGridView();
            this.txt_depname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_posname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_depidpos = new System.Windows.Forms.TextBox();
            this.icn_adddep = new System.Windows.Forms.PictureBox();
            this.icn_updatedep = new System.Windows.Forms.PictureBox();
            this.icn_deletedep = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_depid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_posid = new System.Windows.Forms.TextBox();
            this.icn_dgvdep = new System.Windows.Forms.PictureBox();
            this.icn_cleardep = new System.Windows.Forms.PictureBox();
            this.icn_clearpos = new System.Windows.Forms.PictureBox();
            this.icn_dgvpos = new System.Windows.Forms.PictureBox();
            this.icn_deletepos = new System.Windows.Forms.PictureBox();
            this.icn_updatepos = new System.Windows.Forms.PictureBox();
            this.icn_addpos = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_adddep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_updatedep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_deletedep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_dgvdep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_cleardep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_clearpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_dgvpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_deletepos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_updatepos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_addpos)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1275, 66);
            this.panel1.TabIndex = 1;
            // 
            // icn_exit
            // 
            this.icn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_exit.Image = ((System.Drawing.Image)(resources.GetObject("icn_exit.Image")));
            this.icn_exit.Location = new System.Drawing.Point(1205, 0);
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
            // dgv_dep
            // 
            this.dgv_dep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dep.Location = new System.Drawing.Point(640, 72);
            this.dgv_dep.Name = "dgv_dep";
            this.dgv_dep.RowHeadersWidth = 51;
            this.dgv_dep.RowTemplate.Height = 29;
            this.dgv_dep.Size = new System.Drawing.Size(635, 290);
            this.dgv_dep.TabIndex = 2;
            this.dgv_dep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dep_CellClick);
            // 
            // dgv_pos
            // 
            this.dgv_pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pos.Location = new System.Drawing.Point(640, 368);
            this.dgv_pos.Name = "dgv_pos";
            this.dgv_pos.RowHeadersWidth = 51;
            this.dgv_pos.RowTemplate.Height = 29;
            this.dgv_pos.Size = new System.Drawing.Size(635, 368);
            this.dgv_pos.TabIndex = 3;
            this.dgv_pos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pos_CellClick);
            // 
            // txt_depname
            // 
            this.txt_depname.Location = new System.Drawing.Point(32, 139);
            this.txt_depname.Multiline = true;
            this.txt_depname.Name = "txt_depname";
            this.txt_depname.Size = new System.Drawing.Size(454, 38);
            this.txt_depname.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Department Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Maaş";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(38, 552);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(184, 27);
            this.txt_salary.TabIndex = 58;
            // 
            // txt_posname
            // 
            this.txt_posname.Location = new System.Drawing.Point(34, 400);
            this.txt_posname.Multiline = true;
            this.txt_posname.Name = "txt_posname";
            this.txt_posname.Size = new System.Drawing.Size(454, 38);
            this.txt_posname.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mövqe Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Uyğun Deparment İD";
            // 
            // txt_depidpos
            // 
            this.txt_depidpos.Location = new System.Drawing.Point(36, 478);
            this.txt_depidpos.Name = "txt_depidpos";
            this.txt_depidpos.Size = new System.Drawing.Size(184, 27);
            this.txt_depidpos.TabIndex = 54;
            // 
            // icn_adddep
            // 
            this.icn_adddep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_adddep.Image = ((System.Drawing.Image)(resources.GetObject("icn_adddep.Image")));
            this.icn_adddep.Location = new System.Drawing.Point(34, 198);
            this.icn_adddep.Name = "icn_adddep";
            this.icn_adddep.Size = new System.Drawing.Size(74, 71);
            this.icn_adddep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_adddep.TabIndex = 60;
            this.icn_adddep.TabStop = false;
            this.icn_adddep.Click += new System.EventHandler(this.icn_adddep_Click);
            // 
            // icn_updatedep
            // 
            this.icn_updatedep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_updatedep.Image = ((System.Drawing.Image)(resources.GetObject("icn_updatedep.Image")));
            this.icn_updatedep.Location = new System.Drawing.Point(144, 198);
            this.icn_updatedep.Name = "icn_updatedep";
            this.icn_updatedep.Size = new System.Drawing.Size(74, 71);
            this.icn_updatedep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_updatedep.TabIndex = 61;
            this.icn_updatedep.TabStop = false;
            this.icn_updatedep.Click += new System.EventHandler(this.icn_updatedep_Click);
            // 
            // icn_deletedep
            // 
            this.icn_deletedep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_deletedep.Image = ((System.Drawing.Image)(resources.GetObject("icn_deletedep.Image")));
            this.icn_deletedep.Location = new System.Drawing.Point(269, 198);
            this.icn_deletedep.Name = "icn_deletedep";
            this.icn_deletedep.Size = new System.Drawing.Size(74, 71);
            this.icn_deletedep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_deletedep.TabIndex = 62;
            this.icn_deletedep.TabStop = false;
            this.icn_deletedep.Click += new System.EventHandler(this.icn_deletedep_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(429, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "ID";
            // 
            // txt_depid
            // 
            this.txt_depid.Location = new System.Drawing.Point(401, 240);
            this.txt_depid.Name = "txt_depid";
            this.txt_depid.Size = new System.Drawing.Size(85, 27);
            this.txt_depid.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(429, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID";
            // 
            // txt_posid
            // 
            this.txt_posid.Location = new System.Drawing.Point(401, 641);
            this.txt_posid.Name = "txt_posid";
            this.txt_posid.Size = new System.Drawing.Size(85, 27);
            this.txt_posid.TabIndex = 68;
            // 
            // icn_dgvdep
            // 
            this.icn_dgvdep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_dgvdep.Image = ((System.Drawing.Image)(resources.GetObject("icn_dgvdep.Image")));
            this.icn_dgvdep.Location = new System.Drawing.Point(505, 139);
            this.icn_dgvdep.Name = "icn_dgvdep";
            this.icn_dgvdep.Size = new System.Drawing.Size(44, 38);
            this.icn_dgvdep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_dgvdep.TabIndex = 70;
            this.icn_dgvdep.TabStop = false;
            this.icn_dgvdep.Click += new System.EventHandler(this.icn_dgvdep_Click);
            // 
            // icn_cleardep
            // 
            this.icn_cleardep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_cleardep.Image = ((System.Drawing.Image)(resources.GetObject("icn_cleardep.Image")));
            this.icn_cleardep.Location = new System.Drawing.Point(572, 139);
            this.icn_cleardep.Name = "icn_cleardep";
            this.icn_cleardep.Size = new System.Drawing.Size(44, 38);
            this.icn_cleardep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_cleardep.TabIndex = 71;
            this.icn_cleardep.TabStop = false;
            this.icn_cleardep.Click += new System.EventHandler(this.icn_cleardep_Click);
            // 
            // icn_clearpos
            // 
            this.icn_clearpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_clearpos.Image = ((System.Drawing.Image)(resources.GetObject("icn_clearpos.Image")));
            this.icn_clearpos.Location = new System.Drawing.Point(572, 400);
            this.icn_clearpos.Name = "icn_clearpos";
            this.icn_clearpos.Size = new System.Drawing.Size(44, 38);
            this.icn_clearpos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_clearpos.TabIndex = 73;
            this.icn_clearpos.TabStop = false;
            this.icn_clearpos.Click += new System.EventHandler(this.icn_clearpos_Click);
            // 
            // icn_dgvpos
            // 
            this.icn_dgvpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_dgvpos.Image = ((System.Drawing.Image)(resources.GetObject("icn_dgvpos.Image")));
            this.icn_dgvpos.Location = new System.Drawing.Point(505, 400);
            this.icn_dgvpos.Name = "icn_dgvpos";
            this.icn_dgvpos.Size = new System.Drawing.Size(44, 38);
            this.icn_dgvpos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_dgvpos.TabIndex = 72;
            this.icn_dgvpos.TabStop = false;
            this.icn_dgvpos.Click += new System.EventHandler(this.icn_dgvpos_Click);
            // 
            // icn_deletepos
            // 
            this.icn_deletepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_deletepos.Image = ((System.Drawing.Image)(resources.GetObject("icn_deletepos.Image")));
            this.icn_deletepos.Location = new System.Drawing.Point(273, 608);
            this.icn_deletepos.Name = "icn_deletepos";
            this.icn_deletepos.Size = new System.Drawing.Size(74, 71);
            this.icn_deletepos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_deletepos.TabIndex = 76;
            this.icn_deletepos.TabStop = false;
            this.icn_deletepos.Click += new System.EventHandler(this.icn_deletepos_Click);
            // 
            // icn_updatepos
            // 
            this.icn_updatepos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_updatepos.Image = ((System.Drawing.Image)(resources.GetObject("icn_updatepos.Image")));
            this.icn_updatepos.Location = new System.Drawing.Point(148, 608);
            this.icn_updatepos.Name = "icn_updatepos";
            this.icn_updatepos.Size = new System.Drawing.Size(74, 71);
            this.icn_updatepos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_updatepos.TabIndex = 75;
            this.icn_updatepos.TabStop = false;
            this.icn_updatepos.Click += new System.EventHandler(this.icn_updatepos_Click);
            // 
            // icn_addpos
            // 
            this.icn_addpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icn_addpos.Image = ((System.Drawing.Image)(resources.GetObject("icn_addpos.Image")));
            this.icn_addpos.Location = new System.Drawing.Point(38, 608);
            this.icn_addpos.Name = "icn_addpos";
            this.icn_addpos.Size = new System.Drawing.Size(74, 71);
            this.icn_addpos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icn_addpos.TabIndex = 74;
            this.icn_addpos.TabStop = false;
            this.icn_addpos.Click += new System.EventHandler(this.icn_addpos_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 748);
            this.Controls.Add(this.icn_deletepos);
            this.Controls.Add(this.icn_updatepos);
            this.Controls.Add(this.icn_addpos);
            this.Controls.Add(this.icn_clearpos);
            this.Controls.Add(this.icn_dgvpos);
            this.Controls.Add(this.icn_cleardep);
            this.Controls.Add(this.icn_dgvdep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_posid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_depid);
            this.Controls.Add(this.icn_deletedep);
            this.Controls.Add(this.icn_updatedep);
            this.Controls.Add(this.icn_adddep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_posname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_depidpos);
            this.Controls.Add(this.txt_depname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_dep);
            this.Controls.Add(this.dgv_pos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_adddep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_updatedep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_deletedep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_dgvdep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_cleardep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_clearpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_dgvpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_deletepos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_updatepos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_addpos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox icn_exit;
        private System.Windows.Forms.PictureBox icn_back;
        private System.Windows.Forms.DataGridView dgv_dep;
        private System.Windows.Forms.DataGridView dgv_pos;
        private System.Windows.Forms.TextBox txt_depname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_posname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_depidpos;
        private System.Windows.Forms.PictureBox icn_adddep;
        private System.Windows.Forms.PictureBox icn_updatedep;
        private System.Windows.Forms.PictureBox icn_deletedep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_depid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_posid;
        private System.Windows.Forms.PictureBox icn_dgvdep;
        private System.Windows.Forms.PictureBox icn_cleardep;
        private System.Windows.Forms.PictureBox icn_clearpos;
        private System.Windows.Forms.PictureBox icn_dgvpos;
        private System.Windows.Forms.PictureBox icn_deletepos;
        private System.Windows.Forms.PictureBox icn_updatepos;
        private System.Windows.Forms.PictureBox icn_addpos;
    }
}