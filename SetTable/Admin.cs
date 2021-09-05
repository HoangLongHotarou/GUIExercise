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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadTablesDetail();
        }

        private void LoadTablesDetail()
        {
            lvDetailTables.Items.Clear();
            foreach (var table in WorkingContext.tables)
            {
                ListViewItem item = new ListViewItem(table.ID.ToString());
                item.SubItems.Add(table.Table);
                item.SubItems.Add(table.Status.ToString());
                item.SubItems.Add(table.Floor.ToString());
                lvDetailTables.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiningTable table = new DiningTable(WorkingContext.tables.Max(p=>p.ID)+1,txtNameTable.Text,rbUsed.Checked?1:0,int.Parse(cbbFloor.Text));
            WorkingContext.tables.Add(table);
            LoadTablesDetail();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var tableName = txtNameTable.Text;
            var floor = int.Parse(cbbFloor.Text);
            var tableId = int.Parse(txtIDtable.Text);
            var tableStatus = rbUsed.Checked ? 1 : 0;
            var table = WorkingContext.tables.FirstOrDefault(p => p.ID == tableId);
            table.Table = tableName;
            table.Floor = floor;
            table.Status = tableStatus;
            LoadTablesDetail();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var tableId = int.Parse(txtIDtable.Text);
            WorkingContext.tables.RemoveAll(p => p.ID == tableId);
            LoadTablesDetail();
        }

        private void lvDetailTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var count = lvDetailTables.SelectedItems.Count;
            if (count > 0)
            {
                var item = lvDetailTables.SelectedItems[0];
                txtIDtable.Text = item.SubItems[0].Text;
                txtNameTable.Text = item.SubItems[1].Text;
                cbbFloor.SelectedIndex = int.Parse(item.SubItems[3].Text) - 1;
            }
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
