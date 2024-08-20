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
    public partial class InventoryView : Form
    {
        int row=1, col=1;
        string itemID="";

        public InventoryView()
        {
            InitializeComponent();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            string permission;
            
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand getPer = new SqlCommand("EXECUTE getPermission", con);
            SqlCommand com = new SqlCommand("SELECT * FROM Inventory", con);
            SqlDataAdapter ada = new SqlDataAdapter();

            con.Open();
            permission = (String)getPer.ExecuteScalar();
            con.Close();

            if(permission != "Administrator")
            {
                Btn_Edit.Hide();
                txtBox_Edit.Hide();
                label1.Hide();
            }

            ada.SelectCommand = com;
            DataTable dtb = new DataTable();
            ada.Fill(dtb);

            dataGridView.DataSource = dtb;
            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand com = new SqlCommand("UPDATE Inventory SET Stock_Available = " + txtBox_Edit.Text + " WHERE Item_ID = '" + itemID.ToString() + "'", con);

            con.Open();
            try
            {
                if (txtBox_Edit.Text != "")
                {
                    com.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Please enter a value.");
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Selection.");
            }
            con.Close();

            InventoryView view = new InventoryView();
            this.Hide();
            view.ShowDialog();
            this.Close();

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(DBConnection.getAddress());


            row = e.RowIndex + 1;

            SqlCommand com = new SqlCommand("EXECUTE selectItem " + row.ToString(), con);
           
            con.Open();
            itemID = (String)com.ExecuteScalar();
            con.Close();
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
