namespace BankaHS.PAL.Krediti
{
    partial class frmZahtjevZaKredit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.uiGlavnicaKredita = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uiBrojAnuiteta = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uiKamatnaStopa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uiNazivKredita = new System.Windows.Forms.TextBox();
            this.uiIzracunajKreditniRejting = new System.Windows.Forms.Button();
            this.uiKreditniRizik = new System.Windows.Forms.ProgressBar();
            this.uiOtvoriKredit = new System.Windows.Forms.Button();
            this.uiIzradiTablicu = new System.Windows.Forms.Button();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stalnoZaposlenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGlavnicaKredita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBrojAnuiteta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.stalnoZaposlenjeDataGridViewTextBoxColumn,
            this.primanjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klijentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(327, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis klijenata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(331, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaci za kredit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum početka";
            // 
            // uiDatumPocetka
            // 
            this.uiDatumPocetka.Location = new System.Drawing.Point(155, 277);
            this.uiDatumPocetka.Name = "uiDatumPocetka";
            this.uiDatumPocetka.Size = new System.Drawing.Size(136, 20);
            this.uiDatumPocetka.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Glavnica";
            // 
            // uiGlavnicaKredita
            // 
            this.uiGlavnicaKredita.Location = new System.Drawing.Point(155, 312);
            this.uiGlavnicaKredita.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.uiGlavnicaKredita.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiGlavnicaKredita.Name = "uiGlavnicaKredita";
            this.uiGlavnicaKredita.Size = new System.Drawing.Size(136, 20);
            this.uiGlavnicaKredita.TabIndex = 7;
            this.uiGlavnicaKredita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiGlavnicaKredita.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "HRK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(35, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Broj anuiteta";
            // 
            // uiBrojAnuiteta
            // 
            this.uiBrojAnuiteta.Location = new System.Drawing.Point(155, 346);
            this.uiBrojAnuiteta.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.uiBrojAnuiteta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiBrojAnuiteta.Name = "uiBrojAnuiteta";
            this.uiBrojAnuiteta.Size = new System.Drawing.Size(136, 20);
            this.uiBrojAnuiteta.TabIndex = 10;
            this.uiBrojAnuiteta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiBrojAnuiteta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(297, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "mjeseci";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(35, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kamatna stopa";
            // 
            // uiKamatnaStopa
            // 
            this.uiKamatnaStopa.Location = new System.Drawing.Point(155, 380);
            this.uiKamatnaStopa.Name = "uiKamatnaStopa";
            this.uiKamatnaStopa.Size = new System.Drawing.Size(52, 20);
            this.uiKamatnaStopa.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(213, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(35, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Naziv kredita";
            // 
            // uiNazivKredita
            // 
            this.uiNazivKredita.Location = new System.Drawing.Point(155, 418);
            this.uiNazivKredita.Name = "uiNazivKredita";
            this.uiNazivKredita.Size = new System.Drawing.Size(136, 20);
            this.uiNazivKredita.TabIndex = 16;
            // 
            // uiIzracunajKreditniRejting
            // 
            this.uiIzracunajKreditniRejting.Location = new System.Drawing.Point(708, 277);
            this.uiIzracunajKreditniRejting.Name = "uiIzracunajKreditniRejting";
            this.uiIzracunajKreditniRejting.Size = new System.Drawing.Size(117, 40);
            this.uiIzracunajKreditniRejting.TabIndex = 17;
            this.uiIzracunajKreditniRejting.Text = "Izračunaj kreditni rejting";
            this.uiIzracunajKreditniRejting.UseVisualStyleBackColor = true;
            // 
            // uiKreditniRizik
            // 
            this.uiKreditniRizik.Location = new System.Drawing.Point(381, 277);
            this.uiKreditniRizik.Name = "uiKreditniRizik";
            this.uiKreditniRizik.Size = new System.Drawing.Size(229, 40);
            this.uiKreditniRizik.TabIndex = 18;
            // 
            // uiOtvoriKredit
            // 
            this.uiOtvoriKredit.Location = new System.Drawing.Point(381, 337);
            this.uiOtvoriKredit.Name = "uiOtvoriKredit";
            this.uiOtvoriKredit.Size = new System.Drawing.Size(117, 32);
            this.uiOtvoriKredit.TabIndex = 19;
            this.uiOtvoriKredit.Text = "Utvori kredit";
            this.uiOtvoriKredit.UseVisualStyleBackColor = true;
            // 
            // uiIzradiTablicu
            // 
            this.uiIzradiTablicu.Location = new System.Drawing.Point(381, 375);
            this.uiIzradiTablicu.Name = "uiIzradiTablicu";
            this.uiIzradiTablicu.Size = new System.Drawing.Size(117, 37);
            this.uiIzradiTablicu.TabIndex = 20;
            this.uiIzradiTablicu.Text = "Otplatna tablica";
            this.uiIzradiTablicu.UseVisualStyleBackColor = true;
            this.uiIzradiTablicu.Click += new System.EventHandler(this.uiIzradiTablicu_Click);
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
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            // 
            // stalnoZaposlenjeDataGridViewTextBoxColumn
            // 
            this.stalnoZaposlenjeDataGridViewTextBoxColumn.DataPropertyName = "StalnoZaposlenje";
            this.stalnoZaposlenjeDataGridViewTextBoxColumn.HeaderText = "Zaposlenje";
            this.stalnoZaposlenjeDataGridViewTextBoxColumn.Name = "stalnoZaposlenjeDataGridViewTextBoxColumn";
            // 
            // primanjaDataGridViewTextBoxColumn
            // 
            this.primanjaDataGridViewTextBoxColumn.DataPropertyName = "Primanja";
            this.primanjaDataGridViewTextBoxColumn.HeaderText = "Primanja";
            this.primanjaDataGridViewTextBoxColumn.Name = "primanjaDataGridViewTextBoxColumn";
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(BankaHS.BLL.Klijent);
            // 
            // frmZahtjevZaKredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 456);
            this.Controls.Add(this.uiIzradiTablicu);
            this.Controls.Add(this.uiOtvoriKredit);
            this.Controls.Add(this.uiKreditniRizik);
            this.Controls.Add(this.uiIzracunajKreditniRejting);
            this.Controls.Add(this.uiNazivKredita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uiKamatnaStopa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uiBrojAnuiteta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiGlavnicaKredita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiDatumPocetka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmZahtjevZaKredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZahtjevZaKredit";
            this.Load += new System.EventHandler(this.frmZahtjevZaKredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGlavnicaKredita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBrojAnuiteta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stalnoZaposlenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker uiDatumPocetka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown uiGlavnicaKredita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uiBrojAnuiteta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uiKamatnaStopa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uiNazivKredita;
        private System.Windows.Forms.Button uiIzracunajKreditniRejting;
        private System.Windows.Forms.ProgressBar uiKreditniRizik;
        private System.Windows.Forms.Button uiOtvoriKredit;
        private System.Windows.Forms.Button uiIzradiTablicu;
    }
}