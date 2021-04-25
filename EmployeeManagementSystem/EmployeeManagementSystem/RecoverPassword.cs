using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class RecoverPassword : Form
    {
        public RecoverPassword(string email)
        {
            InitializeComponent();
            txt_email.Text = email;

        }

        string email = "";
        SqlConnection con;
        SqlCommand cmd;
        int admin_id = 0;

        private int RandomNumber()
        {
            Random r = new Random();
            return r.Next(100000, 999999);
        }

        SqlConnection Connect()
        {
            string conString = @"Data Source=DESKTOP-NRCMF6O;Initial Catalog=EmployeeDBS;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }

        private void RecoverPassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            email = txt_email.Text;
            con = Connect();
            if (con.State == ConnectionState.Broken)
                con.Open();

            string query = "SELECT AdminId FROM AdminTbl WHERE Mail = '" + email + "';";
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int row_count = 0;

            while (dr.Read())
            {
                admin_id = dr.GetInt32(0);

                row_count++;
            }

            if (row_count == 1)
            {
                int randomcode = RandomNumber();
                if (mailSender(randomcode))
                {
                    MessageBox.Show("Yeniləmə kodu " + email + " ünvanına göndərildi!");
                }
                else
                {
                    MessageBox.Show("Yeniləmə kodu göndərilmədi!");

                }
            }

            else
                MessageBox.Show("İstifadəçi tapılmadı!");
        }

        private bool mailSender(int code)
        {
            try
            {
                string from = "komputermuhendisliyi3@gmail.com";
                string pass = "km@12345678";
                string to = txt_email.Text;
                string bodyText = "<h3>Şifrə yeniləmə kodunuz: <b>" + code + "</b></h3>";

                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(from, "Şifrə Yeniləmə");
                mm.To.Add(new MailAddress(to));
                mm.Subject = "Employee Management System";
                mm.IsBodyHtml = true;
                mm.Body = bodyText;

                NetworkCredential nc = new NetworkCredential();
                nc.UserName = from;
                nc.Password = pass;

                SmtpClient sc = new SmtpClient();
                sc.Host = "smtp.gmail.com";
                sc.Port = 587;
                sc.EnableSsl = true;
                sc.UseDefaultCredentials = false;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.Credentials = nc;
                sc.Send(mm);

                writeCodeToDatabase(code);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool writeCodeToDatabase(int code)
        {
            try
            {
                con = Connect();

                string date = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now.AddMinutes(15));
                string sorgu = "INSERT INTO AdminKod (AdminId, Date, Code) VALUES (" + admin_id + ",'" + date + "'," +
                    code + ");";
                cmd = new SqlCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (checkIfCodeValid(txt_code.Text))
            {
                MessageBox.Show("Kod Təsdiqləndi!");
                pnl_code.Visible = false;
                pnl_password.Visible = true;
            }
            else

            {
                MessageBox.Show("Xəta baş verdi! Daha sonra yenidən cəhd edin!");
            }
        }

        private bool checkIfCodeValid(string Code)
        {
            try
            {
                con = Connect();
                string codeFromEmail = txt_code.Text.Trim();

                string query = "SELECT Date FROM AdminKod WHERE AdminId=" + admin_id +
                    " AND Code='" + codeFromEmail + "';";

                cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                string tarix = "";

                int row_count = 0;

                while (dr.Read())
                {
                    tarix = dr.GetValue(0).ToString();
                    row_count++;

                }

                if (row_count == 1)
                {
                    DateTime code_resettime = DateTime.Parse(tarix);
                    TimeSpan ts = code_resettime - DateTime.Now;

                    if (ts.Minutes < 0)
                    {
                        MessageBox.Show("Kodun müddəti bitib", "Daha sonra yenidən cəhd edin!");
                        return false;
                    }
                    else
                        return true;

                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                return false;
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((txt_newpass.Text != txt_newpassconf.Text) || txt_newpassconf.Text.Trim().Length < 8 || txt_newpass.Text.Trim().Length < 8)
            {
                MessageBox.Show("Şifrələr eyni deyil və ya 8 simvoldan kiçikdir!");
                return;
            }
            else
            {

                con = Connect();
                string sorgu = "UPDATE AdminTbl SET Password = '" + txt_newpass.Text + "'" +
                    " WHERE AdminId =" + admin_id + ";";
                cmd = new SqlCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifrə uğurla yeniləndi!");
            }
        }

        private void icn_back_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void icn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_confirm_Click_1(object sender, EventArgs e)
        {
            if (checkIfCodeValid(txt_code.Text))
            {
                MessageBox.Show("Kod Təsdiqləndi!");
                pnl_code.Visible = false;
                pnl_password.Visible = true;
            }
            else

            {
                MessageBox.Show("Xəta baş verdi! Daha sonra yenidən cəhd edin!");
            }
        }
    }
}
