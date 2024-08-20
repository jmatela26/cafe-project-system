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
    public partial class RiceMeals : Form
    {
        int orderNo, pass;
        string connectAddress = DBConnection.getAddress();
        
        public RiceMeals(int ordNo, int from)
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

        private void Btn_RM1_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo,"RM01");
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

        private void RiceMeals_Load(object sender, EventArgs e)
        {

        }

        private void Btn_RM2_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM02");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM3_Click(object sender, EventArgs e)
        {
            SelectBurgerSteak select = new SelectBurgerSteak(orderNo, pass);
            this.Hide();
            select.ShowDialog();
            this.Close();
        }

        private void Btn_RM4_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM04");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM5_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM05");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM6_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM06");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM7_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM07");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM8_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM08");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM9_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM09");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM10_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM10");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM11_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM11");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM12_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM12");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM13_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM13");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RM14_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "RM14");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }
    }
}
