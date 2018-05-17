namespace CustomerDataV1
{
    partial class FormOptions
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
            this.btnldBU = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.tbxOldPass = new System.Windows.Forms.TextBox();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadBackup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnldBU
            // 
            this.btnldBU.Location = new System.Drawing.Point(22, 54);
            this.btnldBU.Name = "btnldBU";
            this.btnldBU.Size = new System.Drawing.Size(192, 23);
            this.btnldBU.TabIndex = 0;
            this.btnldBU.Text = "Load Backup";
            this.btnldBU.UseVisualStyleBackColor = true;
            this.btnldBU.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 56);
            this.textBox1.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(8, 136);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Location = new System.Drawing.Point(22, 25);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(192, 23);
            this.btnBackupPath.TabIndex = 1;
            this.btnBackupPath.Text = "Select Backup Folder";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // tbxOldPass
            // 
            this.tbxOldPass.Location = new System.Drawing.Point(6, 71);
            this.tbxOldPass.Name = "tbxOldPass";
            this.tbxOldPass.Size = new System.Drawing.Size(100, 20);
            this.tbxOldPass.TabIndex = 4;
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Location = new System.Drawing.Point(8, 110);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.Size = new System.Drawing.Size(100, 20);
            this.tbxNewPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxNewPass);
            this.groupBox1.Controls.Add(this.tbxOldPass);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password change";
            // 
            // btnLoadBackup
            // 
            this.btnLoadBackup.Location = new System.Drawing.Point(139, 145);
            this.btnLoadBackup.Name = "btnLoadBackup";
            this.btnLoadBackup.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBackup.TabIndex = 7;
            this.btnLoadBackup.Text = "load backup";
            this.btnLoadBackup.UseVisualStyleBackColor = true;
            this.btnLoadBackup.Click += new System.EventHandler(this.btnLoadBackup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 171);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 214);
            this.Controls.Add(this.btnLoadBackup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBackupPath);
            this.Controls.Add(this.btnldBU);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnldBU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.TextBox tbxOldPass;
        private System.Windows.Forms.TextBox tbxNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadBackup;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}