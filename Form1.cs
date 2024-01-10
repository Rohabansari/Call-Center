using CallCenter1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CallCenter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }
        public static string username = "";
        public static string password = "";


        private void btn_Login_Click(object sender, EventArgs e)
        {
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8BL3MIG\SQLEXPRESS;Initial Catalog=""Call Center"";Integrated Security=True;");
                username = text_username.Text;
                password = text_password.Text;
                
                if (username == "" || password == "")
                {
                    MessageBox.Show("Please enter your username and password.");
                }
                else
                {
                    var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS"; 
                    var database = "Call Center"; 
                    var thisUsername = username; 
                    var thisPassword = password;
                    string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                    SqlConnection conn = new SqlConnection(connString);

                    try
                    {
                        conn.Open();
                        //MessageBox.Show("Connection Successful"); 
                        //conn.Close();
                        this.Hide();
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        // Application.Run(new Form2());
                        conn.Close();
                        



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
    }


}
    

