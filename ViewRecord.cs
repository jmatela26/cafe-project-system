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
    public partial class ViewRecord : Form
    {
        string connectAddress = DBConnection.getAddress();
        int recNo, ordNo;
        string user;
        DateTime date = new DateTime();

        public ViewRecord(int rec)
        {
            InitializeComponent();
            recNo = rec;
        }

        private void ViewRecord_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            
            SqlCommand com = new SqlCommand("SELECT OrderNo FROM Record WHERE Record_No = " + recNo.ToString(), con);
            SqlCommand getDate = new SqlCommand("SELECT Date_Recorded FROM Record WHERE Record_No = " + recNo.ToString(), con);

            con.Open();
            try
            {
                ordNo = (Int32)com.ExecuteScalar();

                SqlCommand userGet = new SqlCommand("SELECT User_Assigned FROM Orders WHERE Order_No = " + ordNo, con);
                SqlCommand total = new SqlCommand("SELECT SUM(TotalAmount) FROM Orders WHERE Order_No = " + ordNo, con);

                date = (DateTime)getDate.ExecuteScalar();
                user = (String)userGet.ExecuteScalar();
                txtBox_Total.Text = "Php " + ((Decimal)total.ExecuteScalar()).ToString();
            }
            catch(Exception)
            {
                txtBox_Total.Text = "Php 0.00";
            }
            con.Close();

            txtBox_UserAssigned.Text = user;
            txtBox_OrderNo.Text = ordNo.ToString();
            

            SqlCommand getOrder = new SqlCommand("SELECT Quantity, Item_Description, PricePerItem, TotalAmount FROM Orders WHERE Order_No = " + ordNo.ToString(), con);


            SqlDataAdapter ada = new SqlDataAdapter();

            ada.SelectCommand = getOrder;
            DataTable table = new DataTable();
            ada.Fill(table);

            dataGridView1.DataSource = table;
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Record rec = new Record();
            this.Hide();
            rec.ShowDialog();
            this.Close();
        }
    }
}
