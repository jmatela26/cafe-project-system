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
    public partial class LoginForm : Form
    {
        //mandatory w/ DB Server name
        string connectAddress = DBConnection.getAddress();
        int userID=0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getData(string data)
        {
            string check = "SELECT " + data + " FROM Users WHERE USERNAME = '" + txtBox_User.Text + "' AND PASSWORD = '" + txtBox_Pass.Text + "'";
            return check;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //searches the database using queries
            string user = getData("Username");
            string permit = getData("Permission");
            string ID = getData("User_ID");

            //executes the queries
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand command = new SqlCommand(user, con);
            SqlCommand permitCommand = new SqlCommand(permit, con);
            SqlCommand userIDCom = new SqlCommand(ID, con);
            con.Open();

            string userCheck;
            userCheck = (String)command.ExecuteScalar();
            string permitCheck;
            permitCheck = (String)permitCommand.ExecuteScalar();
            if (permitCheck != null)
                userID = (Int32)userIDCom.ExecuteScalar();
            con.Close();
                

            MainForm main = new MainForm();

            //verifies credentials
            if (userCheck == txtBox_User.Text)
            {
                SqlCommand userStatus = new SqlCommand("UPDATE Users SET Status = 'Online' WHERE User_ID = " + userID.ToString(), con);

                if (permitCheck == "Administrator")
                {
                    MessageBox.Show("You are now logged in as Administrator! Welcome " + userCheck + ".");

                }
                else if (permitCheck == "Staff")
                {
                    MessageBox.Show("You are now logged in. Welcome " + userCheck + ".");
                }

                con.Open();
                userStatus.ExecuteNonQuery();
                con.Close();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("UPDATE Users SET Status = 'Offline'",con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
