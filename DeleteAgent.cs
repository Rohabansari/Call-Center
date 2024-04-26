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
    public partial class DeleteAgent : Form
    {
        //private const string ConnectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Call Center 1;Integrated Security=True";
        public DeleteAgent()
        {
            InitializeComponent();
        }

        private void DeleteAgent_Load(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {

            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
            int agentIDToDelete;

            // Check if AgentIDToDelete is a valid integer
            if (!int.TryParse(txtAgentIDToDelete.Text, out agentIDToDelete))
            {
                MessageBox.Show("AgentID to delete must be a valid integer.");
                return;
            }

            // SQL query to delete from Agent table
            string query = "DELETE FROM Agent WHERE AgentID = @AgentID";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("@AgentID", agentIDToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"1 row(s) deleted successfully.");
                            this.Hide();
                        }


                        else
                            MessageBox.Show("No rows deleted. AgentID not found.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            tables form2 = new tables("Agent");
            form2.Show();
            this.Hide();
        }
    }
}
