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
            this.components = new System.ComponentModel.Container();
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
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.epErrorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMsg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(13, 34);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 20);
            this.txtMail.TabIndex = 13;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "e-mail";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(10, 16);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(42, 13);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(13, 31);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(152, 20);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyUp);
            // 
            // btnMoneyIn
            // 
            this.btnMoneyIn.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMoneyIn.Location = new System.Drawing.Point(90, 62);
            this.btnMoneyIn.Name = "btnMoneyIn";
            this.btnMoneyIn.Size = new System.Drawing.Size(75, 40);
            this.btnMoneyIn.TabIndex = 15;
            this.btnMoneyIn.Text = "money in";
            this.btnMoneyIn.UseVisualStyleBackColor = false;
            this.btnMoneyIn.Click += new System.EventHandler(this.btnMoneyIn_Click);
            // 
            // btnMoneyOut
            // 
            this.btnMoneyOut.BackColor = System.Drawing.Color.Salmon;
            this.btnMoneyOut.Location = new System.Drawing.Point(13, 62);
            this.btnMoneyOut.Name = "btnMoneyOut";
            this.btnMoneyOut.Size = new System.Drawing.Size(75, 40);
            this.btnMoneyOut.TabIndex = 15;
            this.btnMoneyOut.Text = "money out";
            this.btnMoneyOut.UseVisualStyleBackColor = false;
            this.btnMoneyOut.Click += new System.EventHandler(this.btnMoneyOut_Click);
            // 
            // txtNewAccountBalance
            // 
            this.txtNewAccountBalance.Location = new System.Drawing.Point(66, 290);
            this.txtNewAccountBalance.Name = "txtNewAccountBalance";
            this.txtNewAccountBalance.ReadOnly = true;
            this.txtNewAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.txtNewAccountBalance.TabIndex = 17;
            // 
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Location = new System.Drawing.Point(60, 274);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(110, 13);
            this.lblNewBal.TabIndex = 16;
            this.lblNewBal.Text = "new account balance";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(119, 353);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(84, 23);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(25, 353);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(88, 23);
            this.btnAbort.TabIndex = 18;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Location = new System.Drawing.Point(13, 58);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(75, 23);
            this.btnGetBalance.TabIndex = 19;
            this.btnGetBalance.Text = "Get Balance";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(94, 60);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(71, 20);
            this.tbxBalance.TabIndex = 13;
            // 
            // epErrorMsg
            // 
            this.epErrorMsg.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.btnGetBalance);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.tbxBalance);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 96);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Controls.Add(this.btnMoneyIn);
            this.groupBox2.Controls.Add(this.btnMoneyOut);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(25, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 115);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(25, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 78);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // FormMoneyInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtNewAccountBalance);
            this.Controls.Add(this.lblNewBal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormMoneyInOut";
            this.Text = "FormMoneyInOut";
            this.Load += new System.EventHandler(this.FormMoneyInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMsg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.ErrorProvider epErrorMsg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}