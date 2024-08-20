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
    public partial class Desserts : Form
    {
        int orderNo, pass;
        string connectAddress = DBConnection.getAddress();

        public Desserts(int ordNo, int from)
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

        private void Btn_Dessert1_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS01");
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

        private void Btn_Dessert2_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS02");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Dessert3_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS03");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Dessert4_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS04");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Dessert5_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS05");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Dessert6_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS06");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_Dessert7_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "DS07");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }
    }
}
