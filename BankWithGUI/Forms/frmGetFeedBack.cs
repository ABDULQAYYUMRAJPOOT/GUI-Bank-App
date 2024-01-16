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
    public partial class frmGetFeedBack : Form
    {
        User User;
        public frmGetFeedBack(User user)
        {
            User = user;
            InitializeComponent();
        }

        

        private void btnFeedNext_Click(object sender, EventArgs e)
        {
            string feed = txtFeed.Text;
            if(Validation.checkCharacter(feed,','))
            {
                User.setFeedBack(txtFeed.Text);
                PersonDL.writePersonInFile(frmFirst.personFileName, ',');
                this.Close();
            }
            else
            {
                lblFeedError.Text = "You cannot use comma in your feedBack statement!";
                lblFeedError.Visible = true;
            }

        }

        private void frmGetFeedBack_Load(object sender, EventArgs e)
        {
            txtFeed.Text = "";
        }

        private void txtFeed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
