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
    public partial class frmDeletAccount : Form
    {
        public frmDeletAccount()
        {
            InitializeComponent();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, password = txtPassword.Text;
            if (PersonDL.isPersonPresent(name, password))
            {
                lblError.Visible = false;
                Person p = new Person(name, password);
                PersonDL.removePerson(p);
                this.Close();
            }
            else
            {
                lblError.Text = "No person found of this name and password!";
                lblError.Visible = true;
            }


        }

        private void frmDeletAccount_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
