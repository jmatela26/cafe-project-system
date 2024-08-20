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
    public partial class Record : Form
    {
        string connectAddress = DBConnection.getAddress();
        int row, recNo;

        public Record()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Record_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("SELECT * FROM Record", con);
            SqlDataAdapter ada = new SqlDataAdapter();

            ada.SelectCommand =com;
            DataTable dataTable = new DataTable();
            ada.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            ada.Update(dataTable);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_Record_Click(object sender, EventArgs e)
        {
            ViewRecord view = new ViewRecord(1);
            view.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectAddress);
            SqlCommand com = new SqlCommand("EXECUTE getRecordNo " + row.ToString(), con);
           
            con.Open();
            try
            {
                recNo = (Int32)com.ExecuteScalar();
            }
            catch(Exception)
            {
                MessageBox.Show("Please select the proper item.");
            }
            con.Close();

            ViewRecord view = new ViewRecord(recNo);
            this.Hide();
            view.ShowDialog();
            this.Close();
        }
    }
}
