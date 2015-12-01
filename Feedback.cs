using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlamingoWF
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }
        public void credentials()
        {
            Login l1 = new Login();
            if (l1.role == "Regular")
            {
               
                staffToolStripMenuItem.Enabled = false;
            }

        }

        private void Feedback_Load(object sender, EventArgs e)
            
        {
            credentials();
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet5.FeedBacks' table. You can move, or remove it, as needed.
            this.feedBacksTableAdapter1.Fill(this.websiteProjectFlamingoDataSet5.FeedBacks);
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet4.FeedBacks' table. You can move, or remove it, as needed.
            //this.feedBacksTableAdapter.Fill(this.websiteProjectFlamingoDataSet4.FeedBacks);

        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            this.Hide();
            f.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
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

        private void markAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence a1 = new Attendence();
            a1.Show();
        }

        private void viewAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAttendence va = new ViewAttendence();
            va.Show();
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
