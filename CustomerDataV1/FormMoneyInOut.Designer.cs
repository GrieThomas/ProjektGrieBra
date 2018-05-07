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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnMoneyIn = new System.Windows.Forms.Button();
            this.btnMoneyOut = new System.Windows.Forms.Button();
            this.txtNewAccountBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(171, 39);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(88, 20);
            this.txtMail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(98, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "e-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(171, 81);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 14;
            // 
            // btnMoneyIn
            // 
            this.btnMoneyIn.Location = new System.Drawing.Point(81, 185);
            this.btnMoneyIn.Name = "btnMoneyIn";
            this.btnMoneyIn.Size = new System.Drawing.Size(75, 23);
            this.btnMoneyIn.TabIndex = 15;
            this.btnMoneyIn.Text = "money in";
            this.btnMoneyIn.UseVisualStyleBackColor = true;
            this.btnMoneyIn.Click += new System.EventHandler(this.btnMoneyIn_Click);
            // 
            // btnMoneyOut
            // 
            this.btnMoneyOut.Location = new System.Drawing.Point(196, 185);
            this.btnMoneyOut.Name = "btnMoneyOut";
            this.btnMoneyOut.Size = new System.Drawing.Size(75, 23);
            this.btnMoneyOut.TabIndex = 15;
            this.btnMoneyOut.Text = "money out";
            this.btnMoneyOut.UseVisualStyleBackColor = true;
            this.btnMoneyOut.Click += new System.EventHandler(this.btnMoneyOut_Click);
            // 
            // txtNewAccountBalance
            // 
            this.txtNewAccountBalance.Location = new System.Drawing.Point(171, 247);
            this.txtNewAccountBalance.Name = "txtNewAccountBalance";
            this.txtNewAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.txtNewAccountBalance.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "new account balance";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(148, 303);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FormMoneyInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 348);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtNewAccountBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoneyOut);
            this.Controls.Add(this.btnMoneyIn);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Name = "FormMoneyInOut";
            this.Text = "FormMoneyInOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnMoneyIn;
        private System.Windows.Forms.Button btnMoneyOut;
        private System.Windows.Forms.TextBox txtNewAccountBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDone;
    }
}