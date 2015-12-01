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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            credentials();
            setfeedback();
          
        }

        public void credentials()
        {
            Login l1 = new Login();
            if (l1.role == "Regular")
            {
                ViewAttendence.Enabled = false;
                button6.Enabled = false;
                MaintainAttendence.Enabled = false;
                staffToolStripMenuItem.Enabled = false;
            }

        }
       

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee a1 = new AddEmployee();
            a1.Show();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee d1 = new DeleteEmployee();
            d1.Show();
        }

        private void updateEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void orderInProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDelivered o1 = new OrderDelivered();
            o1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Orderinpending op = new Orderinpending();
            this.Hide();
            op.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            this.Hide();
            od.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchByorderId search = new SearchByorderId();
            this.Hide();
            search.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            this.Hide();
            ae.Show();
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void markAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence a1 = new Attendence();
            a1.Show();
        }

        private void viewAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            ViewAttendence va = new ViewAttendence();
            va.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewAttendence va = new ViewAttendence();
            
            va.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attendence a = new Attendence();
            this.Hide();
            a.Show();
        }
        public void setfeedback()
        {
            int count = 0;
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select * from FeedBacks";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    count++;


                }

            }
           
            var rdn = new Random();
            int frist = rdn.Next(count);
            textBox1.Text =getfeedback(frist);
            int second = rdn.Next(count);
            textBox2.Text= getfeedback(second);
            int thrid = rdn.Next(count);
            textBox3.Text = getfeedback(thrid);
            int foruth = rdn.Next(count);
            textBox4.Text = getfeedback(count);



        }

        public string getfeedback(int rdn)
        {
                string a=null;
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select FeedBacks.Comments from FeedBacks where FeedBackId=" + rdn;
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                     a = sd.GetString(0);
                }

            }
            return a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AccountSettings ass = new AccountSettings();
            this.Hide();
            ass.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
        
    }
}
