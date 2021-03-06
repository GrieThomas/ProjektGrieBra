﻿namespace CustomerDataV1
{
    partial class FormMenu
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
            this.btnAdPers = new System.Windows.Forms.Button();
            this.btnFindPers = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.btnshowall = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnFindPersEmail = new System.Windows.Forms.Button();
            this.btnChangeAttribut = new System.Windows.Forms.Button();
            this.btnMoneyInOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdPers
            // 
            this.btnAdPers.Location = new System.Drawing.Point(501, 144);
            this.btnAdPers.Name = "btnAdPers";
            this.btnAdPers.Size = new System.Drawing.Size(133, 23);
            this.btnAdPers.TabIndex = 7;
            this.btnAdPers.Text = "add person";
            this.btnAdPers.UseVisualStyleBackColor = true;
            this.btnAdPers.Click += new System.EventHandler(this.btnAdPers_Click);
            // 
            // btnFindPers
            // 
            this.btnFindPers.Location = new System.Drawing.Point(58, 29);
            this.btnFindPers.Name = "btnFindPers";
            this.btnFindPers.Size = new System.Drawing.Size(133, 27);
            this.btnFindPers.TabIndex = 6;
            this.btnFindPers.Text = "find person by name";
            this.btnFindPers.UseVisualStyleBackColor = true;
            this.btnFindPers.Click += new System.EventHandler(this.btnFindPers_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(304, 85);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(88, 20);
            this.txtMail.TabIndex = 11;
            // 
            // txtboxLname
            // 
            this.txtboxLname.Location = new System.Drawing.Point(482, 36);
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(88, 20);
            this.txtboxLname.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(231, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "e-mail";
            // 
            // txtboxFname
            // 
            this.txtboxFname.Location = new System.Drawing.Point(304, 33);
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(88, 20);
            this.txtboxFname.TabIndex = 13;
            
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(409, 39);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(52, 13);
            this.lblLname.TabIndex = 9;
            this.lblLname.Text = "last name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(231, 36);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(52, 13);
            this.lblFname.TabIndex = 10;
            this.lblFname.Text = "first name";
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(308, 415);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(132, 23);
            this.btnshowall.TabIndex = 15;
            this.btnshowall.Text = "show all / refresh";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(55, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(712, 180);
            this.dataGridView2.TabIndex = 17;
            // 
            // btnFindPersEmail
            // 
            this.btnFindPersEmail.Location = new System.Drawing.Point(58, 74);
            this.btnFindPersEmail.Name = "btnFindPersEmail";
            this.btnFindPersEmail.Size = new System.Drawing.Size(133, 27);
            this.btnFindPersEmail.TabIndex = 18;
            this.btnFindPersEmail.Text = "find person by email";
            this.btnFindPersEmail.UseVisualStyleBackColor = true;
            this.btnFindPersEmail.Click += new System.EventHandler(this.btnFindPersEmail_Click);
            // 
            // btnChangeAttribut
            // 
            this.btnChangeAttribut.Location = new System.Drawing.Point(57, 145);
            this.btnChangeAttribut.Name = "btnChangeAttribut";
            this.btnChangeAttribut.Size = new System.Drawing.Size(164, 23);
            this.btnChangeAttribut.TabIndex = 20;
            this.btnChangeAttribut.Text = "change attributes of a person";
            this.btnChangeAttribut.UseVisualStyleBackColor = true;
            this.btnChangeAttribut.Click += new System.EventHandler(this.btnChangeAttribut_Click);
            // 
            // btnMoneyInOut
            // 
            this.btnMoneyInOut.Location = new System.Drawing.Point(303, 144);
            this.btnMoneyInOut.Name = "btnMoneyInOut";
            this.btnMoneyInOut.Size = new System.Drawing.Size(134, 23);
            this.btnMoneyInOut.TabIndex = 21;
            this.btnMoneyInOut.Text = "money in/out";
            this.btnMoneyInOut.UseVisualStyleBackColor = true;
            this.btnMoneyInOut.Click += new System.EventHandler(this.btnMoneyInOut_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 500);
            this.Controls.Add(this.btnMoneyInOut);
            this.Controls.Add(this.btnChangeAttribut);
            this.Controls.Add(this.btnFindPersEmail);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnAdPers);
            this.Controls.Add(this.btnFindPers);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdPers;
        private System.Windows.Forms.Button btnFindPers;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFindPersEmail;
        private System.Windows.Forms.Button btnChangeAttribut;
        private System.Windows.Forms.Button btnMoneyInOut;
    }
}