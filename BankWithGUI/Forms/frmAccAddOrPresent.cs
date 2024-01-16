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
    public partial class frmAccAddOrPresent : Form
    {
        User User;
        public frmAccAddOrPresent(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmAccType = new frmAccount(User);
            frmAccType.Show();
        }

        private void btnPresentAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmAccIdInput = new frmIDInput(User);
            frmAccIdInput.Show();
        }

        private void btnBackFromAddOrPresent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmsignIn = new frmSignIn();
            frmsignIn.Show();
        }

        private void frmAccAddOrPresent_Load(object sender, EventArgs e)
        {

        }
    }
}
