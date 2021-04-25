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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NRCMF6O;Initial Catalog=EmployeeDBS;Integrated Security=True");
        DataTable dt = new DataTable("EmployeeTbl");
        private void Salary_Load(object sender, EventArgs e)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select * from EmployeeTbl ", Con))
                {
                    da.Fill(dt);
                    dgv_salary.DataSource = dt;
                    DataView dv = dt.DefaultView;

                }
                Con.Close();
            }
        }

        private void icn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void icn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void icn_help_MouseHover(object sender, EventArgs e)
        {
            lbl_help.Visible = true;

        }

        private void icn_help_MouseLeave(object sender, EventArgs e)
        {
            lbl_help.Visible = false;

        }

        private void gridviewEmp()
        {
            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_salary.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void icn_refresh_Click(object sender, EventArgs e)
        {
            gridviewEmp();

            txt_name.Text = "";
            txt_sname.Text = "";
            txt_empid.Text = "";
            txt_pos.Text = "";
        }

        private void dgv_salary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dgv_salary.SelectedCells[0].RowIndex;

            txt_empid.Text = dgv_salary.Rows[area].Cells[0].Value.ToString();
            txt_name.Text = dgv_salary.Rows[area].Cells[1].Value.ToString();
            txt_sname.Text = dgv_salary.Rows[area].Cells[2].Value.ToString();
            txt_pos.Text = dgv_salary.Rows[area].Cells[7].Value.ToString();
        }

        private void dgv_salary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SalaryShow sal = new SalaryShow(txt_name.Text, txt_sname.Text, txt_pos.Text, txt_empid.Text);
            sal.ShowDialog();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Name like '%{0}%'", txt_name.Text);
                dgv_salary.DataSource = dv.ToTable();
            }
        }

        private void txt_sname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Surname like '%{0}%'", txt_sname.Text);
                dgv_salary.DataSource = dv.ToTable();
            }
        }
    }
}
