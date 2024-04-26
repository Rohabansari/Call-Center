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
    public partial class insertAgent : Form
    {
      //  private const string ConnectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Call Center 1;Integrated Security=True";
        public insertAgent()
        {
            InitializeComponent();
        }

        private void insertAgent_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string ConnectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword; int billingIDToDelete; int agentid;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string department = txtDepartment.Text;
            int supervisorID;
           /* if (!int.TryParse(txtagentID.Text, out agentid))
            {
                MessageBox.Show("SupervisorID must be a valid integer.");
                return;
            }*/

            // Check if SupervisorID is a valid integer

            if (!int.TryParse(txtSupervisorID.Text, out supervisorID))
            {
                MessageBox.Show("SupervisorID must be a valid integer.");
                return;
            }

            // SQL query to insert into Agent table
            string query = "INSERT INTO Agent (FirstName, LastName, Email, Phone, Department, SupervisorID) " +
                           "VALUES (@FirstName, @LastName, @Email, @Phone, @Department, @SupervisorID)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                  //  command.Parameters.AddWithValue("@AgentID", agentid);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@SupervisorID", supervisorID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        this.Hide();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
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
