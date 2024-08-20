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
    public partial class UsersView : Form
    {
        int row=1;
        int toDelete;

        public UsersView()
        {
            InitializeComponent();
        }

        private void UsersView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand com = new SqlCommand("SELECT User_ID, Username, Permission, Status FROM Users", con);
            SqlDataAdapter ada = new SqlDataAdapter();

            ada.SelectCommand = com;
            DataTable dtb = new DataTable();
            ada.Fill(dtb);

            dataGridView1.DataSource = dtb;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand com = new SqlCommand("EXECUTE deleteUser " + row.ToString(), con);

            con.Open();
            try
            {
                toDelete = (Int32)com.ExecuteScalar();
            }
            catch(Exception)
            {

            }
            con.Close();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand com = new SqlCommand("DELETE FROM Users WHERE User_ID = " + toDelete.ToString(), con);

            con.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Please select a user to delete.");
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
