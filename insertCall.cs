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
    public partial class insertCall : Form
    {
      //  private const string ConnectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Call Center 1;Integrated Security=True";
        public insertCall()
        {
            InitializeComponent();
        }

        private void insertCall_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string ConnectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword; int billingIDToDelete; int callID, customerID, agentID, duration;
            DateTime startTime, endTime;
            string callType = txtCallType.Text;
            string callResult = txtCallResult.Text;
            string notes = txtNotes.Text;

            // Check if callID, customerID, agentID, and duration are valid integers
            if (
                !int.TryParse(txtCustomerID.Text, out customerID) ||
                !int.TryParse(txtAgentID.Text, out agentID) ||
                !int.TryParse(txtDuration.Text, out duration))
            {
                MessageBox.Show("CallID, CustomerID, AgentID, and Duration must be valid integers.");
                return;
            }

            // Check if StartTime and EndTime are valid DateTime values
            if (!DateTime.TryParse(txtStartTime.Text, out startTime) ||
                !DateTime.TryParse(txtEndTime.Text, out endTime))
            {
                MessageBox.Show("StartTime and EndTime must be valid DateTime values.");
                return;
            }

            // SQL query to insert into Call table
            string query = "INSERT INTO Call (CustomerID, AgentID, StartTime, EndTime, Duration, CallType, CallResult, Notes) " +
                           "VALUES (@CustomerID, @AgentID, @StartTime, @EndTime, @Duration, @CallType, @CallResult, @Notes)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                   // command.Parameters.AddWithValue("@CallID", callID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@AgentID", agentID);
                    command.Parameters.AddWithValue("@StartTime", startTime);
                    command.Parameters.AddWithValue("@EndTime", endTime);
                    command.Parameters.AddWithValue("@Duration", duration);
                    command.Parameters.AddWithValue("@CallType", callType);
                    command.Parameters.AddWithValue("@CallResult", callResult);
                    command.Parameters.AddWithValue("@Notes", notes);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        this.Hide();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        this.Hide();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            tables form2 = new tables("Call");
            form2.Show();
            this.Hide();
        }
    }
}
