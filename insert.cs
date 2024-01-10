using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter1
{
    public partial class insert : Form
    {
        private string currentTable = "";
        public insert(string tablename)
        {
            InitializeComponent();
            currentTable=tablename;

        }
        private void insert_Load(object sender, EventArgs e)
        {

        }

        private void Agentid_Click(object sender, EventArgs e)
        {

        }

        
    }
}
