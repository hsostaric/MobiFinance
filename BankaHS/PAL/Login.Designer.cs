namespace BankaHS
{
    partial class Form1
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
            this.logingrupa = new System.Windows.Forms.GroupBox();
            this.lbPorukaUspjeha = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.uiGumbPrijava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logingrupa.SuspendLayout();
            this.SuspendLayout();
            // 
            // logingrupa
            // 
            this.logingrupa.Controls.Add(this.lbPorukaUspjeha);
            this.logingrupa.Controls.Add(this.txtPassword);
            this.logingrupa.Controls.Add(this.txtUserName);
            this.logingrupa.Controls.Add(this.uiGumbPrijava);
            this.logingrupa.Controls.Add(this.label2);
            this.logingrupa.Controls.Add(this.label1);
            this.logingrupa.Location = new System.Drawing.Point(145, 97);
            this.logingrupa.Margin = new System.Windows.Forms.Padding(4);
            this.logingrupa.Name = "logingrupa";
            this.logingrupa.Padding = new System.Windows.Forms.Padding(4);
            this.logingrupa.Size = new System.Drawing.Size(688, 315);
            this.logingrupa.TabIndex = 0;
            this.logingrupa.TabStop = false;
            // 
            // lbPorukaUspjeha
            // 
            this.lbPorukaUspjeha.AutoSize = true;
            this.lbPorukaUspjeha.Location = new System.Drawing.Point(189, 166);
            this.lbPorukaUspjeha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPorukaUspjeha.Name = "lbPorukaUspjeha";
            this.lbPorukaUspjeha.Size = new System.Drawing.Size(0, 16);
            this.lbPorukaUspjeha.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Location = new System.Drawing.Point(189, 103);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(435, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(189, 41);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(435, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // uiGumbPrijava
            // 
            this.uiGumbPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiGumbPrijava.Location = new System.Drawing.Point(285, 225);
            this.uiGumbPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.uiGumbPrijava.Name = "uiGumbPrijava";
            this.uiGumbPrijava.Size = new System.Drawing.Size(169, 28);
            this.uiGumbPrijava.TabIndex = 2;
            this.uiGumbPrijava.Text = "Prijavi se";
            this.uiGumbPrijava.UseVisualStyleBackColor = true;
            this.uiGumbPrijava.Click += new System.EventHandler(this.uiGumbPrijava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko Ime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 510);
            this.Controls.Add(this.logingrupa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logingrupa.ResumeLayout(false);
            this.logingrupa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logingrupa;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button uiGumbPrijava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPorukaUspjeha;
    }
}

