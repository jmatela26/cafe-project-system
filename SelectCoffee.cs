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
    public partial class SelectCoffee : Form
    {
        int orderNo;
        int thisType, pass;

        public SelectCoffee(int type, int ordNo, int from)
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

        private void Btn_V60_Click(object sender, EventArgs e)
        {
            if (thisType == 1)
            {
                GetOrder.placeOrder(orderNo, "CF1");
            }
            else if (thisType == 2)
            {
                GetOrder.placeOrder(orderNo, "CF2");
            }
            else
            {
                GetOrder.placeOrder(orderNo, "CF3");
            }

            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_FP_Click(object sender, EventArgs e)
        {
            if (thisType == 1)
            {
                GetOrder.placeOrder(orderNo, "CF1.1");
            }
            else if (thisType == 2)
            {
                GetOrder.placeOrder(orderNo, "CF2.1");
            }
            else
            {
                GetOrder.placeOrder(orderNo, "CF3.1");
            }

            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Phin_Click(object sender, EventArgs e)
        {
            if (thisType == 1)
            {
                GetOrder.placeOrder(orderNo, "CF1.2");
            }
            else if (thisType == 2)
            {
                GetOrder.placeOrder(orderNo, "CF2.2");
            }
            else
            {
                GetOrder.placeOrder(orderNo, "CF3.2");
            }

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
