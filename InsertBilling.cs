﻿using System;
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
    public partial class InsertBilling : Form
    {
       // private const string ConnectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Call Center 1;Integrated Security=True";

        public InsertBilling()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string ConnectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword; int billingIDToDelete; int billingID, customerID, agentID;
            decimal amount;
            DateTime billingDate;

            // Check if BillingID, CustomerID, and AgentID are valid integers
            if (
                !int.TryParse(txtCustomerID.Text, out customerID) ||
                !int.TryParse(txtAgentID.Text, out agentID) ||
                !decimal.TryParse(txtAmount.Text, out amount) ||
                !DateTime.TryParse(txtBillingDate.Text, out billingDate))
            {
                MessageBox.Show("CustomerID, AgentID, Amount, and BillingDate must be valid values.");
                return;
            }

            // SQL query to insert into Billing table
            string query = "INSERT INTO Billing (CustomerID, AgentID, Amount, BillingDate) " +
                           "VALUES (@CustomerID, @AgentID, @Amount, @BillingDate)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                   // command.Parameters.AddWithValue("@BillingID", billingID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@AgentID", agentID);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@BillingDate", billingDate);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
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
    }
}
