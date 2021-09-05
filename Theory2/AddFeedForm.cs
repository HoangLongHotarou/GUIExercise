using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory2
{
    public partial class AddFeedForm : Form
    {
        private readonly NewsFeedManager _newsManager;

        public bool HasChanged { get; set; }

        public AddFeedForm(NewsFeedManager newManager)
        {
            _newsManager = newManager;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var publisher = cbbPubisher.Text;
            var category = txtCategory.Text;
            var rssLink = txtRSSLink.Text;

            if(string.IsNullOrEmpty(publisher)|| string.IsNullOrEmpty(category) || string.IsNullOrEmpty(rssLink))
            {
                MessageBox.Show("Ban phai nhap day du");
                return;
            }
            HasChanged = true;
            var success = _newsManager.AddCategory(publisher, category, rssLink, false);
            if (success)
            {
                cbbPubisher.Text = "";
                txtCategory.Text = "";
                txtRSSLink.Text = "";
                return;
            }
            if(MessageBox.Show("Ban muon cap nhat ko", "Thong bao",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _newsManager.AddCategory(publisher, category, rssLink, true);
                cbbPubisher.Text = "";
                txtCategory.Text = "";
                txtRSSLink.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
