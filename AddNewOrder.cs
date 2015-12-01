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
    public partial class AddNewOrder : Form
    {
        private static int ORDERDETAILID;
        private static int FOODITEMID;
        private static string  FOODITEMNAME;
        private static double FOODUNITPRICE;
        private static string CUSTOMERNAME;

            public static string customername{
                get{return CUSTOMERNAME;}
                set{CUSTOMERNAME=value;}

            }

        public static int fooditemid
        {
            get { return FOODITEMID; }
            set { FOODITEMID = value; }
        }
        public static string fooditemname
        {
            get { return FOODITEMNAME; }
            set { FOODITEMNAME = value; }
        }
        public static double foodunitprice
        {
            get { return FOODUNITPRICE; }
            set { FOODUNITPRICE = value; }
        }


        public static int orderdetailid
        {
            get { return ORDERDETAILID; }
            set { ORDERDETAILID = value; }
        }
        public AddNewOrder()
        {
            InitializeComponent();
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            Addneworder_orderid.Text = od.orderid.ToString();

            /*GetOrderDetailid();
            ChecksGetOrderDetailid();*/
         
            getCategoriesnames();
        }

        public void getCategoriesnames()
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "Select Categories.CategoryName from Categories";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {

                while (sd.Read())
                {
                    AddNewOrder_Category.Items.Add(sd.GetString(0));

                }

            }
            sd.Close();
            con.Close();


        }

        public void getItemsnameWithrespecttoCategoryname()
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string temp = AddNewOrder_Category.Text;
                                                                                                                                                /*UserName = '" + username + "' */
            string query = "select FoodItems.ItemName from Categories inner join FoodItems on Categories.CategoryID=FoodItems.CategoryId where Categories.CategoryName='"+temp+"'";     
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                AddNewOrder_Items.Items.Clear();
                while (sd.Read())
                {
                   
                    AddNewOrder_Items.Items.Add(sd.GetString(0));


                }

                       }
            sd.Close();
            con.Close();
            
        }
        private void AddNewOrder_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItemsnameWithrespecttoCategoryname();
        }

        public void CalclulatingAmount()
        {
            try
            {
                double price = 0;
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();
                string category = AddNewOrder_Category.Text;
                string item = AddNewOrder_Items.Text;
                string query = "select FoodItems.UnitPrice from FoodItems inner join Categories on Categories.CategoryID=FoodItems.CategoryId where Categories.CategoryName='" + category + "' and FoodItems.ItemName='" + item + "'";
                SqlCommand sc = new SqlCommand(query, con);
                SqlDataReader sd = sc.ExecuteReader();
                if (sd.HasRows)
                {

                    while (sd.Read())
                    {
                        price = sd.GetDouble(0);

                    }

                }

                if (AddNeworder_Quantity.Text == "")
                 {
                     AddnewOrder_Amount.Text = "0";

                 }
                double temp = price * Convert.ToDouble(AddNeworder_Quantity.Text);
                AddnewOrder_Amount.Text = temp.ToString();



            }catch(Exception ex){
                Console.WriteLine(ex.Message.ToString());
            }
        

    }

        private void AddNewOrder_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddNeworder_Quantity_TextChanged(object sender, EventArgs e)
        {
         
                CalclulatingAmount();
               
            
        }

        private void AddnewOrder_Amount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetails od = new OrderDetails();
            this.Hide();
            od.Show();
        }
        
     /*   public static void GetOrderDetailid()
        {


            SqlConnection connection = new SqlConnection(Program.CONSTR);
            connection.Open();
            string query = "select OrderDetails.OrderDetailId from OrderDetails";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            int count = 0;//
            while (dr.Read())
            {
                count++;
            }
            if (count == 0)
                ORDERDETAILID = 1;
            else
                ORDERDETAILID = count + 1;
            dr.Close();
            connection.Close();

        }

        public void ChecksGetOrderDetailid()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Program.CONSTR);
                connection.Open();
                string query = "select OrderDetails.OrderDetailId from OrderDetails";
                SqlCommand sc = new SqlCommand(query, connection);
                SqlDataReader sd = sc.ExecuteReader();
                if (sd.HasRows)
                {

                    while (sd.Read()) { 
                    if(orderdetailid==sd.GetInt32(0)){
                        ORDERDETAILID = ORDERDETAILID + 1;

                    }
                    
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/

        public void getitemid_name_unitprice()
        {
            //select FoodItems.ItemID,FoodItems.ItemName,FoodItems.UnitPrice from FoodItems where FoodItems.ItemName='brownie'
            try
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();
                string query ="select FoodItems.ItemID,FoodItems.ItemName,FoodItems.UnitPrice from FoodItems where FoodItems.ItemName='"+AddNewOrder_Items.Text+"'";
                SqlCommand sc = new SqlCommand(query, con);
                SqlDataReader sd = sc.ExecuteReader();
                if (sd.HasRows)
                {
                    while (sd.Read())
                    {
                        FOODITEMID = sd.GetInt32(0);
                        FOODITEMNAME = sd.GetString(1);
                        FOODUNITPRICE = sd.GetDouble(2);


                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddtoOrderList();
        }

        public void GetCustomername(int ORDERID)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select distinct OrderDetails.Name from OrderDetails inner join Orders on OrderDetails.OrderId = Orders.OrderId where OrderDetails.OrderId=" + ORDERID;
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    CUSTOMERNAME = sd.GetString(0);


                }


            }

        }
        public void AddtoOrderList()
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();
                OrderDelivered od = new OrderDelivered();
                int ORDERID = od.orderid; //is se orderid ayegi
                GetCustomername(ORDERID); //is se customer name ayega
                getitemid_name_unitprice();// is se 3 chezen ayegi
               /* GetOrderDetailid();
                ChecksGetOrderDetailid();*/
                int ORDERDETAILID = orderdetailid;//is se order detail id ayegi

                int QUANTITY = int.Parse(AddNeworder_Quantity.Text); //is se quantity ajagi
                double TOTALPRICE = double.Parse(AddnewOrder_Amount.Text); // is se total price ajaig
                //"INSERT INTO TIMINGS(Id, CheckInTime, CheckOutTime, Date) Values(" + teacherId.Text + ",'" + varCheckIn + "','" + varCheckOut + "','" + date.Text + "')";
                string query = "INSERT INTO OrderDetails( OrderId ,Name,Itemid,ItemName,UnitPrice,Quantity,TotalPrice ) Values (" + ORDERID + " , '" + customername + "' , " + fooditemid + "  ,'" + fooditemname + "' , " + foodunitprice + " , " + QUANTITY + " ," + TOTALPRICE + ")";
               
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }

        }
    
    }
}
