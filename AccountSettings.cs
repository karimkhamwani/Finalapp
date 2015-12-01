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
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            credentials();
            Login l = new Login();
            string username = l.username;
            AccountSettings_name.Text = username;
             AccountSettings_Password.Text = l.password;
            setEmail(username);
            

        }
        public void credentials()
        {
            Login l1 = new Login();
            if (l1.role == "Regular")
            {
                
                staffToolStripMenuItem.Enabled = false;
            }

        }

        public void setEmail(string name)
        {
           
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string emailquery = "select [Login].Email from [Login] where [Login].Name='" + name + "'";
            SqlCommand sc = new SqlCommand(emailquery, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    AccountSettings_Email.Text = sd.GetString(0);
                   
                }
            }


        }
       
        public void Updateemail()
        {
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            Login l = new Login();
            string query = "update [Login] set Email= '"+AccountSettings_Email.Text+"' where [Login].Name='" + l.username + "'";
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
       
         
            
        }

       
        public void Renewpassword()
        {
            
            if (AccountSettings_Newpassword.Text == "" && AccountSettings_Retypepassword.Text == "")
            {
                

            }
            else
            {
                if (AccountSettings_Newpassword.Text == AccountSettings_Retypepassword.Text)
                {
                    Login l = new Login();
                    SqlConnection con = new SqlConnection(Program.FCONSTR);
                    con.Open();
                    string query = "update [Login] set [password]='" + AccountSettings_Newpassword.Text + "' where [Login].Name='" + l.username + "'";
                    SqlCommand sc = new SqlCommand(query, con);
                    sc.ExecuteNonQuery();
                
                    

                }
                else
                {
                    MessageBox.Show("Password doesnt match");
                }
               

            }
           
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updateemail();
            Renewpassword();
            MessageBox.Show("Update information Successfully");
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            this.Hide();
            f.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee a1 = new AddEmployee();
            a1.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee d1 = new DeleteEmployee();
            d1.Show();
        }

        private void orderInPendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderinpending op = new Orderinpending();
            this.Hide();
            op.Show();
        }

        private void orderDeliveredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDelivered Od = new OrderDelivered();
            this.Hide();
            Od.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

    }
}
