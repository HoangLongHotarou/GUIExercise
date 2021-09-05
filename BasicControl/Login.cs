using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.CompareTo("A@gmail.com")==0 && this.txtPass.Text.CompareTo("123") == 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Email or pass incorect!!!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPass.Text = "";
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string pattern = @"^(\w+)@((yahoo)|(gmail))\.com$";
            if (Regex.IsMatch(this.txtEmail.Text, pattern))
                this.errorProvider1.SetError(txtEmail, "");
            else
                this.errorProvider1.SetError(txtEmail, "Email is wrong");
        }


        private void txtPass_Validated(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length == 0)
            {
                this.errorProvider2.SetError(txtPass, "Pass hasn't been Entered");
            }
        }

        
    }
}
