using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter2
{
    public partial class Audits : Form
    {
        private string currentTable = "";

        public Audits(string tablename)
        {
            InitializeComponent();
            currentTable = tablename;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
                var database = "Call Center 1";
                var thisUsername = CallCenter1.username;
                var thisPassword = CallCenter1.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                // SqlConnection conn = new SqlConnection(connString);
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {currentTable}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            deletedData deletedData = new deletedData();
            deletedData.Show();
            this.Hide();
        }

        private void Audits_Load(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
            SqlConnection conn = new SqlConnection(connString);
            LoadTableData();
        }
        private void LoadTableData()
        {
            try
            {
                var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
                var database = "Call Center 1";
                var thisUsername = CallCenter1.username;
                var thisPassword = CallCenter1.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                // SqlConnection conn = new SqlConnection(connString);
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {currentTable}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
