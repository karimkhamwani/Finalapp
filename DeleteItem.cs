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
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            int orderid= od.orderid;
            GetItemsDetails(orderid);
           
        }
        public void GetItemsDetails(int ORDERID)
        {

            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select OrderDetails.OrderDetailId ,Categories.CategoryName , FoodItems.ItemName ,FoodItems.UnitPrice as Price, OrderDetails.Quantity from Orders inner join OrderDetails on Orders.OrderId=OrderDetails.OrderId inner join FoodItems on FoodItems.ItemID=OrderDetails.ItemId inner join Categories on Categories.CategoryID = FoodItems.CategoryId where OrderDetails.OrderId =" + ORDERID;

            SqlCommand sc = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }

        public void FetchingOrderDetailid(int ORDERID)
        {
            int count = 0;

            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select OrderDetails.OrderDetailId from OrderDetails where OrderDetails.OrderId =" + ORDERID;
           
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {

                while (sd.Read())
                {
                    string temp = sd.GetInt32(0).ToString() ;
                
                    try
                    {
                        if (temp == Deleteitem_EnterId.Text)
                        {
                            SqlConnection con1 = new SqlConnection(Program.CONSTR);
                            con1.Open();
                            string query1 = "DELETE from OrderDetails where OrderDetails.OrderDetailId=" + temp;
                            SqlCommand sc1 = new SqlCommand(query1, con1);
                            sc1.ExecuteNonQuery();
                            con1.Close();
                            MessageBox.Show("Delete Sucuessfully");
                            count = 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }


                } 

            }
            if (count == 0)
            {
                MessageBox.Show("Order detail id invalid");
            } 
            sd.Close();
            con.Close();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            int orderid = od.orderid;
            FetchingOrderDetailid(orderid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetails od = new OrderDetails();
            this.Hide();
            od.Show();
        }
    }
}
