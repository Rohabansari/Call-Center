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
using System.Diagnostics;


namespace CallCenter1
{

    public partial class Form2 : Form
    {
        string currentTable = "";
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1_Load() called...");
            string txtMessageText = "Startup...";
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center";
            var thisUsername = Form1.username;
            var thisPassword = Form1.password;
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
               
                    /* 
                    System.Diagnostics.Debug.WriteLine("within the try"); 
                    SqlConnection connection = new SqlConnection(@"Data 
    Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");                 connection.Open(); 
                    txtMessageText.Text = "Connection Successful";                 connection.Close(); 
                    */

                    conn.Open();
                Console.WriteLine("Connection Successful on Form2 Load");
                
               // this.Hide();
                
                conn.Close();





            }
            catch (Exception ex)
            {
                txtMessageText = "Error, " + ex;
            }
            Debug.WriteLine("End of Form2_Load()");

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void but_Call_CheckedChanged(object sender, EventArgs e)
        {
         

        }

        private void but_calllog_CheckedChanged(object sender, EventArgs e)
        {
         


        }

        private void but_customer_CheckedChanged(object sender, EventArgs e)
        {
          

        }
      
        private void but_cust_service_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void but_cust_exp_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void but_dept_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void but_HR_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void but_interviews_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void but_it_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void but_leads_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void but_oper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_order_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_QA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_returns_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_sales_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_sales_sup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_technical_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_training_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            string currentTable = "";
            if (but_Agent.Checked)
            {
                currentTable = "Agent";
            }
            else if (but_Call.Checked)
            {
                currentTable = "Call";
            }
            else if (but_calllog.Checked)
            {
                currentTable = "CallLog";
            }
            else if (but_customer.Checked)
            {
                currentTable = "Customer";
            }
            else if (but_cust_exp.Checked)
            {
                currentTable = "CustomerExperienceDepartment";
            }
            else if (but_cust_service.Checked)
            {
                currentTable = "CustomerServiceDepartment";
            }
            else if (but_dept.Checked)
            {
                currentTable = "Department";
            }
            else if (but_HR.Checked)
            {
                currentTable = "HumanResourcesDepartment";
            }
            else if (but_interviews.Checked)
            {
                currentTable = "Interviews";
            }
            else if (but_it.Checked)
            {
                currentTable = "ITDepartment";
            }
            else if (but_leads.Checked)
            {
                currentTable = "Leads";
            }
            else if (but_oper.Checked)
            {
                currentTable = "OperationsDepartment";
            }
            else if (but_order.Checked)
            {
                currentTable = "OrderProcessingDepartment";
            }
            else if (but_QA.Checked)
            {
                currentTable = "QualityAssuranceDepartment";
            }
            else if (but_returns.Checked)
            {
                currentTable = "ReturnsExchangeDepartment";
            }
            else if (but_sales.Checked)
            {
                currentTable = "SalesDepartment";
            }
            else if (but_sales_sup.Checked)
            {
                currentTable = "SalesSupportDepartment";
            }
            else if (but_technical.Checked)
            {
                currentTable = "TechnicalSupportDepartment";
            }
            else if (but_training.Checked)
            {
                currentTable = "Training";
            }
            try
            {
                //conn.Open();
                //MessageBox.Show("Connection Successful"); 
                //conn.Close();
                this.Hide();
                Form3 frm3 = new Form3(currentTable);
                frm3.Show();
                // Application.Run(new Form2());
               // conn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
