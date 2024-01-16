using CompAppWithOOPs.BL;
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
    public partial class frmShowAmount : Form
    {
        string Amount;
        public Label lblAmount;
        public frmShowAmount(string amount)
        {
            Amount = amount;
            lblAmount = lblShowAmount;
            InitializeComponent();
        }

        private void frmShowAmount_Load(object sender, EventArgs e)
        {
            //string amount = Account.getAmount().ToString();
            lblRupees.Text = Amount + " Rupees";
        }

        private void btnBackFromShowAmount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtShowAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
