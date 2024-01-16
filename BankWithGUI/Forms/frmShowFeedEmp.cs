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
    public partial class frmShowFeedEmp : Form
    {
        public frmShowFeedEmp()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void frmShowFeedEmp_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Names", typeof(string));
            table.Columns.Add("FeedBacks", typeof(string));
            dataGridView1.DataSource = table;
            foreach(Person p in PersonDL.getPersonsList())
            {
                table.Rows.Add(p.name,p.getFeedBack());
            }
        }

        private void btnBackFromShowFeed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
