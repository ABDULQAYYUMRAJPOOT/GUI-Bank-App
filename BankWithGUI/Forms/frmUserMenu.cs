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
    public partial class frmUserMenu : Form
    {
        Account Account;
        User User;
        public frmUserMenu(Account account, User user)
        {
            User = user;
            Account = account;
            InitializeComponent();
        }

        private void btnDepositUser_Click(object sender, EventArgs e)
        {

            frmDepositeAmount frmDeposit = new frmDepositeAmount(Account,"deposite");
            frmDeposit.Show();

        }

        private void btnWithdrawUser_Click(object sender, EventArgs e)
        {
            frmAmountInput frmWithDraw = new frmAmountInput(Account);
            frmWithDraw.Show();
        }

        private void btnTransferUser_Click(object sender, EventArgs e)
        {
            frmAmountInput frmTransfer = new frmAmountInput(Account);
            frmTransfer.Show();
        }

        private void btnBalanceUser_Click(object sender, EventArgs e)
        {
            string amount = Account.getAmount().ToString();
            Form frmBalance = new frmShowAmount(amount);
            frmBalance.Show();
        }

        private void btnUpPassUser_Click(object sender, EventArgs e)
        {
            frmUpdatePassword frmUpdatePass = new frmUpdatePassword(User);
            frmUpdatePass.Show();
        }

        private void btnGetLoanUser_Click(object sender, EventArgs e)
        {
            frmDepositeAmount frmDeposit = new frmDepositeAmount(Account, "loan"); frmDeposit.Show();
            
        }

        private void btnPayLoanUser_Click(object sender, EventArgs e)
        {
            Form frmPayLoan = new frmAmountInput(Account);
            frmPayLoan.Show();
        }

        private void btnCheckLoanUser_Click(object sender, EventArgs e)
        {
            string amount = Account.getLoan().ToString();
            frmShowAmount frmCheckLoan = new frmShowAmount(amount);
            frmCheckLoan.Show();
        }

        private void btnAmountWithLoanUser_Click(object sender, EventArgs e)
        {
            string amount = Account.amountWithLoan().ToString();
            frmShowAmount frmAmountWithLoan = new frmShowAmount(amount);
            frmAmountWithLoan.Show();
        }

        private void btnAmountWithInterestUser_Click(object sender, EventArgs e)
        {
            string amount = Account.amountAfterInterest().ToString();
            frmShowAmount frmAmountWithInterest = new frmShowAmount(amount);
            frmAmountWithInterest.Show();
        }

        private void btnGiveFeedUser_Click(object sender, EventArgs e)
        {
            frmGetFeedBack frmGiveFeedBack = new frmGetFeedBack(User);
            frmGiveFeedBack.Show();
        }

        private void btnBackFromUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirst frmFirstMenu = new frmFirst();
            frmFirstMenu.Show();
        }

        private void frmUserMenu_Load(object sender, EventArgs e)
        {
            if (Account.getType() == "checking")
            {
                Account = Account as Checking;
            }
            else { Account = Account as Saving; }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
