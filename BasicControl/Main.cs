using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class frmMain : Form
    {
        private frmLogin login;

        public frmMain()
        {
            InitializeComponent();   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
                //this.Close();
                Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = "http://lms.dlu.edu.vn/";
            Process.Start(strURL);
        }

        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            string str = mtbPhone.Text;
            Console.WriteLine(str);
            if (str != "")
            {
                if (str[0] == '0' && str.Length == 10)
                    errorPhone.SetError(mtbPhone, "");

                else
                    errorPhone.SetError(mtbPhone, "Số điện thoại không được để trống hoặc bắt đầu bằng một số khác 0!");

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Length == 0 || txtPass.Text.Length == 0)
            {
                MessageBox.Show(" User or pass is empty", "Warring",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string infor = "User: " + txtUser.Text + "\n" + "Pass: " + txtPass.Text + "\n" + "Description:\n" + txtDescription.Text;
                MessageBox.Show(infor, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtDescription.Text = "";
        }

        private void btnAddLisst_Click(object sender, EventArgs e)
        {
            int itemSelected = this.listOfClass.SelectedItems.Count - 1;
            if (itemSelected == 0)
            {
                while (itemSelected >= 0)
                {
                    listOfFootball.Items.Add(listOfClass.SelectedItems[itemSelected]);
                    listOfClass.Items.Remove(listOfClass.SelectedItems[itemSelected]);
                    itemSelected -= 1;
                }
            }
            else
            {
                MessageBox.Show("Chọn trên DS lớp", "Warring",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int itemSelected = this.listOfFootball.SelectedItems.Count - 1;
            if (itemSelected == 0)
            {
                while (itemSelected >= 0)
                {
                    listOfClass.Items.Add(listOfFootball.SelectedItems[itemSelected]);
                    listOfFootball.Items.Remove(listOfFootball.SelectedItems[itemSelected]);
                    itemSelected -= 1;
                }
            }
            else
            {
                MessageBox.Show("Chọn trên DS đá banh", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFlat.Checked)
                btnButtonFlat.FlatStyle = FlatStyle.Flat;
            else
                btnButtonFlat.FlatStyle = FlatStyle.Standard;

        }

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColor.Checked)
                btnButton.ForeColor = Color.Red;
            else
                btnButton.ForeColor = Color.Black;
        }

        private void chkBackColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBackColor.Checked)
                btnButton.BackColor = Color.LightCyan;
            else
                btnButton.BackColor = btnButtonFlat.BackColor;
        }

        private void chkListSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < chkListSubject.Items.Count; i++)
            {
                if (this.chkListSubject.GetItemChecked(i) == true)
                {
                    s += this.chkListSubject.Items[i].ToString() + ",";
                }
            }
            MessageBox.Show("Danh sách: " + s, "Infor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox4.SelectedItem.ToString();
            switch (str)
            {
                case "Normal":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "StretchImage":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "AutoSize":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "CenterImage":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "Zoom":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
    }
}
