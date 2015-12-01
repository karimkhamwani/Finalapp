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
using System.Net.Mail;
namespace FlamingoWF
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkspassword();
        }
        public void checkspassword()
        {

            string username = null;
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "select [Login].Name from Login where Login.Name='" + Forgetpassword_username.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                   username = sd.GetString(0);

                }
                

            }
            if (Forgetpassword_username.Text==username)
            {
                forgetpassword();

            }
            else
            {
                MessageBox.Show("Username not Exists");
            }


        }
        public void sendingEmail(string a)
        {
            SmtpClient Smtp_Server = new SmtpClient();
            MailMessage e_mail = new MailMessage();
            Smtp_Server.UseDefaultCredentials = true;
            Smtp_Server.Credentials = new System.Net.NetworkCredential("karim.liaquat@gmail.com", "karim12345");
            Smtp_Server.Port = 587;
            Smtp_Server.EnableSsl = true;
            Smtp_Server.Host = "smtp.gmail.com";

            e_mail = new MailMessage();
            e_mail.From = new MailAddress("karim.liaquat@gmail.com");
            e_mail.To.Add(a);
            e_mail.Subject = "Password Recovery for Flamingo";
            e_mail.IsBodyHtml = false;

            e_mail.Body = string.Format("Your new Password is Flamingo12345");
            Smtp_Server.Send(e_mail);

            MessageBox.Show("New Password is send to your EmailAddress try to changing password time to time");
        }

        public void forgetpassword()
        {
            string email = null;
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string emailquery = "select [Login].Email from [Login] where [Login].Name='" + Forgetpassword_username.Text + "'";
            SqlCommand sc = new SqlCommand(emailquery, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {

                    email = sd.GetString(0);
                    sendingEmail(email);
                    updatepasswordinlogin();    
                }
            }
        }


        public void updatepasswordinlogin()
        {
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "update [Login] set [password]='Flamingo12345' where [Login].Name='" + Forgetpassword_username.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();   
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
    }
}
