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
    public partial class DeleteCall : Form
    {
      //  private const string ConnectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Call Center 1;Integrated Security=True";
        public DeleteCall()
        {
            InitializeComponent();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string ConnectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword; int billingIDToDelete; int callIDToDelete;

            // Check if CallIDToDelete is a valid integer
            if (!int.TryParse(txtCallIDToDelete.Text, out callIDToDelete))
            {
                MessageBox.Show("CallID to delete must be a valid integer.");
                return;
            }

            // SQL query to delete from Call table
            string query = "DELETE FROM Call WHERE CallID = @CallID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("@CallID", callIDToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.Hide(); // Hide the current form
                            MessageBox.Show($"{rowsAffected} row(s) deleted successfully.");
                            // _insertCallForm.RefreshData(); // Assuming you have a method to refresh the data in insertCall form

                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("No rows deleted. CallID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Hide();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tables form2 = new tables("Call");
            form2.Show();
            this.Hide();
        }

        private void DeleteCall_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            tables form2 = new tables("Call");
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string ConnectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword; int billingIDToDelete; int callIDToDelete;

            // Check if CallIDToDelete is a valid integer
            if (!int.TryParse(txtCallIDToDelete.Text, out callIDToDelete))
            {
                MessageBox.Show("CallID to delete must be a valid integer.");
                return;
            }

            // SQL query to delete from Call table
            string query = "DELETE FROM Call WHERE CallID = @CallID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("@CallID", callIDToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.Hide(); // Hide the current form
                            MessageBox.Show($"1 row(s) deleted successfully.");
                            // _insertCallForm.RefreshData(); // Assuming you have a method to refresh the data in insertCall form

                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("No rows deleted. CallID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Hide();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
