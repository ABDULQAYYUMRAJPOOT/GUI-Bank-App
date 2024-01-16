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
    public partial class frmSavingInput : Form
    {
        User User;
        public frmSavingInput(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void frmSavingInput_Load(object sender, EventArgs e)
        {
            txtIDInput.Text = "";
            txtInterestRateInput.Text = "";
        }

       
       

        private void btnSavingFinal_Click(object sender, EventArgs e)
        {
            string id = txtIDInput.Text;
            string interestRate = txtInterestRateInput.Text;
            if (User.isIdPresent(id))
            {
                lblError.Text = "This id is already present user different id!";
                lblError.Visible = true;
            }
            else
            {
                if (Validation.checkdoubleInput(interestRate) && Validation.checkCharacter(id, ','))
                {
                    lblError.Visible = false;
                    double Interest = double.Parse(interestRate);
                    Saving saving = new Saving(id, "saving", Interest);
                    User.addAccount(saving);
                    Form frmAccAddOrPre = new frmAccAddOrPresent(User);
                    frmAccAddOrPre.Show();
                    PersonDL.writePersonAccountInFile(frmFirst.accountFileName, ',');
                    this.Close();
                }
                else
                {
                    lblError.Text = "You cannot use Comma Enter amount in Numbers!";
                    lblError.Visible = true;
                }
            }
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccAddOrPresent frm = new frmAccAddOrPresent(User);
            frm.Show();
        }
    }
}
