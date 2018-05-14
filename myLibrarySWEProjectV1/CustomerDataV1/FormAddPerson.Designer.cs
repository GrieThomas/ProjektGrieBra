namespace CustomerDataV1
{
    partial class FormAddPerson
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
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.epErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpErrorMsg = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(36, 105);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(182, 20);
            this.txtMail.TabIndex = 30;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            this.txtMail.Validated += new System.EventHandler(this.txtMail_Validated);
            // 
            // txtboxLname
            // 
            this.txtboxLname.Location = new System.Drawing.Point(130, 54);
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(88, 20);
            this.txtboxLname.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "e-mail";
            // 
            // txtboxFname
            // 
            this.txtboxFname.Location = new System.Drawing.Point(36, 54);
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(88, 20);
            this.txtboxFname.TabIndex = 10;
            this.txtboxFname.Enter += new System.EventHandler(this.txtboxFname_Enter);
            this.txtboxFname.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxFname_Validating);
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(127, 38);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(52, 13);
            this.lblLname.TabIndex = 15;
            this.lblLname.Text = "last name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(36, 38);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(52, 13);
            this.lblFname.TabIndex = 16;
            this.lblFname.Text = "first name";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(130, 159);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 23);
            this.btnOk.TabIndex = 50;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.Validated += new System.EventHandler(this.btnOk_Validated);
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(39, 159);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(88, 23);
            this.btnAbort.TabIndex = 40;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseMnemonic = false;
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // epErrorMessage
            // 
            this.epErrorMessage.ContainerControl = this;
            // 
            // tpErrorMsg
            // 
            this.tpErrorMsg.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FormAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 200);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Name = "FormAddPerson";
            this.Text = "FormAddPerson";
            this.Load += new System.EventHandler(this.FormAddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ErrorProvider epErrorMessage;
        private System.Windows.Forms.ToolTip tpErrorMsg;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}