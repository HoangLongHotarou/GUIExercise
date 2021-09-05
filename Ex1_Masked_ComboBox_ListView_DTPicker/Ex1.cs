using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Masked_ComboBox_ListView_DTPicker
{
    public partial class frmHocSinh : Form
    {

        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            ListViewItem lvItem = new ListViewItem(new string[]{"001","Nguyễn Văn Hùng", "Nam", "08/08/1980", "0633777.888", "8.9" });
            this.lvList.Items.Add(lvItem);
            lvItem = new ListViewItem(new string[] { "002", "Trương Thị Lệ","Nữ", "08/08/1980", "0633999.888", "8.9" });
            this.lvList.Items.Add(lvItem);
            lvItem = new ListViewItem(new string[] { "003", "Nguyễn Hoàng Nam", "Nam", "08/08/1980", "06336666.888", "8.9" });
            this.lvList.Items.Add(lvItem);
            lvItem = new ListViewItem("004");

            lvItem.SubItems.Add("Lê Thị Lan Hương");
            lvItem.SubItems.Add("Nữ");
            lvItem.SubItems.Add("09/11/1987");
            lvItem.SubItems.Add("0633333.555");
            lvItem.SubItems.Add("5.7");
            lvList.Items.Add(lvItem);

            rdMale.Select();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = this.cboID.Text, name = this.txtFullName.Text;
            if(ID.Length>0 && name.Length > 0)
            {
                ListViewItem lvItem = new ListViewItem(this.cboID.Text);
                lvItem.SubItems.Add(this.txtFullName.Text);
                if(this.rdMale.Checked == true)
                {
                    lvItem.SubItems.Add("Nam");
                }
                else
                {
                    lvItem.SubItems.Add("Nữ");
                }
                lvItem.SubItems.Add(this.dtpDate.Value.Date.ToString());
                lvItem.SubItems.Add(this.mtbPhoneNum.Text);
                lvItem.SubItems.Add(this.mtbScore.Text);
                lvList.Items.Add(lvItem);
            }
            else
            {
                MessageBox.Show("Hãy nhập mã số và họ tên");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cboID.Text = "";
            this.txtFullName.Text = "";
            this.mtbPhoneNum.Text = "";
            this.mtbScore.Text = "";
            rdMale.Select();
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            // if multiselected elements
            int i = this.lvList.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lvList.Items.Remove(lvList.SelectedItems[i]);
                i--;
            }
            //Console.WriteLine(lvList.SelectedItems.Count);
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            this.lvList.Items.Clear();
        }
    }
}
