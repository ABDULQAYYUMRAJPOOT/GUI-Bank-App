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
    public partial class frmIDInput : Form
    {
        string idInput ;
        Account account;
        User User;
        public frmIDInput(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnIDFinal_Click(object sender, EventArgs e)
        {
            
            lblIdInputError.Visible = false;
            idInput= txtIDInput.Text;
            account = User.getAccount(idInput);
            if (account != null)
            {
                
                if (account.getType() == "checking")
                {
                    this.Close();
                    Checking Check = account as Checking;
                    frmUserMenu frmUser = new frmUserMenu(Check, User);
                    frmUser.Show();
                }
                else if (account.getType() == "saving")
                {
                    Saving saving = account as Saving;
                    frmUserMenu frmUser = new frmUserMenu(saving, User);
                    this.Close();
                    frmUser.Show();
                }
            }
            else { lblIdInputError.Visible = true; }
            

        }

        private void frmIDInput_Load(object sender, EventArgs e)
        {
            txtIDInput.Text = "";
        }

        private void btnBackFromIDInput_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
