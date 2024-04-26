using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter2
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        string thisUsername = CallCenter1.username;
        private void menu_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2_Load() called...");
            string txtMessageText = "Startup...";
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center";

            var thisPassword = CallCenter1.password;
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
            SqlConnection conn = new SqlConnection(connString);
            if (thisUsername == "Agent")
            {
                Issue.Enabled = false;
                Agents.Enabled = false;
                Departments.Enabled = false;
                Supervisors.Enabled = false;
                OrderProcessing.Enabled = false;
                Interviews.Enabled = false;
                CustomerSupport.Enabled = false;
                Billing.Enabled = false;
            }
            if (thisUsername == "OrderPro")
            {
                Departments.Enabled = false;
                Supervisors.Enabled = false;
                CustomerSupport.Enabled = false;
                Billing.Enabled = false;
                Calls.Enabled = false;
                Issue.Enabled = false;
            }
            if (thisUsername == "Billing")
            {
                Issue.Enabled = false;
                Departments.Enabled = false;
                Supervisors.Enabled = false;
                CustomerSupport.Enabled = false;
                OrderProcessing.Enabled = false;
                Calls.Enabled = false;
            }
            if (thisUsername == "Support")
            {
                Issue.Enabled = false;
                Departments.Enabled = false;
                Supervisors.Enabled = false;
                Billing.Enabled = false;
                OrderProcessing.Enabled = false;
                Calls.Enabled = false;
            }


            try
            {
                conn.Open();
                Console.WriteLine("Connection Successful on Form2 Load");

                // Extract role from the username (assuming the username format is "username_role")
                //   string[] usernameParts = thisUsername.Split('_');
                // string userRole = usernameParts.Length == 2 ? usernameParts[1] : "Agent"; // Replace with your default role

                // Adjust button visibility based on user role


                // Console.WriteLine("User Role: " + userRole);

                // Other buttons visibility adjustments go here...

                conn.Close();
            }
            catch (Exception ex)
            {
                txtMessageText = "Error, " + ex;
            }
            Debug.WriteLine("End of Form2_Load()");
        }

        private void View_Click(object sender, EventArgs e)
        {
            string currentTable = "";
            if (Agents.Checked)
            {
                currentTable = "Agent";
            }
            if (Issue.Checked)
            {
                currentTable = "TrainingSession";
            }
            else if (Calls.Checked)
            {
                currentTable = "Call";
            }
          
            else if (Customer.Checked)
            {
                currentTable = "Customer";
            }
            else if (Departments.Checked)
            {
                currentTable = "Department";
            }
            else if (Supervisors.Checked)
            {
                currentTable = "Supervisor";
            }
            else if (Billing.Checked)
            {
                currentTable = "Billing";
            }
            else if (OrderProcessing.Checked)
            {
                currentTable = "OrderProcessing";
            }
            else if (Interviews.Checked)
            {
                currentTable = "Interview";
            }
            else if(CustomerSupport.Checked)
            {
                currentTable = "CustomerSupport";
            }

            try
            {
                this.Hide();
                tables frm3 = new tables(currentTable);
                frm3.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu1 menu1 = new menu1();
            menu1.Show();
        }
    }
}

