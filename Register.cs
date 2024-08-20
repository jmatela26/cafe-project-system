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
    public partial class Register : Form
    {
        string connectAddress = DBConnection.getAddress();

        public Register()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if(txtBox_User.Text != "" && txtBox_Pass.Text != "" && txtBox_Pass2.Text != "" && cmbo_Security.Text != "")
            {
                if (cmbo_Security.Text == "Staff" || (cmbo_Security.Text == "Administrator" && txtBox_Security.Text == "BintanaAdmin123"))
                {
                    SqlConnection con = new SqlConnection(connectAddress);
                    SqlDataAdapter add = new SqlDataAdapter();

                    add.InsertCommand = new SqlCommand("INSERT INTO Users VALUES(@UserName,@UserPass,@Permission,@Status)", con);
                    add.InsertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txtBox_User.Text;
                    add.InsertCommand.Parameters.Add("@UserPass", SqlDbType.VarChar).Value = txtBox_Pass.Text;
                    add.InsertCommand.Parameters.Add("@Permission", SqlDbType.VarChar).Value = cmbo_Security.Text;
                    add.InsertCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Offline";

                    con.Open();
                    add.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("You are now registered, please log-in.");

                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid Admin Password. Please contact the owner.");
            }
            else
            {
                MessageBox.Show("Please fill up all the fields required.");
            }
        }

        private void cmbo_Security_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbo_Security.Text == "Administrator")
            {
                txtBox_Security.Visible = true;
                label_Sec.Visible = true;
            }
            else
            {
                txtBox_Security.Visible = false;
                label_Sec.Visible = false;
            }
        }

        private void txtBox_StaffID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            int count = 0;

            string qty = "SELECT MAX(USER_ID) FROM Users";
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand(qty, con);

            con.Open();
            try
            {
                count = (Int32)com.ExecuteScalar();
            }
            catch(Exception)
            {
                count = 1000;
            }
            con.Close();
            count++;
            txtBox_StaffID.Text = count.ToString();
        }
    }
}
