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
    public partial class frmAddAmountInAcc : Form
    {
        public frmAddAmountInAcc()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackFromDepEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepositEmp_Click(object sender, EventArgs e)
        {
            string name = txtDepNameEmp.Text, id = txtID.Text, amount = txtDepAmountEmp.Text;
            User user = PersonDL.getPersonFromList(name);
            if (user != null)
            {
                lblDepositError.Visible = false;
                Account account = user.getAccount(id);
                if (account != null)
                {
                    lblDepositError.Visible = false;
                    if(Validation.checkdoubleInput(amount))
                    {
                        double money = double.Parse(amount);
                        account.depositAmount(money);
                        this.Close();
                    }
                    else
                    {
                        lblDepositError.Text = "Enter valid amount!";
                        lblDepositError.Visible = true;
                    }
                }
                else
                {
                    lblDepositError.Text = "No account of this id found!";
                    lblDepositError.Visible = true;
                }
            }
            {
                lblDepositError.Text = "No user of this name found!";
                lblDepositError.Visible = true;
            }
        }

        private void frmAddAmountInAcc_Load(object sender, EventArgs e)
        {
            txtDepAmountEmp.Text= string.Empty;
            txtDepNameEmp.Text = string.Empty;
            txtID.Text = string.Empty;
        }
    }
}
