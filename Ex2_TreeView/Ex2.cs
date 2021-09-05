using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_TreeView
{
    public partial class frmTreeView : Form
    {
        private TreeNode mySelectedNode;

        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            TreeNode tn, subtn;
            //this.treeView1.CheckBoxes = true;
            tn = this.treeView1.Nodes.Add("Loai hoa");
            tn.ImageIndex = 0;
            subtn = new TreeNode("Hoa Lan",1,1);
            tn.Nodes.Add(subtn);
            subtn = new TreeNode("Hoa Hong",2,2);
            tn.Nodes.Add(subtn);

            tn = this.treeView1.Nodes.Add("Trai Cay");
            tn.ImageIndex = 3;
            tn.SelectedImageIndex = 3;
            subtn = new TreeNode("Trai nho",4,4);
            tn.Nodes.Add(subtn);
            subtn = new TreeNode("Trai tao",5,5);
            tn.Nodes.Add(subtn);
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                mySelectedNode = treeView1.GetNodeAt(e.X, e.Y);
                //Console.WriteLine(mySelectedNode.FullPath);
                this.toolStripLabel1.Text = "\\" + mySelectedNode.FullPath;
            }
            catch (Exception)
            {

            }
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1)
                        e.Node.EndEdit(false);
                    else
                    {
                        e.CancelEdit = true;
                    }
                }
                else
                {
                    e.CancelEdit = true;
                    MessageBox.Show("Nhãn không có giá trị.\nNhãn không thể có khoảng trắng",
                    "Node Label Edit",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    e.Node.BeginEdit();
                }
                this.treeView1.LabelEdit = false;
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.treeView1.CollapseAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (mySelectedNode != null) // and mySelectedNode.parent != null
            {
                treeView1.SelectedNode = mySelectedNode;
                treeView1.LabelEdit = true;
                if (!mySelectedNode.IsEditing)
                    mySelectedNode.BeginEdit();
                else 
                    mySelectedNode.EndEdit(true);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (mySelectedNode != null) // and mySelectedNode.parent != null
            {
                treeView1.SelectedNode = mySelectedNode;
                treeView1.Nodes.Remove(mySelectedNode);
                this.toolStripLabel1.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
