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

namespace Ex3_Error_Provider
{
    public partial class frmUserControl : Form
    {
        public frmUserControl()
        {
            InitializeComponent();
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string pattern = @"^(\w+)@((yahoo)|(gmail))\.com$";
            if (Regex.IsMatch(this.txtEmail.Text, pattern))
                this.errorProvider1.SetError(txtEmail, "");
            else
                this.errorProvider1.SetError(txtEmail, "Ban nhap sai Email");
        }
    }
}
