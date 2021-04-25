using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
            this.Hide();
        }

        private void ixn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void icn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Əminsiniz?", "ÇIXIŞ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            Salary slr = new Salary();
            slr.Show();
            this.Hide();
        }
    }
}
