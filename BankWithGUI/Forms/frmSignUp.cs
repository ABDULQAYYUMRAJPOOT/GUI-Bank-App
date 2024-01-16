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
    public partial class frmSignUp : Form
    {
        Person person;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";

        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, password = txtPassword.Text;
            if(Validation.checkCharacter(name,',') && Validation.checkCharacter(password,',') && Validation.checkCharacter(txtID.Text,','))
            {
                if (Validation.checkPassword(password, 8))
                {
                    if (PersonDL.isNamePresent(name))
                    {
                        lblError.Text = "This name is already present You cannot take this! (User different name)";
                        lblError.Visible = true;
                    }
                    else
                    {
                        lblError.Visible = false;
                        if (rbtnAdmin.Checked)
                        {
                            if (PersonDL.isEmpPresent())
                            {
                                lblError.Text = "You cannot choose employee because one is already present!";
                                lblError.Visible = true;
                            }
                            else
                            {
                                lblIDEmp.Visible = true;
                                txtID.Visible = true;
                                string id = txtID.Text;
                                person = new Employee(name, password, "employee", id);
                                PersonDL.addPerson(person);
                                this.Hide();
                                PersonDL.writePersonInFile(frmFirst.personFileName, ',');
                            }
                        }
                        else if (rbtnUser.Checked)
                        {
                            lblIDEmp.Visible = false;
                            txtID.Visible = false;
                            person = new User(name, password, "user");
                            PersonDL.addPerson(person);
                            PersonDL.writePersonInFile(frmFirst.personFileName, ',');
                            this.Hide();
                        }
                        else
                        {
                            lblError.Text = "Choose User or Admin";
                            lblError.Visible = true;
                        }
                    }

                }
                else
                {
                    lblError.Text = "Enter Password of character more or equal to 8 and less than 16!";
                    lblError.Visible = true;
                }
                }
            else
            {
                lblError.Text = "Enter Name and Password(8 or more character) You cannot use comma!";
                lblError.Visible = true;
            }
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnUser_CheckedChanged(object sender, EventArgs e)
        {
            lblIDEmp.Visible = false;
            txtID.Visible = false;
        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            lblIDEmp.Visible = true;
            txtID.Visible = true;
        }
    }
}
