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
    public partial class DeleteBilling : Form
    {
      //  private const string ConnectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Call Center 1;Integrated Security=True";

        public DeleteBilling()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string ConnectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword; int billingIDToDelete;

            // Check if BillingIDToDelete is a valid integer
            if (!int.TryParse(txtBillingIDToDelete.Text, out billingIDToDelete))
            {
                MessageBox.Show("BillingID to delete must be a valid integer.");
                return;
            }

            // SQL query to delete from Billing table
            string query = "DELETE FROM Billing WHERE BillingID = @BillingID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to the query
                    command.Parameters.AddWithValue("@BillingID", billingIDToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.Hide(); // Hide the current form
                            MessageBox.Show($"1 row(s) deleted successfully.");
                            // _insertBillingForm.RefreshData(); // Assuming you have a method to refresh the data in insertBilling form
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("No rows deleted. BillingID not found.");
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

        private void Back_Click(object sender, EventArgs e)
        {
            tables form = new tables("Billing");
            form.Show();
            this.Hide(); 
        }

        private void DeleteBilling_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
