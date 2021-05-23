using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EmployeeManagementSystem
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NRCMF6O;Initial Catalog=EmployeeDBS;Integrated Security=True");

        private void Employees_Load(object sender, EventArgs e)
        {
            cb_empposid.Items.Clear();
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select PosId from PositionTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb_empposid.Items.Add(dr["PosId"].ToString());

            }
            Con.Close();
            gridviewEmp();

            //dgv_emp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_pos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            switch (LangCommon.GetLanguage())
            {
                case "az": cmbox_dil.SelectedIndex = 0; break;
                case "en": cmbox_dil.SelectedIndex = 1; break;
                default: cmbox_dil.SelectedIndex = 0; break;
            }
            //lbl_heading.Text = LangCommon.rm.GetString("lbl_heading");
            //btn_emp.Text = LangCommon.rm.GetString("btn_emp");
            //btn_dep.Text = LangCommon.rm.GetString("btn_dep");

            //btn_salary.Text = LangCommon.rm.GetString("btn_salary");-
            lbl_name.Text = LangCommon.rm.GetString("lbl_name");
            lbl_sname.Text = LangCommon.rm.GetString("lbl_sname");
            lbl_fin.Text = LangCommon.rm.GetString("lbl_fin");
            lbl_phone.Text = LangCommon.rm.GetString("lbl_phone");
            lbl_add.Text = LangCommon.rm.GetString("lbl_add");
            lbl_bday.Text = LangCommon.rm.GetString("lbl_bday");
            lbl_posid.Text = LangCommon.rm.GetString("lbl_posid");
            lbl_email.Text = LangCommon.rm.GetString("lbl_email");
            lbl_pass.Text = LangCommon.rm.GetString("lbl_pass");
            btn_showpos.Text = LangCommon.rm.GetString("btn_showpos");

        }

        private void gridviewEmp()
        {
            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_emp.DataSource = ds.Tables[0];
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

        private void icn_add_Click(object sender, EventArgs e)
        {
            if (txt_empsname.Text == "" || txt_empname.Text == "" || txt_empphone.Text == "" || txt_empadd.Text == "" || txt_empfin.Text == "" || txt_empadd.Text == "" || txt_email.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Məlumatları tam doldurun!");
            }
            else if (txt_empfin.Text.Length < 8)
            {
                MessageBox.Show("FİN 8 simvoldan ibarət olmalıdır!");
            }
            else if (txt_email.Text.Length <= 7 || txt_pass.Text.Length <= 7)
            {
                MessageBox.Show("Email və şifrə minimum 8 simvoldan ibarət olmalıdır!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EmployeeTbl values('" + txt_empname.Text + "','" + txt_empsname.Text + "','" + txt_empfin.Text + "','" + txt_empphone.Text + "','" + txt_empadd.Text + "','" + dtp_empbirth.Value.Date + "','" + cb_empposid.SelectedItem.ToString() + "','" + txt_email.Text + "','" + txt_pass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Əlavə etmə əməliyyatı uğurla başa çatdı!");
                    Con.Close();
                    gridviewEmp();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            gridviewEmp();
        }

        private void btn_showpos_Click(object sender, EventArgs e)
        {
            gridviewPos();

        }

        private void icn_update_Click(object sender, EventArgs e)
        {
            if (txt_empid.Text == "" || txt_empname.Text == "" || txt_empphone.Text == "" || txt_empadd.Text == "")
            {
                MessageBox.Show("Məlumatları tam doldurun!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmployeeTbl set Name='" + txt_empname.Text + "',Surname='" + txt_empsname.Text + "',FIN='" + txt_empfin.Text + "',Phone='" + txt_empphone.Text + "',Address='" + txt_empadd.Text + "',Birthday='" + dtp_empbirth.Value.Date + "',PosId='" + cb_empposid.SelectedItem.ToString() + "',Email='" + txt_email.Text + "',Password='" + txt_pass.Text + "' where EmpId='" + txt_empid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Məlumatlar uğurla yeniləndi!");
                    Con.Close();
                    gridviewEmp();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void icn_delete_Click(object sender, EventArgs e)
        {
            if (txt_empid.Text == "")
            {
                MessageBox.Show("ID daxil edin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmployeeTbl where Empid='" + txt_empid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İD-yə uyğun məlumatlar silindi.");
                    Con.Close();
                    gridviewEmp();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dgv_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dgv_emp.SelectedCells[0].RowIndex;

            txt_empid.Text = dgv_emp.Rows[area].Cells[0].Value.ToString();
            txt_empname.Text = dgv_emp.Rows[area].Cells[1].Value.ToString();
            txt_empsname.Text = dgv_emp.Rows[area].Cells[2].Value.ToString();
            txt_empfin.Text = dgv_emp.Rows[area].Cells[3].Value.ToString();
            txt_empphone.Text = dgv_emp.Rows[area].Cells[4].Value.ToString();
            txt_empadd.Text = dgv_emp.Rows[area].Cells[5].Value.ToString();
            dtp_empbirth.Text = dgv_emp.Rows[area].Cells[6].Value.ToString();
            cb_empposid.Text = dgv_emp.Rows[area].Cells[7].Value.ToString();
            txt_email.Text = dgv_emp.Rows[area].Cells[8].Value.ToString();
            txt_pass.Text = dgv_emp.Rows[area].Cells[9].Value.ToString();
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

        private void icn_clear_Click(object sender, EventArgs e)
        {
            txt_empname.Text = "";
            txt_empsname.Text = "";
            txt_empid.Text = "";
            txt_empfin.Text = "";
            txt_empadd.Text = "";
            cb_empposid.Text = "";
            txt_email.Text = "";
            txt_pass.Text = "";
            txt_empphone.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_empid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_fin_Click(object sender, EventArgs e)
        {

        }

        private void txt_empfin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_empsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_sname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void txt_empphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_empposid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtp_empbirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_bday_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pos_Click(object sender, EventArgs e)
        {

        }

        private void txt_empadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_empname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_add_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void dgv_pos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
