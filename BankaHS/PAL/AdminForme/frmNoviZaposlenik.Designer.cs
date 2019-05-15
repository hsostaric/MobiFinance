namespace BankaHS.PAL.AdminForme
{
    partial class frmNoviZaposlenik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPonovljenaLozinka = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipzaposlenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.errorIme = new System.Windows.Forms.Label();
            this.errorPrezime = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorKorisnickoIme = new System.Windows.Forms.Label();
            this.errorLozinke = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipzaposlenikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj telefona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Korisničko ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lozinka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ponovi lozinku";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tip";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(177, 63);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(406, 22);
            this.txtIme.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(177, 105);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(406, 22);
            this.txtPrezime.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(177, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(406, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPonovljenaLozinka
            // 
            this.txtPonovljenaLozinka.Location = new System.Drawing.Point(177, 348);
            this.txtPonovljenaLozinka.Name = "txtPonovljenaLozinka";
            this.txtPonovljenaLozinka.PasswordChar = '*';
            this.txtPonovljenaLozinka.Size = new System.Drawing.Size(406, 22);
            this.txtPonovljenaLozinka.TabIndex = 16;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(177, 307);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(406, 22);
            this.txtLozinka.TabIndex = 17;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(177, 264);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(406, 22);
            this.txtKorisnickoIme.TabIndex = 18;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(177, 223);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(406, 22);
            this.txtBrojTelefona.TabIndex = 19;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(177, 187);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(406, 22);
            this.txtAdresa.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipzaposlenikaBindingSource;
            this.comboBox1.DisplayMember = "Naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(406, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // tipzaposlenikaBindingSource
            // 
            this.tipzaposlenikaBindingSource.DataSource = typeof(BankaHS.BLL.Tip_zaposlenika);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorIme
            // 
            this.errorIme.AutoSize = true;
            this.errorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorIme.ForeColor = System.Drawing.Color.Red;
            this.errorIme.Location = new System.Drawing.Point(618, 66);
            this.errorIme.Name = "errorIme";
            this.errorIme.Size = new System.Drawing.Size(0, 16);
            this.errorIme.TabIndex = 23;
            // 
            // errorPrezime
            // 
            this.errorPrezime.AutoSize = true;
            this.errorPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorPrezime.ForeColor = System.Drawing.Color.Red;
            this.errorPrezime.Location = new System.Drawing.Point(615, 108);
            this.errorPrezime.Name = "errorPrezime";
            this.errorPrezime.Size = new System.Drawing.Size(0, 16);
            this.errorPrezime.TabIndex = 24;
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorEmail.ForeColor = System.Drawing.Color.Red;
            this.errorEmail.Location = new System.Drawing.Point(615, 145);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(0, 16);
            this.errorEmail.TabIndex = 25;
            // 
            // errorKorisnickoIme
            // 
            this.errorKorisnickoIme.AutoSize = true;
            this.errorKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorKorisnickoIme.ForeColor = System.Drawing.Color.Red;
            this.errorKorisnickoIme.Location = new System.Drawing.Point(615, 264);
            this.errorKorisnickoIme.Name = "errorKorisnickoIme";
            this.errorKorisnickoIme.Size = new System.Drawing.Size(0, 16);
            this.errorKorisnickoIme.TabIndex = 26;
            // 
            // errorLozinke
            // 
            this.errorLozinke.AutoSize = true;
            this.errorLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLozinke.ForeColor = System.Drawing.Color.Red;
            this.errorLozinke.Location = new System.Drawing.Point(615, 332);
            this.errorLozinke.Name = "errorLozinke";
            this.errorLozinke.Size = new System.Drawing.Size(0, 16);
            this.errorLozinke.TabIndex = 27;
            // 
            // frmNoviZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 555);
            this.Controls.Add(this.errorLozinke);
            this.Controls.Add(this.errorKorisnickoIme);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.errorPrezime);
            this.Controls.Add(this.errorIme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtPonovljenaLozinka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNoviZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Zaposlenik";
            this.Load += new System.EventHandler(this.frmNoviZaposlenik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipzaposlenikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPonovljenaLozinka;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tipzaposlenikaBindingSource;
        private System.Windows.Forms.Label errorIme;
        private System.Windows.Forms.Label errorPrezime;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Label errorKorisnickoIme;
        private System.Windows.Forms.Label errorLozinke;
    }
}