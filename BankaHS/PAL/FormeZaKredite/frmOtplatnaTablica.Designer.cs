namespace BankaHS.PAL.FormeZaKredite
{
    partial class frmOtplatnaTablica
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
            this.uiZatvori = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otplatnatablicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brojMjesecaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anuitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otplatnaKvotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostatakDugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otplaceniDioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otplatnatablicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiZatvori
            // 
            this.uiZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiZatvori.Location = new System.Drawing.Point(65, 230);
            this.uiZatvori.Name = "uiZatvori";
            this.uiZatvori.Size = new System.Drawing.Size(257, 36);
            this.uiZatvori.TabIndex = 0;
            this.uiZatvori.Text = "Zatvori";
            this.uiZatvori.UseVisualStyleBackColor = true;
            this.uiZatvori.Click += new System.EventHandler(this.uiZatvori_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(499, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ispis";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojMjesecaDataGridViewTextBoxColumn,
            this.kamateDataGridViewTextBoxColumn,
            this.anuitetDataGridViewTextBoxColumn,
            this.otplatnaKvotaDataGridViewTextBoxColumn,
            this.ostatakDugaDataGridViewTextBoxColumn,
            this.otplaceniDioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otplatnatablicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 181);
            this.dataGridView1.TabIndex = 2;
            // 
            // otplatnatablicaBindingSource
            // 
            this.otplatnatablicaBindingSource.DataSource = typeof(BankaHS.BLL.Otplatna_tablica);
            // 
            // brojMjesecaDataGridViewTextBoxColumn
            // 
            this.brojMjesecaDataGridViewTextBoxColumn.DataPropertyName = "BrojMjeseca";
            this.brojMjesecaDataGridViewTextBoxColumn.HeaderText = "Br.";
            this.brojMjesecaDataGridViewTextBoxColumn.Name = "brojMjesecaDataGridViewTextBoxColumn";
            // 
            // kamateDataGridViewTextBoxColumn
            // 
            this.kamateDataGridViewTextBoxColumn.DataPropertyName = "Kamate";
            this.kamateDataGridViewTextBoxColumn.HeaderText = "Otplata kamate";
            this.kamateDataGridViewTextBoxColumn.Name = "kamateDataGridViewTextBoxColumn";
            // 
            // anuitetDataGridViewTextBoxColumn
            // 
            this.anuitetDataGridViewTextBoxColumn.DataPropertyName = "Anuitet";
            this.anuitetDataGridViewTextBoxColumn.HeaderText = "Iznos anuiteta";
            this.anuitetDataGridViewTextBoxColumn.Name = "anuitetDataGridViewTextBoxColumn";
            // 
            // otplatnaKvotaDataGridViewTextBoxColumn
            // 
            this.otplatnaKvotaDataGridViewTextBoxColumn.DataPropertyName = "OtplatnaKvota";
            this.otplatnaKvotaDataGridViewTextBoxColumn.HeaderText = "Otplata glavnice u jednakim ratama";
            this.otplatnaKvotaDataGridViewTextBoxColumn.Name = "otplatnaKvotaDataGridViewTextBoxColumn";
            // 
            // ostatakDugaDataGridViewTextBoxColumn
            // 
            this.ostatakDugaDataGridViewTextBoxColumn.DataPropertyName = "OstatakDuga";
            this.ostatakDugaDataGridViewTextBoxColumn.HeaderText = "Stanje kredita (ostatak duga)";
            this.ostatakDugaDataGridViewTextBoxColumn.Name = "ostatakDugaDataGridViewTextBoxColumn";
            // 
            // otplaceniDioDataGridViewTextBoxColumn
            // 
            this.otplaceniDioDataGridViewTextBoxColumn.DataPropertyName = "OtplaceniDio";
            this.otplaceniDioDataGridViewTextBoxColumn.HeaderText = "Iznos otplacenog kredita";
            this.otplaceniDioDataGridViewTextBoxColumn.Name = "otplaceniDioDataGridViewTextBoxColumn";
            // 
            // frmOtplatnaTablica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 278);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiZatvori);
            this.Name = "frmOtplatnaTablica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOtplatnaTablica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otplatnatablicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiZatvori;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource otplatnatablicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMjesecaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anuitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otplatnaKvotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostatakDugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otplaceniDioDataGridViewTextBoxColumn;
    }
}