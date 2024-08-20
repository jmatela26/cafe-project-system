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
    public partial class LightDishes : Form
    {
        int orderNo, pass;
        string connectAddress = DBConnection.getAddress();

        public LightDishes(int ordNo, int from)
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

        private void Btn_LD1_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD01");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD2_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD02");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD3_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD03");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD4_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD04");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD5_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD05");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD6_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD06");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD7_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD07");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD8_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD08");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD9_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD09");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD10_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD10");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD11_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD11");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_LD12_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "LD12");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }
    }
}
