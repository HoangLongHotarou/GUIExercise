using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundedInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double pricipal = Double.Parse(tbxPrincipal.Text);
            double interestRate = Double.Parse(tbxInterestRate.Text) / 100;
            int year = (int)nudYear.Value;
            int compoundType = 0;

            if (rdoMonth.Checked == true)
                compoundType = 12;
            else if (rdoQuaterly.Checked == true)
                compoundType = 4;
            else if (rdoSemiannually.Checked == true)
                compoundType = 6;
            else if (rdoAnnually.Checked == true)
                compoundType = 1;

            double i = interestRate / compoundType;
            double n = year * compoundType;

            double futureValue = pricipal * (Math.Pow(1 + i, n));
            double interestEearn = futureValue - pricipal;

            tbxInterestEarned.Text =  interestEearn.ToString("C");
            tbxFutureValue.Text = futureValue.ToString("C");
        }
    }
}
