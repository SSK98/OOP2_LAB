using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment_Quize
{
    public partial class allbooks : Form
    {
        public allbooks()
        {
            InitializeComponent();
            SqlConnection conn = Database.ConnectDB();
            conn.Open();
            String query = "Select * from books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string author = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string edition = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            BookDetails bd = new BookDetails(id,name,author,edition);
            bd.Show();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Database.ConnectDB();
            conn.Open();
            String query = "Select * from books where name like'" + textBoxSearch.Text+"%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
