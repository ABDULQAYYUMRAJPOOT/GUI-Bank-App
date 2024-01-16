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
    public partial class frmDepositByEmp : Form
    {
        public frmDepositByEmp()
        {
            InitializeComponent();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, password = txtPassword.Text , money = txtAmount.Text , id= txtAccID.Text;
            User user = new User(name, password, "user");
            Person person = PersonDL.getPersonFromList(user);
            if (person != null)
            {
                lblError.Visible = false;
                User p = person as User;
                double amount = double.Parse(money);
                Account account = p.getAccount(id);
                if (account != null)
                {
                    lblError.Visible=false;
                    account.depositAmount(amount);
                    this.Close();
                }
                else
                {
                    lblError.Text = "No account of this id found!";
                    lblError.Visible = true;
                }

            }
            else
            {
                lblError.Text = "No person found!";
                lblError.Visible = true;
            }

            
            
            
            
            
        }

        private void frmDepositByEmp_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
