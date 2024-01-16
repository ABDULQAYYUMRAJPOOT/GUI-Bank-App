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
    public partial class frmDepositeAmount : Form
    {
        Account Account;
        string Type;
        public frmDepositeAmount(Account account, string type)
        {
            Type = type;
            Account = account;
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string amount = txtDeposite.Text;
            if (Validation.checkdoubleInput(amount))
            {
                lblError.Visible = false;
                double amount2 = Convert.ToDouble(amount);
                if(Type == "deposite")
                {
                    if (Account.depositAmount(amount2))
                    {
                        PersonDL.writePersonAccountInFile(frmFirst.accountFileName, ',');
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "You have not enough money! Enter valid Input!";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    if (Account.depositAmount(amount2))
                    {
                        Account.applyLoan(amount2);
                        PersonDL.writePersonAccountInFile(frmFirst.accountFileName, ',');
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "You have not enough money! Enter valid Input!";
                        lblError.Visible = true;
                    }
                }
                

            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void frmDepositeAmount_Load(object sender, EventArgs e)
        {
            txtDeposite.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
