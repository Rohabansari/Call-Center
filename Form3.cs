using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter1
{
    public partial class Form3 : Form
    {
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        private string currentTable = "";
        private string connectionString = @"Data Source=DESKTOP-8BL3MIG\SQLEXPRESS;Initial Catalog=Call Center;Integrated Security=True;";

        
        public Form3(string tablename)
        {
            InitializeComponent();
            currentTable = tablename;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // You should set the currentTable before loading the data
            // You might do this based on user input or another mechanism
            // For this example, let's assume you set it in the constructor
           // currentTable = "Agent";

            LoadTableData();
        }
            

            private void LoadTableData()
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "select * from " + currentTable;
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

        private void Insert_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Add(dataGridView1.SelectedRows[0].Index);
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }
    }
    }


