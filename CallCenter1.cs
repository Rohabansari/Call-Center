using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CallCenter2
{
    public partial class CallCenter1 : Form
    {
        public static string username = "";
        public static string password = "";
        public static string role = "";

        public CallCenter1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8BL3MIG\SQLEXPRESS;Initial Catalog=Call Center;Integrated Security=True;");
            username = txt_username.Text;
            password = txt_password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
                var database = "Call Center 1";
                var thisUsername = username;
                var thisPassword = password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open();

                    // Extract role from the username (assuming the username format is "username_role")
                   

                    Debug.WriteLine($"User Role: {role}"); // Check role in the debug output

                    this.Hide();
                    menu1 table = new menu1();
                    table.Show();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
