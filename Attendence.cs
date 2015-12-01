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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }

        public void MaintainAttendence()
        {
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            string query = "select Employee.EmployeeId from Employee where Employee.EmployeeName= '" + Attendence_name.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    int temp = sd.GetInt32(0);
                    InsertintoAttendence(temp);


                }

            }



        }
        public void InsertintoAttendence(int temp)
        {

            SqlConnection con1 = new SqlConnection(Program.FCONSTR);
            con1.Open();
            string newquery = "insert into Attendence (fk_EmployeeId,[date],status,Name) values (" + temp + " ,'" + Attendence_date.Value + "' ,'" + Attendence_status.Text + "' ,'" + Attendence_name.Text + "')";

            SqlCommand sc1 = new SqlCommand(newquery, con1);
            sc1.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Insert sucuessfully");

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main M1 = new Main();
            M1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintainAttendence();
        }

        
    }
}
