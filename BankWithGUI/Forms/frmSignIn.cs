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
    public partial class frmSignIn : Form
    {
       /* public static User user;
        public static Employee employee;*/
        Person SignedInPerson;
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            txtSignInName.Text = "";
            txtSignInPassword.Text = "";
        }

        private void btnSignInFinal_Click(object sender, EventArgs e)
        {
            string name = txtSignInName.Text;
            string password = txtSignInPassword.Text;
            Person person = new Person(name, password);
            person = PersonDL.getPersonFromList(person);
            if (person != null)
            {   
                if (person.getRole() == "user")
                {

                    User user = person as User;
                    Form frmAccPreOrAdd = new frmAccAddOrPresent(user);
                    frmAccPreOrAdd.Show();
                    this.Close() ;

                }
                else
                {

                    SignedInPerson = person as Employee;
                    Form frmEmpMenu = new frmEmpMenu();
                    this.Close();
                    frmEmpMenu.Show();
                }
            }
            else
            {
                lblSignInError.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFirst frm = new frmFirst();
            frm.Show();
        }
    }
}
