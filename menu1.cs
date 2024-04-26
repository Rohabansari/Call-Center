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
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
            
        }

        private void View_Click(object sender, EventArgs e)
        {
            var datasource = @"DESKTOP-8BL3MIG\SQLEXPRESS";
            var database = "Call Center 1";
            var thisUsername = CallCenter1.username;
            var thisPassword = CallCenter1.password;
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
            // SqlConnection conn = new SqlConnection(connString);
            using (SqlConnection connection = new SqlConnection(connString)) 
                if (AllTables.Checked)
            {
                menu form2 = new menu();
                form2.Show();
                this.Hide();
            }
            if (DeletedData.Checked)
            {
                if (thisUsername == "CEO" || thisUsername == "HR")
                {
                    deletedData deletedData2 = new deletedData();
                    deletedData2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You do not have permission to view deleted data.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
