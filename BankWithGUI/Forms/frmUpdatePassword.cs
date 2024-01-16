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
    public partial class frmUpdatePassword : Form
    {
        User User;
        public frmUpdatePassword(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            txtNewPassUser.Text = "";
            txtOldPassUser.Text = "";
        }

        private void btnUpdateFinalUser_Click(object sender, EventArgs e)
        {
            string old = txtOldPassUser.Text;
            string New = txtNewPassUser.Text;
            if (old == User.getPassowrd())
            {
                if(Validation.checkCharacter(New,',') && Validation.checkPassword(New,8))
                {
                    lblUpdateError.Visible = false;
                    User.setPassword(New);
                    PersonDL.writePersonInFile(frmFirst.personFileName, ',');
                    PersonDL.writePersonAccountInFile(frmFirst.accountFileName, ',');

                    this.Close();
                }
                else
                {
                    lblUpdateError.Text = "You cannot use comma! Enter password of character b/w 8 and 16!";
                    lblUpdateError.Visible = true;
                }
                
            }
            else
            {
                lblUpdateError.Visible = true;
            }
        }
    }
}
