using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetTable
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            LoadTableAtFlowLayout();
            LoadTableList();
        }

        private void LoadTableAtFlowLayout()
        {
            var floors = new[] { flTang1, flTang2, flTang3 };

            foreach(var floor in floors)
            {
                floor.Controls.Clear();
            }
            foreach (var table in WorkingContext.tables)
            {
                Button btn = new Button();
                btn.Text = table.Table + "\r\n" + (table.Status == 1 ? "Co" : "Khong");
                btn.BackColor = table.Status == 0 ? Color.AntiqueWhite : Color.Aquamarine;
                btn.Height = 40;
                btn.Width = 80;
                toolTip1.SetToolTip(btn, $"Tang {table.Floor}");
                floors[table.Floor - 1].Controls.Add(btn);
            }
        }

        private void LoadTableList()
        {
            ListViewGroup floor1 = new ListViewGroup("Tầng 1", HorizontalAlignment.Center);
            ListViewGroup floor2 = new ListViewGroup("Tầng 2", HorizontalAlignment.Center);
            ListViewGroup floor3 = new ListViewGroup("Tầng 3", HorizontalAlignment.Center);

            lvTableList.Groups.Add(floor1);
            lvTableList.Groups.Add(floor2);
            lvTableList.Groups.Add(floor3);

            var floorsGroup = new[] { floor1, floor2, floor3 };
            
            lvTableList.Items.Clear();
            foreach (var table in WorkingContext.tables)
            {
                ListViewItem item = new ListViewItem(table.Table, table.Status);
                item.Group = floorsGroup[table.Floor - 1];
                lvTableList.Items.Add(item);
            }
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {

            using (frmAdmin frm = new frmAdmin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTableAtFlowLayout();
                    LoadTableList();
                }
            }
        }
    }
}
