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
    public partial class SelectTea : Form
    {
        int orderNo, pass;

        public SelectTea(int ordNo, int from)
        {
            InitializeComponent();
            orderNo = ordNo;
            pass = from;
        }

        public void returnOne()
        {
            OrderForm orderForm = new OrderForm(orderNo);
            this.Hide();
            orderForm.ShowDialog();
            this.Close();
        }

        public void returnTwo()
        {
            int ord;
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand com = new SqlCommand("SELECT TableNo From CurrentTable WHERE Order_No = " + orderNo, con);
            con.Open();
            ord = (Int32)com.ExecuteScalar();
            con.Close();

            OrderEdit orderForm = new OrderEdit(orderNo, ord);
            this.Hide();
            orderForm.ShowDialog();
            this.Close();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DR19");

            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DR19.1");

            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Drinks drink = new Drinks(orderNo, pass);
            this.Hide();
            drink.ShowDialog();
            this.Close();
        }
    }
}
