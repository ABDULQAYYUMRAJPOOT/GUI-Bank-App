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
    public partial class frmAccount : Form
    {
        User User;
        public frmAccount(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnChecking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmChecking = new frmCheckingInput(User);
            frmChecking.Show();
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmSaving = new frmSavingInput(User);
            frmSaving.Show();
        }

        private void btnBackFromAccountType_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmaccPres = new frmAccAddOrPresent(User);
            frmaccPres.Show();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
