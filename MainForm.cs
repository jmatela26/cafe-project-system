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
    public partial class MainForm : Form
    {
        string connectAddress = DBConnection.getAddress();

        public MainForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            int orderNo;

            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand ord = new SqlCommand("SELECT MAX(ORDER_NO) FROM Orders", con);

            con.Open();
            try
            {
                orderNo = (Int32)ord.ExecuteScalar() + 1;
            }
            catch (Exception)
            {
                SqlCommand enter = new SqlCommand("INSERT INTO Orders(ORDER_NO, ITEM_NO) VALUES(1,1)", con);
                try
                {
                    enter.ExecuteNonQuery();
                    orderNo = (Int32)ord.ExecuteScalar();
                }
                catch(Exception)
                {
                    orderNo = 1;
                }
            }
            con.Close();

            OrderForm orderForm = new OrderForm(orderNo);
            this.Hide();
            orderForm.ShowDialog();
            this.Close();
        }

        private void Btn_Tables_Click(object sender, EventArgs e)
        {
            Tables tablesForm = new Tables();
            this.Hide();
            tablesForm.ShowDialog();
            this.Close();
        }

        private void Btn_Record_Click(object sender, EventArgs e)
        {
            Record recordForm = new Record();
            this.Hide();
            recordForm.ShowDialog();
            this.Close();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string name, per;
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("SELECT Username FROM Users WHERE Status = 'Online'", con);
            SqlCommand getAuth = new SqlCommand("SELECT Permission FROM Users WHERE Status = 'Online'", con);

            con.Open();
            name = (String)com.ExecuteScalar();
            per = (String)getAuth.ExecuteScalar();
            con.Close();
            txtBox_User.Text = name;

            if(per != "Administrator")
            {
                Btn_Users.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtBox_Date.Text = DateTime.Now.ToLongDateString();
            txtBox_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtBox_Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Inventory_Click(object sender, EventArgs e)
        {
            InventoryView inv = new InventoryView();
            this.Hide();
            inv.ShowDialog();
            this.Close();
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            UsersView view = new UsersView();
            this.Hide();
            view.ShowDialog();
            this.Close();
        }
    }
}
