using CompAppWithOOPs.BL;
using CompAppWithOOPs.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWithGUI.Forms
{
    public partial class frmShowAccounts : Form
    {
        public frmShowAccounts()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmShowAccounts_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Names", typeof(string));
            table.Columns.Add("Passwords", typeof(string));
            table.Columns.Add("Role", typeof(string));
            dataGridView1.DataSource = table;
            foreach (Person p in PersonDL.getPersonsList())
            {
                table.Rows.Add(p.name, p.password, p.role);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
