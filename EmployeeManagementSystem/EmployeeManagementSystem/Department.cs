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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NRCMF6O;Initial Catalog=EmployeeDBS;Integrated Security=True");

        private void BrokenConnection()
        {
            if (Con.State == ConnectionState.Broken)
                Con.Close();
                MessageBox.Show("Xəta!", "Yenidən cəhd edin!");
            Con.Open();
        }
        private void Department_Load(object sender, EventArgs e)
        {
            dgv_dep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_pos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void icn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dgv_pos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dgv_pos.SelectedCells[0].RowIndex;

            txt_posid.Text = dgv_pos.Rows[area].Cells[0].Value.ToString();
            txt_posname.Text = dgv_pos.Rows[area].Cells[1].Value.ToString();
            txt_depidpos.Text = dgv_pos.Rows[area].Cells[2].Value.ToString();
            txt_salary.Text = dgv_pos.Rows[area].Cells[3].Value.ToString();
        }

        private void icn_deletedep_Click(object sender, EventArgs e)
        {
            BrokenConnection();
            if (txt_depid.Text == "")
            {
                MessageBox.Show("ID daxil edin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from DepartmentTbl where DepId='" + txt_depid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ID-ye uygun melumatlar silindi.");
                    Con.Close();
                    gridviewDep();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_updatedep_Click(object sender, EventArgs e)
        {
            BrokenConnection();

            if (txt_depname.Text == "")
            {
                MessageBox.Show("Melumatlari tam dolurun!");
            }
            else if (txt_depid.Text == "")
            {
                MessageBox.Show("ID daxil edin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update DepartmentTbl set DepName='" + txt_depname.Text + "' where DepId='" + txt_depid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    Con.Close();
                    gridviewDep();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_adddep_Click(object sender, EventArgs e)
        {
            BrokenConnection();

            if (txt_depname.Text == "")
            {
                MessageBox.Show("Melumatlari tam doldurun!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into DepartmentTbl values('" + txt_depname.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Elave Etme Emeliyyati ugurla neticelendi.");
                    Con.Close();
                    gridviewDep();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_cleardep_Click(object sender, EventArgs e)
        {
            txt_depname.Text = "";
            txt_depid.Text = "";
        }

        private void icn_clearpos_Click(object sender, EventArgs e)
        {
            txt_posname.Text = "";
            txt_depidpos.Text = "";
            txt_salary.Text = "";
            txt_posid.Text = "";
        }

        private void dgv_dep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dgv_dep.SelectedCells[0].RowIndex;

            txt_depid.Text = dgv_dep.Rows[area].Cells[0].Value.ToString();
            txt_depname.Text = dgv_dep.Rows[area].Cells[1].Value.ToString();
        }

        private void icn_addpos_Click(object sender, EventArgs e)
        {
            BrokenConnection();

            if (txt_posname.Text == "" || txt_depidpos.Text == "" || txt_salary.Text == "")
            {
                MessageBox.Show("Melumatlari tam doldurun!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PositionTbl values('" + txt_posname.Text + "','" + txt_depidpos.Text + "','" + txt_salary.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Elave Etme Emeliyyati ugurla neticelendi.");
                    Con.Close();
                    gridviewPos();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_updatepos_Click(object sender, EventArgs e)
        {
            BrokenConnection();

            if (txt_posname.Text == "" || txt_depidpos.Text == "" || txt_salary.Text == "")
            {
                MessageBox.Show("Melumatlari tam dolurun!");
            }
            else if (txt_posid.Text == "")
            {
                MessageBox.Show("ID daxil edin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PositionTbl set Posname='" + txt_posname.Text + "',DepId='" + txt_depidpos.Text + "',Salary='" + txt_salary.Text + "' where PosId='" + txt_posid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    Con.Close();
                    gridviewPos();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_deletepos_Click(object sender, EventArgs e)
        {
            BrokenConnection();

            if (txt_posid.Text == "")
            {
                MessageBox.Show("ID daxil edin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PositionTbl where PosId='" + txt_posid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ID-ye uygun melumatlar silindi.");
                    Con.Close();
                    gridviewPos();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_dgvpos_Click(object sender, EventArgs e)
        {
            gridviewPos();

        }

        private void icn_dgvdep_Click(object sender, EventArgs e)
        {
            gridviewDep();

        }

        private void gridviewDep()
        {
            Con.Open();
            string query = "select * from DepartmentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_dep.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void gridviewPos()
        {
            Con.Open();
            string query = "select * from PositionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_pos.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void icn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
