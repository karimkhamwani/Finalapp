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
    public partial class OrderDetails : Form
    {
        /*private static int temp=0;
        public int TEMP{
            get { return temp; }
            set { temp = value; }

        }*/
        public void credentials()
        {
            Login l1 = new Login();
            if (l1.role == "Regular")
            {
              
                staffToolStripMenuItem.Enabled = false;
            }

        }
     

        
        public OrderDetails()
        {
            InitializeComponent();
         
           
            
        }
        public void GetTotalPrice(int ORDERID)
        {
            try
            {
                int temp = 0;
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();
                string query = "select SUM(OrderDetails.TotalPrice) from OrderDetails where OrderDetails.OrderId=" + ORDERID;
                SqlCommand sc = new SqlCommand(query, con);
                SqlDataReader sd = sc.ExecuteReader();
                if (sd.HasRows)
                {
                    while (sd.Read())
                    {
                        temp = Convert.ToInt32(sd.GetDouble(0));
                        if (temp == 0)
                        {
                            TotalPriceValueZero(ORDERID);
                        }
                        else
                        {
                            UpdateTables(temp, ORDERID);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void UpdateTables(int z, int O)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "UPDATE Orders Set GrandTotal=" + z + " where Orders.OrderId=" + O;
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();


        }
        public void TotalPriceValueZero(int o)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "UPDATE Orders Set GrandTotal=" + 0 + " where Orders.OrderId=" + o;
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();

        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            credentials();
            OrderDelivered n = new OrderDelivered();
            int Orderid = n.orderid;
           GetCustomerdetails(Orderid);
           GetItemsDetails(Orderid);
        
           Gettotalwithrespectivetoquantity(Orderid);
          GetTotalPrice(Orderid);
          
            
        }

        public void GetCustomerdetails(int ORDERID)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();
                string query = "Select * from Orders where OrderID = " + ORDERID;
                SqlCommand sc = new SqlCommand(query, con);
                SqlDataReader sd = sc.ExecuteReader();
                if (sd.HasRows)
                {
                    while (sd.Read())
                    {
                        OD_name.Text = sd.GetString(2);
                        Phonenumber.Text = sd.GetString(3);
                        Email.Text = sd.GetString(4);
                        Address.Text = sd.GetString(5);
                        OrderDetails_Orderid.Text = sd.GetInt32(0).ToString();
                        OrderDetails_Orderdate.Text = sd.GetDateTime(1).ToString();
                        Orderdetails_area.Text = sd.GetString(6);
                        status.Text = sd.GetString(11);
                        Orderin.Text = sd.GetString(8);

                    }
                }
                sd.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        public void GetItemsDetails(int ORDERID)
        {

            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select Categories.CategoryName , FoodItems.ItemName ,FoodItems.UnitPrice as Price, OrderDetails.Quantity from Orders inner join OrderDetails on Orders.OrderId=OrderDetails.OrderId inner join FoodItems on FoodItems.ItemID=OrderDetails.ItemId inner join Categories on Categories.CategoryID = FoodItems.CategoryId where OrderDetails.OrderId = "+ ORDERID;

            SqlCommand sc = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }



        public void Gettotalwithrespectivetoquantity(int ORDERID)
        {
           int temp=0;
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select OrderDetails.UnitPrice as price , OrderDetails.Quantity from OrderDetails where OrderDetails.OrderId=" + ORDERID;
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    temp = Convert.ToInt32( temp + (sd.GetDouble(0) * sd.GetInt32(1)));

                }

            }
            OrderDetails_totalamount.Text = temp.ToString(); 
        }

        public void SetStatusOfItemdelivered(int ORDERID)
        {
           
            string status = Orderin.Text;
          
            //string value = OrderDetails_status.SelectedValue.ToString();
           if (status == "Item Delivered")
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();

                string query = "UPDATE Orders Set HasBeenProcessed='true' where Orders.OrderId=" + ORDERID;
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
               // MessageBox.Show("You have changed Status of Orderid :" + ORDERID.ToString() + " to " + status, "OrderDetails");

            }}
           
        public void SetStatusOfIteminPending(int ORDERID){
               string status = Orderin.Text;
        if (status == "Item in pending")
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();

                string query = "UPDATE Orders Set HasBeenProcessed='false' where Orders.OrderId=" + ORDERID;
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
              //  MessageBox.Show("You have changed Status of Orderid :" + ORDERID.ToString()+" to "+status, "OrderDetails");

            }}

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            OrderDelivered n = new OrderDelivered();
            int Orderid = n.orderid;
            SetStatusOfItemdelivered(Orderid);
            SetStatusOfIteminPending(Orderid);
            setOrderStatus(Orderid);
            SetComments(Orderid);
            MessageBox.Show("Changes Successfully made ");
           

        }

        public void SetComments(int ORDERID)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string temp = OrderDetails_Comments.Text;
            //"INSERT INTO TIMINGS(Id, CheckInTime, CheckOutTime, Date) Values (" + teacherId.Text + ",'" + varCheckIn + "','" + varCheckOut + "','" + date.Text + "')";
            string query = "Update Orders Set Comments = '" + temp + "' where Orders.OrderId=" + ORDERID;
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();
          



        }

        public void setOrderStatus(int ORDERID)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string temp = status.Text;
            //"INSERT INTO TIMINGS(Id, CheckInTime, CheckOutTime, Date) Values (" + teacherId.Text + ",'" + varCheckIn + "','" + varCheckOut + "','" + date.Text + "')";
            string query = "Update Orders Set Status = '" + temp + "' where Orders.OrderId=" + ORDERID;
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();
          

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
          }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteItem di = new DeleteItem();
            this.Hide();
            di.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddNewOrder a1 = new AddNewOrder();
            this.Hide();
            a1.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback fb = new Feedback();
            this.Hide();
            fb.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            this.Hide();
            ae.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee de = new DeleteEmployee();
            this.Hide();
            de.Show();
        }

        private void markAttendeceToolStripMenuItem_Click(object sender, EventArgs e)
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







    

        

