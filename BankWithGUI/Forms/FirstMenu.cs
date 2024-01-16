using BankWithGUI.Forms;
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

namespace BankWithGUI
{
    public partial class frmFirst : Form
    {
        public static string personFileName = "person.txt";
        public static string accountFileName = "accounts.txt";
        public static Form frmSignInUp;
        public frmFirst()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PersonDL.readPersonFromFile(personFileName,',');
            PersonDL.readAccountDetailFile(accountFileName, ',');
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            frmSignInUp = new frmSignUp();
            frmSignInUp.Show();
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignInUp = new frmSignIn();
            frmSignInUp.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            
        }
    }
}
