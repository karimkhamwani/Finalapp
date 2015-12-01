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
    public partial class SearchByorderId : Form
    {
        public SearchByorderId()
        {
            InitializeComponent();
        }

        private void SearchByorderId_Load(object sender, EventArgs e)
        {

        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            od.orderid = int.Parse(SearchByorderid_EnterOrderid.Text);
            ChecksOrderidValidorInvalid(od.orderid);
          
        }

        public void ChecksOrderidValidorInvalid(int Searchorderid)
        {
            int temp = 0;
            int count = 0;
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select Orders.OrderId from Orders";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    temp = sd.GetInt32(0);
                  if (temp == Searchorderid)
                {
                    OrderDelivered od = new OrderDelivered();
                    od.orderid = int.Parse(SearchByorderid_EnterOrderid.Text);
                    OrderDetails OR = new OrderDetails();
                    this.Hide();
                    OR.Show();
                    count = 1;
                  


                }
                  


                }
                if (count==0) {
                    MessageBox.Show("Order Id not Founded");
                }
                
               


            }

        }

        private void button1_Click(object sender, EventArgs e)
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

    }
}
