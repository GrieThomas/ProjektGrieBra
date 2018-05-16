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
            this.components = new System.ComponentModel.Container();
            this.lblPsw = new System.Windows.Forms.Label();
            this.txtboxPsw = new System.Windows.Forms.TextBox();
            this.btnpsw = new System.Windows.Forms.Button();
            this.lblLang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.epErrorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(49, 114);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(55, 13);
            this.lblPsw.TabIndex = 2;
            this.lblPsw.Text = "password:";
            // 
            // txtboxPsw
            // 
            this.txtboxPsw.Location = new System.Drawing.Point(48, 130);
            this.txtboxPsw.Name = "txtboxPsw";
            this.txtboxPsw.Size = new System.Drawing.Size(121, 20);
            this.txtboxPsw.TabIndex = 3;
            this.txtboxPsw.Enter += new System.EventHandler(this.txtboxPsw_Enter);
            // 
            // btnpsw
            // 
            this.btnpsw.Location = new System.Drawing.Point(48, 179);
            this.btnpsw.Name = "btnpsw";
            this.btnpsw.Size = new System.Drawing.Size(121, 35);
            this.btnpsw.TabIndex = 4;
            this.btnpsw.Text = "unlock";
            this.btnpsw.UseVisualStyleBackColor = true;
            this.btnpsw.Click += new System.EventHandler(this.btnpsw_Click);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(49, 53);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(51, 13);
            this.lblLang.TabIndex = 5;
            this.lblLang.Text = "language";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // epErrorMsg
            // 
            this.epErrorMsg.ContainerControl = this;
            // 
            // btnOpt
            // 
            this.btnOpt.Location = new System.Drawing.Point(136, 233);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.Size = new System.Drawing.Size(74, 20);
            this.btnOpt.TabIndex = 7;
            this.btnOpt.Text = "options";
            this.btnOpt.UseVisualStyleBackColor = true;
            this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 265);
            this.Controls.Add(this.btnOpt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.btnpsw);
            this.Controls.Add(this.txtboxPsw);
            this.Controls.Add(this.lblPsw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.TextBox txtboxPsw;
        private System.Windows.Forms.Button btnpsw;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider epErrorMsg;
        private System.Windows.Forms.Button btnOpt;
    }
}

