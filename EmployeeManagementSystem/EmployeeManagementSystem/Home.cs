using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Home : Form
    {
        //static IniFile ini2 = new IniFile("detailsHome.ini");
        //static string language = GetLanguage();

        public Home()
        {
            InitializeComponent();
        }


        //ResourceManager rm = new ResourceManager("EmployeeManagementSystem." + language, Assembly.GetExecutingAssembly());


        //public static string GetLanguage()
        //{
        //    string dil = "";
        //    try
        //    {
        //        dil = ini2.Read("Language");

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    string lang = "az";
        //    switch (dil)
        //    {
        //        case "az": lang = "az"; break;
        //        case "en": lang = "en"; break;
        //        default: lang = "az"; break;

        //    }
        //    //MessageBox.Show(lang);
        //    return lang;
        //    //throw new NotImplementedException();
        //}
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

        private void lbl_heading_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            switch (LangCommon.GetLanguage())
            {
                case "az": cmbox_dil.SelectedIndex = 0; break;
                case "en": cmbox_dil.SelectedIndex = 1; break;
                default: cmbox_dil.SelectedIndex = 0; break;
            }
            lbl_heading.Text = LangCommon.rm.GetString("lbl_heading");
            btn_emp.Text = LangCommon.rm.GetString("btn_emp");
            btn_dep.Text = LangCommon.rm.GetString("btn_dep");

            btn_salary.Text = LangCommon.rm.GetString("btn_salary");


        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            //string last_lang = "";
            //switch (cmbox_dil.SelectedItem.ToString())
            //{
            //    case "Az": last_lang = "az"; break;
            //    case "Eng": last_lang = "en"; break;
            //    default: last_lang = "az"; break;
            //}
            //ini2.Write("Language", last_lang);

            //Application.Restart();
        }
    }
}
