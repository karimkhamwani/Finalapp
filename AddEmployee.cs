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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployee();
        }
        public void addEmployee()//add new employee to database
        {
            try { 
            SqlConnection con = new SqlConnection(Program.FCONSTR);
            con.Open();
            //string query = "INSERT INTO TIMINGS(Id, CheckInTime, CheckOutTime, Date) 
            //Values (" + teacherId.Text + ",'" + varCheckIn + "','" + varCheckOut + "','" + date.Text + "')";
            string query = "Insert into Employee(EmployeeName,EmployeePhonenumber,EmployeeNic,EmployeeAddress,EmployeeAge,EmployeeDateofJoining ) Values ('" + AddEmployee_name.Text + "' ,'"+AddEmployee_Phonenumber.Text+"' , '"+AddEmployee_NIC.Text+"' ,'"+AddEmployee_Address.Text+"' , '"+AddEmployee_age.Value+"' , '"+AddEmployee_Dateofjoining.Value+"')";
       
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

       
        
    }
}
