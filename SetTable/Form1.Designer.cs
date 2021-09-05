
namespace SetTable
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flTang2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvTableList = new System.Windows.Forms.ListView();
            this.gpb2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flTang1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gpb3 = new System.Windows.Forms.GroupBox();
            this.flTang3 = new System.Windows.Forms.FlowLayoutPanel();
            this.imlTable = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.gpb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpb3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flTang2
            // 
            this.flTang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTang2.Location = new System.Drawing.Point(3, 16);
            this.flTang2.Name = "flTang2";
            this.flTang2.Size = new System.Drawing.Size(330, 190);
            this.flTang2.TabIndex = 0;
            // 
            // lvTableList
            // 
            this.lvTableList.HideSelection = false;
            this.lvTableList.LargeImageList = this.imlTable;
            this.lvTableList.Location = new System.Drawing.Point(545, 68);
            this.lvTableList.Name = "lvTableList";
            this.lvTableList.Size = new System.Drawing.Size(470, 578);
            this.lvTableList.SmallImageList = this.imlTable;
            this.lvTableList.TabIndex = 1;
            this.lvTableList.UseCompatibleStateImageBehavior = false;
            // 
            // gpb2
            // 
            this.gpb2.Controls.Add(this.flTang2);
            this.gpb2.Location = new System.Drawing.Point(36, 252);
            this.gpb2.Name = "gpb2";
            this.gpb2.Size = new System.Drawing.Size(336, 209);
            this.gpb2.TabIndex = 2;
            this.gpb2.TabStop = false;
            this.gpb2.Text = "Tầng 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flTang1);
            this.groupBox1.Location = new System.Drawing.Point(36, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tầng 1";
            // 
            // flTang1
            // 
            this.flTang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTang1.Location = new System.Drawing.Point(3, 16);
            this.flTang1.Name = "flTang1";
            this.flTang1.Size = new System.Drawing.Size(330, 191);
            this.flTang1.TabIndex = 0;
            // 
            // gpb3
            // 
            this.gpb3.Controls.Add(this.flTang3);
            this.gpb3.Location = new System.Drawing.Point(39, 467);
            this.gpb3.Name = "gpb3";
            this.gpb3.Size = new System.Drawing.Size(333, 214);
            this.gpb3.TabIndex = 3;
            this.gpb3.TabStop = false;
            this.gpb3.Text = "Tầng 3";
            // 
            // flTang3
            // 
            this.flTang3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTang3.Location = new System.Drawing.Point(3, 16);
            this.flTang3.Name = "flTang3";
            this.flTang3.Size = new System.Drawing.Size(327, 195);
            this.flTang3.TabIndex = 0;
            // 
            // imlTable
            // 
            this.imlTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTable.ImageStream")));
            this.imlTable.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTable.Images.SetKeyName(0, "tableOff.png");
            this.imlTable.Images.SetKeyName(1, "table.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(60, 20);
            this.tsmAdmin.Text = "Quản lý";
            this.tsmAdmin.Click += new System.EventHandler(this.tsmAdmin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 703);
            this.Controls.Add(this.gpb3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb2);
            this.Controls.Add(this.lvTableList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpb2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpb3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flTang2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView lvTableList;
        private System.Windows.Forms.GroupBox gpb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flTang1;
        private System.Windows.Forms.GroupBox gpb3;
        private System.Windows.Forms.FlowLayoutPanel flTang3;
        private System.Windows.Forms.ImageList imlTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
    }
}

