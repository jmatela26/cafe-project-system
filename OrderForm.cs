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

namespace BintanaSystem
{
    public partial class OrderForm : Form
    {
        string connectAddress = DBConnection.getAddress();
        int orderNo, delItem=1,row=0;
        string username;


        public OrderForm(int ordNo)
        {
            InitializeComponent();
            orderNo = ordNo;

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            OrderList orderForm = new OrderList(orderNo,1);
            this.Hide();
            orderForm.ShowDialog();
            this.Close();
        }

        private void Btn_Place_Click(object sender, EventArgs e)
        {
            string statCheck;
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand check = new SqlCommand("SELECT Status FROM CurrentTable WHERE TableNo = " + cmboBox_TableNo.Text, con);
            SqlCommand com = new SqlCommand("UPDATE CurrentTable SET Order_No = " + orderNo.ToString() 
                + ", Status = 'Pending', Time_In = '" + DateTime.Now.ToLongTimeString() + "' WHERE TableNo = " + cmboBox_TableNo.Text, con);


            if (cmboBox_TableNo.Text != "")
            {
                con.Open();
                statCheck = (String)check.ExecuteScalar();

                if (statCheck == "Clear")
                {
                    com.ExecuteNonQuery();
                    con.Close();

                    
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This table is occupied!");
                    con.Close();
                }
            }
            else
                MessageBox.Show("Please enter table number to place the order");
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("DELETE FROM Orders WHERE Order_No = " + orderNo.ToString() + " AND Item_No = " + delItem.ToString(), con);
           
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            try
            {
                reOrder(delItem);
            }
            catch(Exception)
            {

            }

            OrderForm refresh = new OrderForm(orderNo);
            this.Hide();
            refresh.ShowDialog();
            this.Close();
        }

        private void reOrder(int itemDeleted)
        {
            int nextNum;
            nextNum = itemDeleted;

            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand reorder = new SqlCommand("EXECUTE reorderList " + orderNo.ToString() + ", " + itemDeleted.ToString(),con);

            con.Open();
            reorder.ExecuteNonQuery();
            con.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand user = new SqlCommand("EXECUTE getUser", con);
            SqlDataAdapter ad = new SqlDataAdapter();

            con.Open();

            SqlCommand com = new SqlCommand("SELECT Quantity, Item_Description, PricePerItem, TotalAmount FROM Orders WHERE Order_No = " + orderNo, con);
            SqlCommand total = new SqlCommand("SELECT SUM(TotalAmount) FROM Orders WHERE Order_No = " + orderNo, con);
            txtBox_OrderNo.Text = orderNo.ToString();
            username = (String)user.ExecuteScalar();

            try
            {
                txtBox_Total.Text = "Php " + ((Decimal)total.ExecuteScalar()).ToString();
            }
            catch(Exception)
            {
                txtBox_Total.Text = "Php 0.00";
            }
            con.Close();
            
            txtBox_User.Text = username;


            ad.SelectCommand = com;
            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);
            dataGrid_Orders.DataSource = dataTable;
            ad.Update(dataTable);
            
            con.Close();
        }

        private void dataGrid_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;

            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand getItem = new SqlCommand("EXECUTE getItemNo " + orderNo.ToString() + ", "+ row.ToString(), con);

            con.Open();
            try
            {
                delItem = (Int32)getItem.ExecuteScalar();
            }
            catch(Exception)
            {
                MessageBox.Show("Error on deletion!");
            }
            con.Close();

        }

        private void cmboBox_TableNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
