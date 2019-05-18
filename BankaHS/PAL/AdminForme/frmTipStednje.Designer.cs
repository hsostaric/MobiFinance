namespace BankaHS.PAL.AdminForme
{
    partial class frmTipStednje
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
            this.dgvTipoviStednje = new System.Windows.Forms.DataGridView();
            this.vrstaStednjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajVrstuStednje = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonjaGranica = new System.Windows.Forms.TextBox();
            this.txtGornjaStopa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviStednje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaStednjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
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
            // dgvTipoviStednje
            // 
            this.dgvTipoviStednje.AllowUserToAddRows = false;
            this.dgvTipoviStednje.AllowUserToDeleteRows = false;
            this.dgvTipoviStednje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoviStednje.AutoGenerateColumns = false;
            this.dgvTipoviStednje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTipoviStednje.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoviStednje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoviStednje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.eKSDataGridViewTextBoxColumn});
            this.dgvTipoviStednje.DataSource = this.vrstaStednjeBindingSource;
            this.dgvTipoviStednje.Location = new System.Drawing.Point(21, 43);
            this.dgvTipoviStednje.Name = "dgvTipoviStednje";
            this.dgvTipoviStednje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoviStednje.Size = new System.Drawing.Size(527, 259);
            this.dgvTipoviStednje.TabIndex = 1;
            // 
            // vrstaStednjeBindingSource
            // 
            this.vrstaStednjeBindingSource.DataSource = typeof(BankaHS.BLL.VrstaStednje);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 67;
            // 
            // eKSDataGridViewTextBoxColumn
            // 
            this.eKSDataGridViewTextBoxColumn.DataPropertyName = "EKS";
            this.eKSDataGridViewTextBoxColumn.HeaderText = "EKS";
            this.eKSDataGridViewTextBoxColumn.Name = "eKSDataGridViewTextBoxColumn";
            this.eKSDataGridViewTextBoxColumn.Width = 59;
            // 
            // btnDodajVrstuStednje
            // 
            this.btnDodajVrstuStednje.Location = new System.Drawing.Point(21, 335);
            this.btnDodajVrstuStednje.Name = "btnDodajVrstuStednje";
            this.btnDodajVrstuStednje.Size = new System.Drawing.Size(149, 49);
            this.btnDodajVrstuStednje.TabIndex = 2;
            this.btnDodajVrstuStednje.Text = "Dodaj ";
            this.btnDodajVrstuStednje.UseVisualStyleBackColor = true;
            this.btnDodajVrstuStednje.Click += new System.EventHandler(this.btnDodajVrstuStednje_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(206, 335);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(149, 49);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(399, 335);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(149, 49);
            this.btnIzbrisi.TabIndex = 4;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(584, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraga prema EKS-u";
            // 
            // txtDonjaGranica
            // 
            this.txtDonjaGranica.Location = new System.Drawing.Point(675, 80);
            this.txtDonjaGranica.Name = "txtDonjaGranica";
            this.txtDonjaGranica.Size = new System.Drawing.Size(196, 22);
            this.txtDonjaGranica.TabIndex = 6;
            // 
            // txtGornjaStopa
            // 
            this.txtGornjaStopa.Location = new System.Drawing.Point(675, 129);
            this.txtGornjaStopa.Name = "txtGornjaStopa";
            this.txtGornjaStopa.Size = new System.Drawing.Size(196, 22);
            this.txtGornjaStopa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Donja granica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gornja granica";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmTipStednje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGornjaStopa);
            this.Controls.Add(this.txtDonjaGranica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodajVrstuStednje);
            this.Controls.Add(this.dgvTipoviStednje);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTipStednje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipStednje";
            this.Load += new System.EventHandler(this.frmTipStednje_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviStednje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaStednjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTipoviStednje;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vrstaStednjeBindingSource;
        private System.Windows.Forms.Button btnDodajVrstuStednje;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonjaGranica;
        private System.Windows.Forms.TextBox txtGornjaStopa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}