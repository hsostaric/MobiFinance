namespace BankaHS.PAL
{
    partial class frmTecajnaLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTecajnaLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTimePickerOD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.lbValuta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDateValueFilter = new System.Windows.Forms.Button();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.btnActualyList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.uibtnPretvori = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uiIznosUKunama = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecajnaLista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTecajnaLista
            // 
            this.dgvTecajnaLista.AllowUserToAddRows = false;
            this.dgvTecajnaLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvTecajnaLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTecajnaLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTecajnaLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTecajnaLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTecajnaLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecajnaLista.Location = new System.Drawing.Point(13, 93);
            this.dgvTecajnaLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTecajnaLista.Name = "dgvTecajnaLista";
            this.dgvTecajnaLista.Size = new System.Drawing.Size(700, 320);
            this.dgvTecajnaLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(479, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "HNB tečajna lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(752, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter";
            // 
            // dTimePickerOD
            // 
            this.dTimePickerOD.Location = new System.Drawing.Point(850, 127);
            this.dTimePickerOD.Name = "dTimePickerOD";
            this.dTimePickerOD.Size = new System.Drawing.Size(211, 22);
            this.dTimePickerOD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(753, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(753, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum od:";
            // 
            // dTimePickerDo
            // 
            this.dTimePickerDo.Location = new System.Drawing.Point(850, 170);
            this.dTimePickerDo.Name = "dTimePickerDo";
            this.dTimePickerDo.Size = new System.Drawing.Size(211, 22);
            this.dTimePickerDo.TabIndex = 7;
            // 
            // lbValuta
            // 
            this.lbValuta.AutoSize = true;
            this.lbValuta.Location = new System.Drawing.Point(753, 227);
            this.lbValuta.Name = "lbValuta";
            this.lbValuta.Size = new System.Drawing.Size(46, 16);
            this.lbValuta.TabIndex = 8;
            this.lbValuta.Text = "Valuta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(850, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // btnDateValueFilter
            // 
            this.btnDateValueFilter.Location = new System.Drawing.Point(867, 269);
            this.btnDateValueFilter.Name = "btnDateValueFilter";
            this.btnDateValueFilter.Size = new System.Drawing.Size(122, 61);
            this.btnDateValueFilter.TabIndex = 10;
            this.btnDateValueFilter.Text = "Filtriraj prema valuti i datumu";
            this.btnDateValueFilter.UseVisualStyleBackColor = true;
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(1009, 269);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(122, 61);
            this.btnDateFilter.TabIndex = 11;
            this.btnDateFilter.Text = "Filtriraj prema datumu";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            // 
            // btnActualyList
            // 
            this.btnActualyList.Location = new System.Drawing.Point(740, 269);
            this.btnActualyList.Name = "btnActualyList";
            this.btnActualyList.Size = new System.Drawing.Size(107, 61);
            this.btnActualyList.TabIndex = 12;
            this.btnActualyList.Text = "Današnja lista";
            this.btnActualyList.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // uibtnPretvori
            // 
            this.uibtnPretvori.ForeColor = System.Drawing.Color.Black;
            this.uibtnPretvori.Location = new System.Drawing.Point(359, 449);
            this.uibtnPretvori.Name = "uibtnPretvori";
            this.uibtnPretvori.Size = new System.Drawing.Size(133, 24);
            this.uibtnPretvori.TabIndex = 20;
            this.uibtnPretvori.Text = "Konvertiraj";
            this.uibtnPretvori.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 450);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 22);
            this.textBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "HRK";
            // 
            // uiIznosUKunama
            // 
            this.uiIznosUKunama.Location = new System.Drawing.Point(542, 450);
            this.uiIznosUKunama.Name = "uiIznosUKunama";
            this.uiIznosUKunama.ReadOnly = true;
            this.uiIznosUKunama.Size = new System.Drawing.Size(207, 22);
            this.uiIznosUKunama.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nazadToolStripMenuItem.Text = "Nazad";
            // 
            // frmTecajnaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 536);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uibtnPretvori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uiIznosUKunama);
            this.Controls.Add(this.btnActualyList);
            this.Controls.Add(this.btnDateFilter);
            this.Controls.Add(this.btnDateValueFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbValuta);
            this.Controls.Add(this.dTimePickerDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTimePickerOD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTecajnaLista);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTecajnaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tecajne Liste";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecajnaLista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTecajnaLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTimePickerOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTimePickerDo;
        private System.Windows.Forms.Label lbValuta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDateValueFilter;
        private System.Windows.Forms.Button btnDateFilter;
        private System.Windows.Forms.Button btnActualyList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uibtnPretvori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uiIznosUKunama;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
    }
}