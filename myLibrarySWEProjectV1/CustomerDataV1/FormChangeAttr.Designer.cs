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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewMail = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "change last name with email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(312, 79);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(88, 20);
            this.txtMail.TabIndex = 24;
            // 
            // txtboxLname
            // 
            this.txtboxLname.Location = new System.Drawing.Point(490, 30);
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(88, 20);
            this.txtboxLname.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(239, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "e-mail";
            // 
            // txtboxFname
            // 
            this.txtboxFname.Location = new System.Drawing.Point(312, 27);
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(88, 20);
            this.txtboxFname.TabIndex = 26;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(417, 33);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(52, 13);
            this.lblLname.TabIndex = 22;
            this.lblLname.Text = "last name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(239, 30);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(52, 13);
            this.lblFname.TabIndex = 23;
            this.lblFname.Text = "first name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 27);
            this.button2.TabIndex = 27;
            this.button2.Text = "change email with email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "new e-mail";
            // 
            // txtNewMail
            // 
            this.txtNewMail.Location = new System.Drawing.Point(312, 121);
            this.txtNewMail.Name = "txtNewMail";
            this.txtNewMail.Size = new System.Drawing.Size(88, 20);
            this.txtNewMail.TabIndex = 24;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(207, 201);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 28;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FormChangeAttr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 273);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNewMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.button1);
            this.Name = "FormChangeAttr";
            this.Text = "FormChangeAttr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewMail;
        private System.Windows.Forms.Button btnDone;
    }
}