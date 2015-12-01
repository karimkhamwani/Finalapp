using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
namespace FlamingoWF{

    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            
       
         }
        private static string Username;
        private static string Password;
        private static string Role;
        public  string username
        {
            get { return Username; }
            set { value = Username; }
        }

        public string password
        {
            get { return Password; }
            set { value = Password; }
        }

        public string role
        {
            get { return Role; }
            set { value = Role; }

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            setRole();
            checkspassword();
           
               
        }
        public void setRole()
        {
            Role = Login_role.Text;

        }
        public void checkspassword()
        {
            string password = null;
            string userrole = null;
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "select [Login].[Password] , [login].Role from [login] where [Login].Name ='" + Login_username.Text + "' and [login].Role='"+Login_role.Text+"'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                  Username = Login_username.Text;
                    password = sd.GetString(0);
                    userrole = sd.GetString(1);
                }


            }
            if (Login_password.Text == password && Login_role.Text==userrole)
            {
                Password= Login_password.Text; 
                Main m = new Main();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Invalid Authorization");
            }
        }
       
       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordButton_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            this.Hide();
            fp.Show();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            CreateNewUser cn = new CreateNewUser();
            this.Hide();
            cn.Show();
        }

        
        
    }
}
