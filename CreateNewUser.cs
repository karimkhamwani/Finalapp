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
namespace FlamingoWF
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        public void NewUser()
        {
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "Insert into login(Name,Password,Email,Role) values ('" + CreateNewuser_name.Text + "' , '" + CreateNewuser_Password.Text + "' , '" + CreateNewuser_Email.Text + "', '" + CreateNewuser_Role.Text + "')";
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User added Sucessfully");

        }

        public void adminConfirmation()
        
        {
            string name = null;
            string password = null;
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "select Login.Name , Login.Password from Login where Login.Role='Admin'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    name = sd.GetString(0);
                    password = sd.GetString(1);


                }

            }
            if (name == Createnewuser_Adminusername.Text && password == CreateNewuser_Adminpassword.Text)
            {

                NewUser();
            }
            else
            {
                MessageBox.Show("Admin Authetication Failed Couldnt make New user");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminConfirmation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {

        }

    }
}
