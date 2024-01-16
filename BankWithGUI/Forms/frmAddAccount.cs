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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFinal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, password = txtPassword.Text;
            if (PersonDL.isNamePresent(name))
            {
                lblError.Text = "This name is already present! (use different name)";
                lblError.Visible = true;
            }
            else
            {
                User user = new User(name, password, "user");
                PersonDL.addPerson(user);
                PersonDL.writePersonAccountInFile(frmFirst.personFileName, ',');
                this.Close();
            }
           
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
