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
    public partial class Drinks : Form
    {
        int orderNo, pass;
        string connectAddress = DBConnection.getAddress();

        public Drinks(int ordNo, int from)
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV01");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Coffee1_Click(object sender, EventArgs e)
        {
            SelectCoffee coffee = new SelectCoffee(1, orderNo, pass);
            this.Hide();
            coffee.ShowDialog();
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Coffee2_Click(object sender, EventArgs e)
        {
            SelectCoffee coffee = new SelectCoffee(2, orderNo, pass);
            this.Hide();
            coffee.ShowDialog();
            this.Close();
            
        }

        private void Btn_Coffee3_Click(object sender, EventArgs e)
        {
            SelectCoffee coffee = new SelectCoffee(3, orderNo, pass);
            this.Hide();
            coffee.ShowDialog();
            this.Close();
        }

        private void Btn_Drinks1_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV01");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks2_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV02");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks3_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV03");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks4_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV04");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks5_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV05");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks6_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV06");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks7_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV07");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks8_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV08");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks9_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV09");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks10_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV10");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks11_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV11");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks12_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV12");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks13_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV13");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks14_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV14");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks15_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV15");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks16_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV16");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks17_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV17");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks18_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV18");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks19_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV19");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks20_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV20");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Drinks22_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "BV23");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }
    }
}
