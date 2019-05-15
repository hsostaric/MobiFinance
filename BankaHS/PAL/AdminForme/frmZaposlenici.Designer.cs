namespace BankaHS.PAL.AdminForme
{
    partial class frmZaposlenici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPrikazZaposlenih = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrediZaposlenika = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cbUloge = new System.Windows.Forms.ComboBox();
            this.Uloga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazZaposlenih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.izlazToolStripMenuItem.Text = "Nazad";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // dgvPrikazZaposlenih
            // 
            this.dgvPrikazZaposlenih.AllowUserToAddRows = false;
            this.dgvPrikazZaposlenih.AllowUserToDeleteRows = false;
            this.dgvPrikazZaposlenih.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazZaposlenih.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazZaposlenih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrikazZaposlenih.AutoGenerateColumns = false;
            this.dgvPrikazZaposlenih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazZaposlenih.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn});
            this.dgvPrikazZaposlenih.DataSource = this.zaposlenikBindingSource;
            this.dgvPrikazZaposlenih.Location = new System.Drawing.Point(12, 27);
            this.dgvPrikazZaposlenih.Name = "dgvPrikazZaposlenih";
            this.dgvPrikazZaposlenih.ReadOnly = true;
            this.dgvPrikazZaposlenih.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazZaposlenih.Size = new System.Drawing.Size(766, 282);
            this.dgvPrikazZaposlenih.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            this.brojTelefonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(BankaHS.BLL.Zaposlenik);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Unos zaposlenika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrediZaposlenika
            // 
            this.btnUrediZaposlenika.Location = new System.Drawing.Point(164, 332);
            this.btnUrediZaposlenika.Name = "btnUrediZaposlenika";
            this.btnUrediZaposlenika.Size = new System.Drawing.Size(152, 42);
            this.btnUrediZaposlenika.TabIndex = 3;
            this.btnUrediZaposlenika.Text = "Ažuriranje zaposlenika";
            this.btnUrediZaposlenika.UseVisualStyleBackColor = true;
            this.btnUrediZaposlenika.Click += new System.EventHandler(this.btnUrediZaposlenika_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(338, 332);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(158, 42);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cbUloge
            // 
            this.cbUloge.FormattingEnabled = true;
            this.cbUloge.Location = new System.Drawing.Point(876, 71);
            this.cbUloge.Name = "cbUloge";
            this.cbUloge.Size = new System.Drawing.Size(191, 24);
            this.cbUloge.TabIndex = 5;
            // 
            // Uloga
            // 
            this.Uloga.AutoSize = true;
            this.Uloga.Location = new System.Drawing.Point(798, 74);
            this.Uloga.Name = "Uloga";
            this.Uloga.Size = new System.Drawing.Size(45, 16);
            this.Uloga.TabIndex = 6;
            this.Uloga.Text = "Uloga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(876, 125);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(191, 22);
            this.txtIme.TabIndex = 9;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(876, 173);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(191, 22);
            this.txtPrezime.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(801, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 34);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(934, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 554);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uloga);
            this.Controls.Add(this.cbUloge);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUrediZaposlenika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPrikazZaposlenih);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin-Zaposlenici";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazZaposlenih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPrikazZaposlenih;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrediZaposlenika;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cbUloge;
        private System.Windows.Forms.Label Uloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
    }
}