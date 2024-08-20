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
    public partial class ALaCarte : Form
    {
        int orderNo, pass;
        string connectAddress = DBConnection.getAddress();
        
        public ALaCarte(int ordNo, int from)
        {
            InitializeComponent();
            orderNo = ordNo;
            pass = from;
            
        }
        
        private void Btn_ALC1_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "ALC01");
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

        private void Btn_ALC2_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "ALC02");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_ALC3_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "ALC03");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_ALC4_Click(object sender, EventArgs e)
        {
            GetOrder.placeOrder(orderNo, "ALC04");
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void ALaCarte_Load(object sender, EventArgs e)
        {

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
    }
}
