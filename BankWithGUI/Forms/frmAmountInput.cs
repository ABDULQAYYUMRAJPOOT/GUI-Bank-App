using CompAppWithOOPs;
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
    public partial class frmAmountInput : Form
    {
        //User User;
        Account Account ;
        public frmAmountInput(Account account)
        {
            Account = account;
            InitializeComponent();
        }

        private void frmAmountInput_Load(object sender, EventArgs e)
        {
            txtAmountInput.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = 0;
            if (Validation.checkdoubleInput(txtAmountInput.Text))
            {
                lblAmountError.Visible = false;
                amount = double.Parse(txtAmountInput.Text);
                if(amount>Account.getLoan())
                {
                    lblAmountError.Visible = true;
                    lblAmountError.Text = "You entered more value than your loan";
                }
                else
                {
                    lblAmountError.Visible = false;
                    Account.widthdrawAmount(amount);
                    Account.subtractLoan(amount);
                    PersonDL.writePersonAccountInFile(frmFirst.accountFileName, ',');
                    this.Hide();
                }
                
            }
            else {
                lblAmountError.Text = "Enter positive number!";
                lblAmountError.Visible = true; }
        }
    }
}
