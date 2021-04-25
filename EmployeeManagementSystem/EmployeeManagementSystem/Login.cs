using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            CheckRemember();
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand cmd;
        XmlReader xmlr;
        string email = "";
        string pass = "";
        int admin_id;

        IniFile ini = new IniFile("remember.ini");

        private void CheckRemember()
        {
            if (!File.Exists("remember.ini"))
            {
                var file = File.Create("remember.ini");
                file.Close();
            }
        }

        private bool isEmailValid(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                if (ma.Address == email)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }

        XmlWriter xml;

        private void SaveLogin()
        {
            xml = XmlWriter.Create("login.xmlr");
            xml.WriteStartDocument();
            xml.WriteStartElement("Login");
            xml.WriteElementString("email", txt_email.Text);
            xml.WriteElementString("pass", txt_password.Text);
            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Close();
        }

        private void DontSaveLogin()
        {
            xml = XmlWriter.Create("login.xmlr");
            xml.WriteStartDocument();
            xml.WriteStartElement("Login");
            xml.WriteElementString("email", "");
            xml.WriteElementString("pass", "");
            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Close();
        }

        Home home = new Home();

        private void Login_Load(object sender, EventArgs e)
        {
            CheckForUpdate();

            if (checkBox_rem.Checked)
            {
                if (GetLogin())
                {
                    checkBox_rem.Checked = true;
                }

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            email = txt_email.Text;
            pass = txt_password.Text;

            if (CheckExist())
            {
                if (checkBox_rem.Checked == false)
                {
                    DontSaveLogin();
                    checkBox_rem.Checked = false;
                    home.Show();
                    this.Hide();
                }
                else
                {
                    home.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Yanlış şifrə və ya email!");
            }

        }
        private bool CheckExist()
        {
            try
            {
                connection = Connect();
                if (connection.State == ConnectionState.Broken)
                    connection.Open();


                string query = "SELECT AdminId FROM AdminTbl where Mail='" + email + "'AND Password='" + pass + "';";

                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                int row_count = 0;

                while (reader.Read())
                {
                    admin_id = reader.GetInt32(0);
                    row_count++;
                }

                if (row_count == 1)
                {
                    return true;
                }
                else
                {


                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }

        SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRCMF6O;Initial Catalog=EmployeeDBS;Integrated Security=True");
            con.Open();
            return con;
        }

        private bool GetLogin()
        {

            try
            {
                if (!File.Exists("login.xmlr"))
                {
                    var file = File.Create("login.xmlr");
                    file.Close();

                }

                xmlr = XmlReader.Create("login.xmlr");
                while (xmlr.Read())
                {
                    if (xmlr.IsStartElement())
                    {
                        switch (xmlr.Name.ToString())
                        {
                            case "email": txt_email.Text = xmlr.ReadString(); break;
                            case "pass": txt_password.Text = xmlr.ReadString(); break;
                        }
                    }
                }
                xmlr.Close();
                return true;
            }
            catch
            {
                xmlr.Close();
                checkBox_rem.Checked = false;
                return false;
            }

        }

        private void checkBox_rem_CheckedChanged(object sender, EventArgs e)
        {
            CheckRemember();
            ini.Write("CheckForUpdate", checkBox_rem.Checked.ToString());

            if (checkBox_rem.Checked)
            {
                email = txt_email.Text;
                pass = txt_password.Text;
                if (CheckExist())
                {
                    SaveLogin();
                }
                else
                {

                }

            }
            else
            {
                DontSaveLogin();

            }
        }

        private void icn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CheckForUpdate()
        {
            string checkeds = ini.Read("CheckForUpdate");
            if (checkeds == "True")
            {
                checkBox_rem.Checked = true;
            }
            else
            {
                checkBox_rem.Checked = false;
            }
        }

        private void lbl_forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isEmailValid(txt_email.Text))
            {
                MessageBox.Show("Düzgün email daxil edin!");
                return;
            }
            RecoverPassword m = new RecoverPassword(txt_email.Text);
            this.Hide();
            m.Show();
        }

        private void checkBox_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pass.Checked)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }
    }
}
