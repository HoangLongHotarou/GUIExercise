using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooleanAlgebra
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkOperand1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOperand1.Checked == true)
                chkOperand1.Text = "True";
            else
                chkOperand1.Text = "False";
        }

        private void chkOperand2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOperand2.Checked == true)
                chkOperand2.Text = "True";
            else
                chkOperand2.Text = "False";
        }

        private void chkResult_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResult.Checked == true)
                chkResult.Text = "True";
            else
                chkResult.Text = "False";
        }

        private void btnNewOperation_Click(object sender, EventArgs e)
        {
            string[] strBooleanValues = { "True", "False" };
            string[] strOperations = { "A V B", "A ^ B" };
            Random rand = new Random();

            chkOperand1.Text = strBooleanValues[rand.Next(2)];
            chkOperand2.Text = strBooleanValues[rand.Next(2)];

            if (chkOperand1.Text == "True")
                chkOperand1.Checked = true;
            else
                chkOperand1.Checked = false;

            if (chkOperand2.Text == "True")
                chkOperand2.Checked = true;
            else
                chkOperand2.Checked = false;

            lblOperation.Text = strOperations[rand.Next(2)];
        }

        private void btnCheckOperation_Click(object sender, EventArgs e)
        {
            

            if (lblOperation.Text == "A ^ B")
            {
                if (chkResult.Checked == true)
                {
                    if (chkOperand1.Checked == true && chkOperand2.Checked == true)
                        MessageBox.Show("Good Answer");
                    else
                        MessageBox.Show("Wrong Answer");
                }
                else
                {
                    if (chkOperand1.Checked == true && chkOperand2.Checked == true)
                        MessageBox.Show("Wrong Answer");
                    else
                        MessageBox.Show("Good Answer");
                }
            }
            else if (lblOperation.Text == "A V B")
            {
                if (chkResult.Checked == false)
                {
                    if (chkOperand1.Checked == false && chkOperand2.Checked == false)
                        MessageBox.Show("Good Answer");
                    else
                        MessageBox.Show("Wrong Answer");
                }
                else
                {
                    if (chkOperand1.Checked == false && chkOperand2.Checked == false)
                        MessageBox.Show("Wrong Answer");
                    else
                        MessageBox.Show("Good Answer");
                }
            }


        }
    }
}
