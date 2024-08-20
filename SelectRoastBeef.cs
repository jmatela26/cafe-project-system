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
    public partial class SelectRoastBeef : Form
    {
        int orderNo, pass;

        public SelectRoastBeef(int ordNo, int from)
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

        private void button4_Click(object sender, EventArgs e)
        {
            RiceMeals meals = new RiceMeals(orderNo, pass);
            this.Hide();
            meals.ShowDialog();
            this.Close();
        }

        private void Btn_Rice_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM13");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_MPandBread_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM13A");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_All_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM13B");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }
    }
}
