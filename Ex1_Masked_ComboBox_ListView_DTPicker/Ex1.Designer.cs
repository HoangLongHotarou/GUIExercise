
namespace Ex1_Masked_ComboBox_ListView_DTPicker
{
    partial class frmHocSinh
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
            this.cboID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFermale = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelItem = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtbPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.mtbScore = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Items.AddRange(new object[] {
            "000",
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
            "009",
            "010"});
            this.cboID.Location = new System.Drawing.Point(92, 30);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(121, 21);
            this.cboID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm tổng kết";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(92, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(225, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(103, 110);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(47, 17);
            this.rdMale.TabIndex = 10;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFermale
            // 
            this.rdFermale.AutoSize = true;
            this.rdFermale.Location = new System.Drawing.Point(204, 110);
            this.rdFermale.Name = "rdFermale";
            this.rdFermale.Size = new System.Drawing.Size(39, 17);
            this.rdFermale.TabIndex = 11;
            this.rdFermale.TabStop = true;
            this.rdFermale.Text = "Nữ";
            this.rdFermale.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(467, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colSex,
            this.colDate,
            this.colPhoneNum,
            this.colScore});
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(35, 212);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(632, 252);
            this.lvList.TabIndex = 15;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "Mã Số";
            this.colID.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Họ tên";
            this.colName.Width = 120;
            // 
            // colSex
            // 
            this.colSex.Text = "Giới tính";
            this.colSex.Width = 100;
            // 
            // colDate
            // 
            this.colDate.Text = "Ngày Sinh";
            this.colDate.Width = 100;
            // 
            // colPhoneNum
            // 
            this.colPhoneNum.Text = "Số ĐT";
            this.colPhoneNum.Width = 110;
            // 
            // colScore
            // 
            this.colScore.Text = "Điểm Tổng kết";
            this.colScore.Width = 100;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(219, 482);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(98, 23);
            this.btnDelItem.TabIndex = 16;
            this.btnDelItem.Text = "Xóa Item chọn";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(365, 482);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(75, 23);
            this.btnDelAll.TabIndex = 17;
            this.btnDelAll.Text = "Xóa tất cả";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtbPhoneNum
            // 
            this.mtbPhoneNum.Location = new System.Drawing.Point(467, 70);
            this.mtbPhoneNum.Mask = "(999) 000-0000";
            this.mtbPhoneNum.Name = "mtbPhoneNum";
            this.mtbPhoneNum.Size = new System.Drawing.Size(200, 20);
            this.mtbPhoneNum.TabIndex = 19;
            // 
            // mtbScore
            // 
            this.mtbScore.Location = new System.Drawing.Point(467, 116);
            this.mtbScore.Mask = "00.0";
            this.mtbScore.Name = "mtbScore";
            this.mtbScore.Size = new System.Drawing.Size(103, 20);
            this.mtbScore.TabIndex = 20;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 534);
            this.Controls.Add(this.mtbScore);
            this.Controls.Add(this.mtbPhoneNum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rdFermale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboID);
            this.Name = "frmHocSinh";
            this.Text = "Ví dụ sử dụng MaskedTextBox...";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFermale;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colScore;
        private System.Windows.Forms.ColumnHeader colDate;
        public System.Windows.Forms.ColumnHeader colPhoneNum;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNum;
        private System.Windows.Forms.MaskedTextBox mtbScore;
    }
}

