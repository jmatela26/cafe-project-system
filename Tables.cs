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
    public partial class Tables : Form
    {
        string connectAddress = DBConnection.getAddress();
        List<Button> myButton = new List<Button>();

            

        public Tables()
        {
            InitializeComponent();

            myButton.Add(Btn_Table1);
            myButton.Add(Btn_Table2);
            myButton.Add(Btn_Table3);
            myButton.Add(Btn_Table4);
            myButton.Add(Btn_Table5);
            myButton.Add(Btn_Table6);
            myButton.Add(Btn_Table7);
            myButton.Add(Btn_Table8);
            myButton.Add(Btn_Table9);
            myButton.Add(Btn_Table10);
            myButton.Add(Btn_Table11);
            myButton.Add(Btn_Table12);
            myButton.Add(Btn_Table13);
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            string status;

            try
            {
                for (int count = 0; count <= 12; count++)
                {
                    status = retrieveStatus(count+1);

                    if (status == "Pending")
                    {
                        myButton[count].BackColor = Color.Red;
                    }
                    else if (status == "Complete")
                    {
                        myButton[count].BackColor = Color.Green;
                    }
                    else
                    {
                        myButton[count].Enabled = false;
                        myButton[count].BackColor = Color.White;
                    }

                }
            }
            catch(Exception)
            {

            }
        }

        private string retrieveStatus(int tableNo)
        {
            string status;
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("SELECT Status FROM CurrentTable WHERE TableNo = " + tableNo.ToString(),con);

            con.Open();
            try
            {
                status = (String)com.ExecuteScalar();
                con.Close();
                return status;
            }
            catch(Exception)
            {
                MessageBox.Show("Error at StatRetrieve");
                con.Close();
                return "";
            }
            

        }

        private int getOrderNo(int tableNo)
        {
            int orderNo;
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("SELECT Order_No FROM CurrentTable WHERE TableNo = " + tableNo.ToString(), con);

            con.Open();
            try
            {
                orderNo = (Int32)com.ExecuteScalar();
                con.Close();
                return orderNo;
            }
            catch(Exception)
            {
                con.Close();
                return 0;
            }
        }

        private void Btn_Table1_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(1);

            OrderEdit editForm = new OrderEdit(order, 1);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table2_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(2);

            OrderEdit editForm = new OrderEdit(order, 2);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table3_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(3);

            OrderEdit editForm = new OrderEdit(order, 3);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table4_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(4);

            OrderEdit editForm = new OrderEdit(order, 4);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table5_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(5);

            OrderEdit editForm = new OrderEdit(order, 5);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table6_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(6);

            OrderEdit editForm = new OrderEdit(order, 6);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table7_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(7);

            OrderEdit editForm = new OrderEdit(order, 7);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table8_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(8);

            OrderEdit editForm = new OrderEdit(order, 8);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table9_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(9);

            OrderEdit editForm = new OrderEdit(order, 9);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table10_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(10);

            OrderEdit editForm = new OrderEdit(order, 10);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table11_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(11);

            OrderEdit editForm = new OrderEdit(order, 11);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table12_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(12);

            OrderEdit editForm = new OrderEdit(order, 12);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void Btn_Table13_Click(object sender, EventArgs e)
        {
            int order;
            order = getOrderNo(13);

            OrderEdit editForm = new OrderEdit(order, 13);

            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }
    }
}
