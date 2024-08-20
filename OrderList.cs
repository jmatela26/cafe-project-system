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
    public partial class OrderList : Form
    {
        string connectAddress = DBConnection.getAddress();
        int orderNo;
        int pass;

        public OrderList(int ordNo, int from)
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if (pass == 1)
                returnOne();
            else
                returnTwo();
        }

        private void Btn_RiceMeals_Click(object sender, EventArgs e)
        {
            RiceMeals mealForm = new RiceMeals(orderNo, pass);
            this.Hide();
            mealForm.ShowDialog();
            this.Close();
        }

        private void Btn_ALaCarte_Click(object sender, EventArgs e)
        {
            ALaCarte aLaCarteForm = new ALaCarte(orderNo, pass);
            this.Hide();
            aLaCarteForm.ShowDialog();
            this.Close();
        }

        private void Btn_LightDishes_Click(object sender, EventArgs e)
        {
            LightDishes dishesForm = new LightDishes(orderNo, pass);
            this.Hide();
            dishesForm.ShowDialog();
            this.Close();
        }

        private void Btn_Drinks_Click(object sender, EventArgs e)
        {
            Drinks drinksForm = new Drinks(orderNo, pass);
            this.Hide();
            drinksForm.ShowDialog();
            this.Close();
        }

        private void Btn_Desserts_Click(object sender, EventArgs e)
        {
            Desserts dessertsForm = new Desserts(orderNo, pass);
            this.Hide();
            dessertsForm.ShowDialog();
            this.Close();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {

        }
    }
}
