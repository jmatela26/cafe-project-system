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
    public partial class OrderEdit : Form
    {
        string connectAddress = DBConnection.getAddress();
        int orderNo, delOrder, delItem = 99, row = 1, tableNo;

        public OrderEdit(int ordNo, int tblNo)
        {
            InitializeComponent();
            orderNo = ordNo;
            delOrder = ordNo;
            tableNo = tblNo;
        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            delItem = 1;

            string username;
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand user = new SqlCommand("EXECUTE getUser", con);
            SqlDataAdapter ad = new SqlDataAdapter();

            con.Open();
            SqlCommand total = new SqlCommand("SELECT SUM(TotalAmount) FROM Orders WHERE Order_No = " + orderNo, con);
            SqlCommand com = new SqlCommand("SELECT Quantity, Item_Description, PricePerItem, TotalAmount FROM Orders WHERE Order_No = " + orderNo, con);

            username = (String)user.ExecuteScalar();
            try
            {
                txtBox_Total.Text = "Php " + ((Decimal)total.ExecuteScalar()).ToString();
            }
            catch (Exception)
            {
                txtBox_Total.Text = "Php 0.00";
            }
            con.Close();

            txtBox_User.Text = username;
            txtBox_TableNo.Text = tableNo.ToString();
            txtBox_OrderNo.Text = orderNo.ToString();

            ad.SelectCommand = com;
            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);
            dataGrid_Orders.DataSource = dataTable;
            ad.Update(dataTable);

            con.Close();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            OrderList orderForm = new OrderList(orderNo,2);
            this.Hide();
            orderForm.ShowDialog();
            this.Close();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Tables tableForm = new Tables();

            this.Hide();
            tableForm.ShowDialog();
            this.Hide();
        }

        private void Btn_Paid_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("EXECUTE clearTable " + tableNo.ToString(), con);
            SqlDataAdapter trans = new SqlDataAdapter();
            trans.InsertCommand = new SqlCommand("INSERT INTO Record(OrderNo,Table_No,Total_Amount,User_Assigned,Time_In,Time_Out,Date_Recorded) VALUES (@ordNo,@tableNo,@totalAmount,@user,@timeIn,@timeOut,@date)", con);
            
            trans.InsertCommand.Parameters.Add("@ordNo", SqlDbType.Int).Value = orderNo;
            trans.InsertCommand.Parameters.Add("@tableNo", SqlDbType.Int).Value = tableNo;
            trans.InsertCommand.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = getTotalAmount(orderNo);
            trans.InsertCommand.Parameters.Add("@user", SqlDbType.VarChar).Value = getUser();
            trans.InsertCommand.Parameters.Add("@timeIn", SqlDbType.VarChar).Value = getTimeIn(orderNo);
            trans.InsertCommand.Parameters.Add("@timeOut", SqlDbType.VarChar).Value = DateTime.Now.ToLongTimeString();
            trans.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTime.Today.ToLongDateString();
            
            con.Open();
            trans.InsertCommand.ExecuteNonQuery();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Table " + tableNo.ToString() + " is paid for. Table is now free.");

            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        public decimal getTotalAmount(int ordNo)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("SELECT SUM(TotalAmount) FROM Orders WHERE Order_No = " + orderNo.ToString(), con);

            con.Open();
            decimal dec = (Decimal)com.ExecuteScalar();
            con.Close();
            return dec;
            
            
        }

        public string getTimeIn(int ordNo)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("SELECT Time_In FROM CurrentTable WHERE TableNo = " + tableNo.ToString(),con);

            con.Open();
            string str = (String)com.ExecuteScalar();
            return str;
            
        }
        public string getUser()
        {
            string ret;
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("EXECUTE getUser", con);

            con.Open();
            ret = (String)com.ExecuteScalar();
            con.Close();

            return ret;
        }

        private void Btn_OrderComplete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("EXECUTE orderComplete " + tableNo.ToString(),con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void dataGrid_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            catch (Exception)
            {

            }

            OrderEdit refresh = new OrderEdit(orderNo, tableNo);
            this.Hide();
            refresh.ShowDialog();
            this.Close();
        }

        private void reOrder(int itemDeleted)
        {
            int nextNum;
            nextNum = itemDeleted;

            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand reorder = new SqlCommand("EXECUTE reorderList " + orderNo.ToString() + ", " + itemDeleted.ToString(), con);

            con.Open();
            reorder.ExecuteNonQuery();
            con.Close();
        }

        private void dataGrid_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;

            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand getItem = new SqlCommand("EXECUTE getItemNo " + orderNo.ToString() + ", " + row.ToString(), con);

            con.Open();
            try
            {
                delItem = (Int32)getItem.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error on deletion!");
            }
            con.Close();
        }
    }
}
