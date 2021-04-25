using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class SalaryShow : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NRCMF6O;Initial Catalog=EmployeeDBS;Integrated Security=True");


        public SalaryShow(string Ad, string Soyad, string PosId, string EmpId)
        {
            InitializeComponent();

            Con.Open();
            string query = "select * from PositionTbl where PosId = '" + PosId + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txt_salary.Text = da.GetValue(3).ToString();
                txt_pos.Text = da.GetValue(1).ToString();

            }

            txt_name.Text = Ad;
            txt_sname.Text = Soyad;
            txt_empid.Text = EmpId;
            Con.Close();
        }

        private void SalaryShow_Load(object sender, EventArgs e)
        {

        }

        private void icn_exit_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            this.Hide();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printSalaryDialog.ShowDialog() == DialogResult.OK)
            {
                printSalaryDoc.Print();
            }
        }

        private void printSalaryDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int a = Convert.ToInt32(txt_bonus.Text);
            int b = Convert.ToInt32(txt_salary.Text);
            int total = a + b;

            e.Graphics.DrawString("~~~~~~~MAAŞ QƏBZİ~~~~~~~", new Font("Calibri", 24, FontStyle.Bold), Brushes.DarkCyan, new Point(180));
            e.Graphics.DrawString("ID : " + txt_empid.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, new Point(250, 80));
            e.Graphics.DrawString("Ad : " + txt_name.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, new Point(250, 110));
            e.Graphics.DrawString("Soyad : " + txt_sname.Text, new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, new Point(250, 140));
            e.Graphics.DrawString("Maaş : " + total + " AZN", new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, new Point(250, 200));
            e.Graphics.DrawString("Tarix : " + DateTime.Now.ToString(), new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, new Point(250, 230));
        }

        private void txt_bonus_Click(object sender, EventArgs e)
        {
            txt_bonus.Text = "";

        }
    }
}
