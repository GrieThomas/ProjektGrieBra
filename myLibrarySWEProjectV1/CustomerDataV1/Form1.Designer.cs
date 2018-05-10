namespace CustomerDataV1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPsw = new System.Windows.Forms.Label();
            this.txtboxPsw = new System.Windows.Forms.TextBox();
            this.btnpsw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(149, 27);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(55, 13);
            this.lblPsw.TabIndex = 2;
            this.lblPsw.Text = "password:";
            // 
            // txtboxPsw
            // 
            this.txtboxPsw.Location = new System.Drawing.Point(210, 24);
            this.txtboxPsw.Name = "txtboxPsw";
            this.txtboxPsw.Size = new System.Drawing.Size(100, 20);
            this.txtboxPsw.TabIndex = 3;
            // 
            // btnpsw
            // 
            this.btnpsw.Location = new System.Drawing.Point(38, 22);
            this.btnpsw.Name = "btnpsw";
            this.btnpsw.Size = new System.Drawing.Size(75, 23);
            this.btnpsw.TabIndex = 4;
            this.btnpsw.Text = "unlock";
            this.btnpsw.UseVisualStyleBackColor = true;
            this.btnpsw.Click += new System.EventHandler(this.btnpsw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "language";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 145);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpsw);
            this.Controls.Add(this.txtboxPsw);
            this.Controls.Add(this.lblPsw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.TextBox txtboxPsw;
        private System.Windows.Forms.Button btnpsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

