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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.Show();
        }

        public void deleteEmployee()
        {
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "select Employee.EmployeeId from Employee where Employee.EmployeeName= '" + DeleteEmployee_name.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    int temp = sd.GetInt32(0);
                    insertintodeleteemployee(temp);
                   

                }
           
            }

        }
        public void insertintodeleteemployee(int temp)
        {

            SqlConnection con1 = new SqlConnection(Program.FCONSTR);
            con1.Open();
            string newquery = "insert into DeleteEmployee (fk_EmployeeId,[date],Reason,Name) values (" + temp + " ,'" + DeleteEmployee_date.Value + "' ,'" + DeleteEmployee_reason.Text + "' ,'" + DeleteEmployee_name.Text + "')";

            SqlCommand sc1 = new SqlCommand(newquery, con1);
            sc1.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Insert sucuessfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteEmployee();
        }
    }
}
