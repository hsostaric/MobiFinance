namespace BankaHS.PAL.Stednje
{
    partial class OtvoriStednju
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
            this.popisKlijenata = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiMjeseciStednje = new System.Windows.Forms.NumericUpDown();
            this.uiVrijednostStednje = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.uiDetaljiStednje = new System.Windows.Forms.Button();
            this.uiNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.uiDodajStednju = new System.Windows.Forms.Button();
            this.uiUkupnaVijednostValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uiEfektivnaValue = new System.Windows.Forms.Label();
            this.uiEfektivnaKamatnaStopa = new System.Windows.Forms.Label();
            this.uiStednjaImelb = new System.Windows.Forms.Label();
            this.uiGreskaImena = new System.Windows.Forms.Label();
            this.uiZakljucajStednju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisKlijenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMjeseciStednje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiVrijednostStednje)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisKlijenata
            // 
            this.popisKlijenata.AllowUserToAddRows = false;
            this.popisKlijenata.AllowUserToDeleteRows = false;
            this.popisKlijenata.AllowUserToOrderColumns = true;
            this.popisKlijenata.AllowUserToResizeColumns = false;
            this.popisKlijenata.AllowUserToResizeRows = false;
            this.popisKlijenata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popisKlijenata.AutoGenerateColumns = false;
            this.popisKlijenata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.popisKlijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisKlijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn});
            this.popisKlijenata.Cursor = System.Windows.Forms.Cursors.Default;
            this.popisKlijenata.DataSource = this.klijentBindingSource;
            this.popisKlijenata.Location = new System.Drawing.Point(25, 62);
            this.popisKlijenata.Name = "popisKlijenata";
            this.popisKlijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.popisKlijenata.Size = new System.Drawing.Size(550, 165);
            this.popisKlijenata.TabIndex = 0;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(BankaHS.BLL.Klijent);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(266, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis klijenata";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = " Želim štedjeti ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(267, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "HRK, a planiram oročiti na ";
            // 
            // uiMjeseciStednje
            // 
            this.uiMjeseciStednje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMjeseciStednje.Location = new System.Drawing.Point(460, 248);
            this.uiMjeseciStednje.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.uiMjeseciStednje.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.uiMjeseciStednje.Name = "uiMjeseciStednje";
            this.uiMjeseciStednje.Size = new System.Drawing.Size(71, 20);
            this.uiMjeseciStednje.TabIndex = 7;
            this.uiMjeseciStednje.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // uiVrijednostStednje
            // 
            this.uiVrijednostStednje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiVrijednostStednje.Location = new System.Drawing.Point(148, 248);
            this.uiVrijednostStednje.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.uiVrijednostStednje.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiVrijednostStednje.Name = "uiVrijednostStednje";
            this.uiVrijednostStednje.Size = new System.Drawing.Size(114, 20);
            this.uiVrijednostStednje.TabIndex = 1;
            this.uiVrijednostStednje.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(536, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "mjeseci.";
            // 
            // uiDetaljiStednje
            // 
            this.uiDetaljiStednje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDetaljiStednje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiDetaljiStednje.Location = new System.Drawing.Point(483, 282);
            this.uiDetaljiStednje.Name = "uiDetaljiStednje";
            this.uiDetaljiStednje.Size = new System.Drawing.Size(120, 35);
            this.uiDetaljiStednje.TabIndex = 9;
            this.uiDetaljiStednje.Text = "Prikaži detalje";
            this.uiDetaljiStednje.UseVisualStyleBackColor = true;
            this.uiDetaljiStednje.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiNaziv
            // 
            this.uiNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNaziv.Location = new System.Drawing.Point(138, 290);
            this.uiNaziv.Name = "uiNaziv";
            this.uiNaziv.Size = new System.Drawing.Size(184, 20);
            this.uiNaziv.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(43, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Naziv štednje";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.uiDodajStednju);
            this.gb1.Controls.Add(this.uiUkupnaVijednostValue);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.uiEfektivnaValue);
            this.gb1.Controls.Add(this.uiEfektivnaKamatnaStopa);
            this.gb1.Controls.Add(this.uiStednjaImelb);
            this.gb1.Location = new System.Drawing.Point(36, 342);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(791, 156);
            this.gb1.TabIndex = 12;
            this.gb1.TabStop = false;
            // 
            // uiDodajStednju
            // 
            this.uiDodajStednju.Location = new System.Drawing.Point(306, 96);
            this.uiDodajStednju.Name = "uiDodajStednju";
            this.uiDodajStednju.Size = new System.Drawing.Size(121, 37);
            this.uiDodajStednju.TabIndex = 5;
            this.uiDodajStednju.Text = "Ugovori štednju";
            this.uiDodajStednju.UseVisualStyleBackColor = true;
            this.uiDodajStednju.Click += new System.EventHandler(this.uiDodajStednju_Click);
            // 
            // uiUkupnaVijednostValue
            // 
            this.uiUkupnaVijednostValue.AutoSize = true;
            this.uiUkupnaVijednostValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiUkupnaVijednostValue.Location = new System.Drawing.Point(587, 51);
            this.uiUkupnaVijednostValue.Name = "uiUkupnaVijednostValue";
            this.uiUkupnaVijednostValue.Size = new System.Drawing.Size(51, 20);
            this.uiUkupnaVijednostValue.TabIndex = 4;
            this.uiUkupnaVijednostValue.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(412, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ukupni iznos isplate:";
            // 
            // uiEfektivnaValue
            // 
            this.uiEfektivnaValue.AutoSize = true;
            this.uiEfektivnaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiEfektivnaValue.Location = new System.Drawing.Point(231, 51);
            this.uiEfektivnaValue.Name = "uiEfektivnaValue";
            this.uiEfektivnaValue.Size = new System.Drawing.Size(51, 20);
            this.uiEfektivnaValue.TabIndex = 2;
            this.uiEfektivnaValue.Text = "label7";
            // 
            // uiEfektivnaKamatnaStopa
            // 
            this.uiEfektivnaKamatnaStopa.AutoSize = true;
            this.uiEfektivnaKamatnaStopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiEfektivnaKamatnaStopa.Location = new System.Drawing.Point(6, 51);
            this.uiEfektivnaKamatnaStopa.Name = "uiEfektivnaKamatnaStopa";
            this.uiEfektivnaKamatnaStopa.Size = new System.Drawing.Size(185, 20);
            this.uiEfektivnaKamatnaStopa.TabIndex = 1;
            this.uiEfektivnaKamatnaStopa.Text = "Efektivna kamatna stopa";
            // 
            // uiStednjaImelb
            // 
            this.uiStednjaImelb.AutoSize = true;
            this.uiStednjaImelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiStednjaImelb.Location = new System.Drawing.Point(325, 16);
            this.uiStednjaImelb.Name = "uiStednjaImelb";
            this.uiStednjaImelb.Size = new System.Drawing.Size(51, 20);
            this.uiStednjaImelb.TabIndex = 0;
            this.uiStednjaImelb.Text = "label6";
            // 
            // uiGreskaImena
            // 
            this.uiGreskaImena.AutoSize = true;
            this.uiGreskaImena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiGreskaImena.Location = new System.Drawing.Point(328, 293);
            this.uiGreskaImena.Name = "uiGreskaImena";
            this.uiGreskaImena.Size = new System.Drawing.Size(0, 16);
            this.uiGreskaImena.TabIndex = 13;
            // 
            // uiZakljucajStednju
            // 
            this.uiZakljucajStednju.Location = new System.Drawing.Point(597, 131);
            this.uiZakljucajStednju.Name = "uiZakljucajStednju";
            this.uiZakljucajStednju.Size = new System.Drawing.Size(132, 35);
            this.uiZakljucajStednju.TabIndex = 14;
            this.uiZakljucajStednju.Text = "Zaključaj štednju";
            this.uiZakljucajStednju.UseVisualStyleBackColor = true;
            this.uiZakljucajStednju.Click += new System.EventHandler(this.uiZakljucajStednju_Click);
            // 
            // OtvoriStednju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 500);
            this.Controls.Add(this.uiZakljucajStednju);
            this.Controls.Add(this.uiGreskaImena);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiNaziv);
            this.Controls.Add(this.uiDetaljiStednje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiVrijednostStednje);
            this.Controls.Add(this.uiMjeseciStednje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popisKlijenata);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OtvoriStednju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtvoriStednju";
            this.Load += new System.EventHandler(this.OtvoriStednju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisKlijenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMjeseciStednje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiVrijednostStednje)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView popisKlijenata;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uiMjeseciStednje;
        private System.Windows.Forms.NumericUpDown uiVrijednostStednje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uiDetaljiStednje;
        private System.Windows.Forms.TextBox uiNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label uiEfektivnaValue;
        private System.Windows.Forms.Label uiEfektivnaKamatnaStopa;
        private System.Windows.Forms.Label uiStednjaImelb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uiUkupnaVijednostValue;
        private System.Windows.Forms.Label uiGreskaImena;
        private System.Windows.Forms.Button uiDodajStednju;
        private System.Windows.Forms.Button uiZakljucajStednju;
    }
}