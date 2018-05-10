namespace CustomerDataV1
{
    partial class FormChangeAttr
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
            this.btnChange1 = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.btnChange2 = new System.Windows.Forms.Button();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtNewMail = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpChLstName = new System.Windows.Forms.GroupBox();
            this.gbChEmail = new System.Windows.Forms.GroupBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChange1
            // 
            this.btnChange1.Location = new System.Drawing.Point(34, 160);
            this.btnChange1.Name = "btnChange1";
            this.btnChange1.Size = new System.Drawing.Size(164, 25);
            this.btnChange1.TabIndex = 20;
            this.btnChange1.Text = "Change";
            this.btnChange1.UseVisualStyleBackColor = true;
            this.btnChange1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(104, 108);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(88, 20);
            this.txtMail.TabIndex = 24;
            // 
            // txtboxLname
            // 
            this.txtboxLname.Location = new System.Drawing.Point(104, 53);
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(88, 20);
            this.txtboxLname.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "e-mail";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(31, 56);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(52, 13);
            this.lblLname.TabIndex = 22;
            this.lblLname.Text = "last name";
            // 
            // btnChange2
            // 
            this.btnChange2.Location = new System.Drawing.Point(275, 158);
            this.btnChange2.Name = "btnChange2";
            this.btnChange2.Size = new System.Drawing.Size(164, 27);
            this.btnChange2.TabIndex = 27;
            this.btnChange2.Text = "Change";
            this.btnChange2.UseVisualStyleBackColor = true;
            this.btnChange2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Location = new System.Drawing.Point(278, 113);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(57, 13);
            this.lblNewEmail.TabIndex = 21;
            this.lblNewEmail.Text = "new e-mail";
            // 
            // txtNewMail
            // 
            this.txtNewMail.Location = new System.Drawing.Point(351, 110);
            this.txtNewMail.Name = "txtNewMail";
            this.txtNewMail.Size = new System.Drawing.Size(88, 20);
            this.txtNewMail.TabIndex = 24;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(275, 238);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 28;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(278, 56);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(34, 13);
            this.lblEmail2.TabIndex = 21;
            this.lblEmail2.Text = "e-mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 24;
            // 
            // gpChLstName
            // 
            this.gpChLstName.Location = new System.Drawing.Point(12, 26);
            this.gpChLstName.Name = "gpChLstName";
            this.gpChLstName.Size = new System.Drawing.Size(200, 179);
            this.gpChLstName.TabIndex = 29;
            this.gpChLstName.TabStop = false;
            this.gpChLstName.Text = "Change last name";
            // 
            // gbChEmail
            // 
            this.gbChEmail.Location = new System.Drawing.Point(257, 26);
            this.gbChEmail.Name = "gbChEmail";
            this.gbChEmail.Size = new System.Drawing.Size(200, 179);
            this.gbChEmail.TabIndex = 29;
            this.gbChEmail.TabStop = false;
            this.gbChEmail.Text = "Change email";
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(364, 238);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 28;
            this.btnAbort.Text = "abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FormChangeAttr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 273);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnChange2);
            this.Controls.Add(this.txtNewMail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblNewEmail);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.btnChange1);
            this.Controls.Add(this.gbChEmail);
            this.Controls.Add(this.gpChLstName);
            this.Name = "FormChangeAttr";
            this.Text = "FormChangeAttr";
            this.Load += new System.EventHandler(this.FormChangeAttr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Button btnChange2;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.TextBox txtNewMail;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gpChLstName;
        private System.Windows.Forms.GroupBox gbChEmail;
        private System.Windows.Forms.Button btnAbort;
    }
}