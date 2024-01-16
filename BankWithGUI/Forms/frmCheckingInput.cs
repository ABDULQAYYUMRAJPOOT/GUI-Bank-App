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
    public partial class frmCheckingInput : Form
    {
        User User;
        public frmCheckingInput(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnCheckingFinal_Click(object sender, EventArgs e)
        {
            string id = txtCheckingID.Text;
            string interest = txtInterestChecking.Text;
            if(User.isIdPresent(id))
            {
                lblError.Text = "This id is already present user different id!";
                lblError.Visible = true;
            }
            else
            {
                if (Validation.checkdoubleInput(interest) && Validation.checkCharacter(id, ','))
                {
                    lblError.Visible = false;
                    double Interest = double.Parse(interest);
                    Checking check = new Checking(id, "checking", Interest);
                    User.addAccount(check);
                    this.Hide();
                    Form frmAccAddOrPre = new frmAccAddOrPresent(User);
                    frmAccAddOrPre.Show();
                    PersonDL.writePersonAccountInFile(frmFirst.accountFileName, ',');
                }
                else
                {
                    lblError.Text = "You cannot use comma and Enter interest in numbers!";
                    lblError.Visible = true;
                }
            }
            
            
        }

        private void frmCheckingInput_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtCheckingID.Text = "";
            txtInterestChecking.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccount frm = new frmAccount(User);
            frm.Show();
        }
    }
}
