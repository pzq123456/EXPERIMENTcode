namespace 实验一
{
    partial class Form3
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
            this.AddAccount = new System.Windows.Forms.Button();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Inquiry = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.lebShow2 = new System.Windows.Forms.Label();
            this.ShowFlow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAccount
            // 
            this.AddAccount.Location = new System.Drawing.Point(12, 12);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(199, 23);
            this.AddAccount.TabIndex = 0;
            this.AddAccount.Text = "创建账户";
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.Location = new System.Drawing.Point(12, 59);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(75, 23);
            this.Withdrawal.TabIndex = 1;
            this.Withdrawal.Text = "取款";
            this.Withdrawal.UseVisualStyleBackColor = true;
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(12, 117);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(75, 23);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "存款";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Inquiry
            // 
            this.Inquiry.Location = new System.Drawing.Point(12, 175);
            this.Inquiry.Name = "Inquiry";
            this.Inquiry.Size = new System.Drawing.Size(199, 23);
            this.Inquiry.TabIndex = 3;
            this.Inquiry.Text = "查询余额";
            this.Inquiry.UseVisualStyleBackColor = true;
            this.Inquiry.Click += new System.EventHandler(this.Inquiry_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(217, 16);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(200, 182);
            this.lblShow.TabIndex = 6;
            // 
            // lebShow2
            // 
            this.lebShow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lebShow2.Location = new System.Drawing.Point(12, 214);
            this.lebShow2.Name = "lebShow2";
            this.lebShow2.Size = new System.Drawing.Size(405, 182);
            this.lebShow2.TabIndex = 7;
            this.lebShow2.Text = "账户流水";
            // 
            // ShowFlow
            // 
            this.ShowFlow.Location = new System.Drawing.Point(283, 415);
            this.ShowFlow.Name = "ShowFlow";
            this.ShowFlow.Size = new System.Drawing.Size(134, 23);
            this.ShowFlow.TabIndex = 8;
            this.ShowFlow.Text = "打印流水";
            this.ShowFlow.UseVisualStyleBackColor = true;
            this.ShowFlow.Click += new System.EventHandler(this.ShowFlow_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 479);
            this.Controls.Add(this.ShowFlow);
            this.Controls.Add(this.lebShow2);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Inquiry);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.AddAccount);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.Button Withdrawal;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Inquiry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lebShow2;
        private System.Windows.Forms.Button ShowFlow;
    }
}