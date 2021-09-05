namespace CompoundedInterest
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxInterestRate = new System.Windows.Forms.MaskedTextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrincipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAnnually = new System.Windows.Forms.RadioButton();
            this.rdoSemiannually = new System.Windows.Forms.RadioButton();
            this.rdoQuaterly = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxFutureValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxInterestEarned = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxInterestRate);
            this.groupBox1.Controls.Add(this.nudYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxPrincipal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Setup";
            // 
            // tbxInterestRate
            // 
            this.tbxInterestRate.Location = new System.Drawing.Point(108, 45);
            this.tbxInterestRate.Mask = "00.00";
            this.tbxInterestRate.Name = "tbxInterestRate";
            this.tbxInterestRate.Size = new System.Drawing.Size(100, 20);
            this.tbxInterestRate.TabIndex = 5;
            this.tbxInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(108, 71);
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(100, 20);
            this.nudYear.TabIndex = 2;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudYear.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Periods:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate:";
            // 
            // tbxPrincipal
            // 
            this.tbxPrincipal.Location = new System.Drawing.Point(108, 19);
            this.tbxPrincipal.Name = "tbxPrincipal";
            this.tbxPrincipal.Size = new System.Drawing.Size(100, 20);
            this.tbxPrincipal.TabIndex = 1;
            this.tbxPrincipal.Text = "0.00";
            this.tbxPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAnnually);
            this.groupBox2.Controls.Add(this.rdoSemiannually);
            this.groupBox2.Controls.Add(this.rdoQuaterly);
            this.groupBox2.Controls.Add(this.rdoMonth);
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compound Frequency";
            // 
            // rdoAnnually
            // 
            this.rdoAnnually.AutoSize = true;
            this.rdoAnnually.Location = new System.Drawing.Point(30, 91);
            this.rdoAnnually.Name = "rdoAnnually";
            this.rdoAnnually.Size = new System.Drawing.Size(65, 17);
            this.rdoAnnually.TabIndex = 3;
            this.rdoAnnually.TabStop = true;
            this.rdoAnnually.Text = "Annually";
            this.rdoAnnually.UseVisualStyleBackColor = true;
            // 
            // rdoSemiannually
            // 
            this.rdoSemiannually.AutoSize = true;
            this.rdoSemiannually.Location = new System.Drawing.Point(28, 68);
            this.rdoSemiannually.Name = "rdoSemiannually";
            this.rdoSemiannually.Size = new System.Drawing.Size(87, 17);
            this.rdoSemiannually.TabIndex = 2;
            this.rdoSemiannually.TabStop = true;
            this.rdoSemiannually.Text = "Semiannually";
            this.rdoSemiannually.UseVisualStyleBackColor = true;
            // 
            // rdoQuaterly
            // 
            this.rdoQuaterly.AutoSize = true;
            this.rdoQuaterly.Location = new System.Drawing.Point(28, 45);
            this.rdoQuaterly.Name = "rdoQuaterly";
            this.rdoQuaterly.Size = new System.Drawing.Size(67, 17);
            this.rdoQuaterly.TabIndex = 1;
            this.rdoQuaterly.TabStop = true;
            this.rdoQuaterly.Text = "Quarterly";
            this.rdoQuaterly.UseVisualStyleBackColor = true;
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Checked = true;
            this.rdoMonth.Location = new System.Drawing.Point(28, 22);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(62, 17);
            this.rdoMonth.TabIndex = 0;
            this.rdoMonth.TabStop = true;
            this.rdoMonth.Text = "Monthly";
            this.rdoMonth.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(471, 24);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxFutureValue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbxInterestEarned);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // tbxFutureValue
            // 
            this.tbxFutureValue.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFutureValue.Location = new System.Drawing.Point(318, 31);
            this.tbxFutureValue.Name = "tbxFutureValue";
            this.tbxFutureValue.ReadOnly = true;
            this.tbxFutureValue.Size = new System.Drawing.Size(80, 20);
            this.tbxFutureValue.TabIndex = 11;
            this.tbxFutureValue.Text = "0.00";
            this.tbxFutureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Amount Earned:";
            // 
            // tbxInterestEarned
            // 
            this.tbxInterestEarned.BackColor = System.Drawing.SystemColors.Window;
            this.tbxInterestEarned.Location = new System.Drawing.Point(108, 31);
            this.tbxInterestEarned.Name = "tbxInterestEarned";
            this.tbxInterestEarned.ReadOnly = true;
            this.tbxInterestEarned.Size = new System.Drawing.Size(80, 20);
            this.tbxInterestEarned.TabIndex = 8;
            this.tbxInterestEarned.Text = "0.00";
            this.tbxInterestEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interest Earned:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compounded Interest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoAnnually;
        private System.Windows.Forms.RadioButton rdoSemiannually;
        private System.Windows.Forms.RadioButton rdoQuaterly;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxFutureValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxInterestEarned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbxInterestRate;
    }
}

