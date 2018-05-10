namespace CustomerDataV1
{
    partial class FormMoneyInOut
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnMoneyIn = new System.Windows.Forms.Button();
            this.btnMoneyOut = new System.Windows.Forms.Button();
            this.txtNewAccountBalance = new System.Windows.Forms.TextBox();
            this.lblNewBal = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(69, 53);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(63, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "e-mail";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(63, 85);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(42, 13);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(69, 101);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 14;
            // 
            // btnMoneyIn
            // 
            this.btnMoneyIn.Location = new System.Drawing.Point(41, 150);
            this.btnMoneyIn.Name = "btnMoneyIn";
            this.btnMoneyIn.Size = new System.Drawing.Size(75, 23);
            this.btnMoneyIn.TabIndex = 15;
            this.btnMoneyIn.Text = "money in";
            this.btnMoneyIn.UseVisualStyleBackColor = true;
            this.btnMoneyIn.Click += new System.EventHandler(this.btnMoneyIn_Click);
            // 
            // btnMoneyOut
            // 
            this.btnMoneyOut.Location = new System.Drawing.Point(122, 150);
            this.btnMoneyOut.Name = "btnMoneyOut";
            this.btnMoneyOut.Size = new System.Drawing.Size(75, 23);
            this.btnMoneyOut.TabIndex = 15;
            this.btnMoneyOut.Text = "money out";
            this.btnMoneyOut.UseVisualStyleBackColor = true;
            this.btnMoneyOut.Click += new System.EventHandler(this.btnMoneyOut_Click);
            // 
            // txtNewAccountBalance
            // 
            this.txtNewAccountBalance.Location = new System.Drawing.Point(65, 218);
            this.txtNewAccountBalance.Name = "txtNewAccountBalance";
            this.txtNewAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.txtNewAccountBalance.TabIndex = 17;
            // 
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Location = new System.Drawing.Point(59, 202);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(110, 13);
            this.lblNewBal.TabIndex = 16;
            this.lblNewBal.Text = "new account balance";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(133, 271);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(30, 271);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 18;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FormMoneyInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 318);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtNewAccountBalance);
            this.Controls.Add(this.lblNewBal);
            this.Controls.Add(this.btnMoneyOut);
            this.Controls.Add(this.btnMoneyIn);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblEmail);
            this.Name = "FormMoneyInOut";
            this.Text = "FormMoneyInOut";
            this.Load += new System.EventHandler(this.FormMoneyInOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnMoneyIn;
        private System.Windows.Forms.Button btnMoneyOut;
        private System.Windows.Forms.TextBox txtNewAccountBalance;
        private System.Windows.Forms.Label lblNewBal;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAbort;
    }
}