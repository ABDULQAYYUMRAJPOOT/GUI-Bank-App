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
    public partial class frmEmpMenu : Form
    {
        public frmEmpMenu()
        {
            InitializeComponent();
        }

        private void btnViewAccountsEmp_Click(object sender, EventArgs e)
        {

            Form frmShowAllAccounts = new frmShowAccounts();
            frmShowAllAccounts.Show();
        }

        private void btnAddAccountEmp_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddUser = new frmAddAccount();
            frmAddUser.Show();
        }

        private void btnRemoveAccountEmp_Click(object sender, EventArgs e)
        {
            frmDeletAccount frm = new frmDeletAccount();
            frm.Show();

        }

        private void btnDepAmountEmp_Click(object sender, EventArgs e)
        {
            frmDepositByEmp frm = new frmDepositByEmp();
            frm.Show();

        }

        private void btnSeeFeedEmp_Click(object sender, EventArgs e)
        {

            Form frmSeeFeed = new frmShowFeedEmp();
            frmSeeFeed.Show();
        }

        private void btnBackFromEmpMenu_Click(object sender, EventArgs e)
        {
            frmFirst frm = new frmFirst();
            this.Close();
            frm.Show();
        }
    }
}
