namespace BankaHS.PAL.FormsForClient
{
    partial class frmStednjeKlijenta
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
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glavnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konacanIznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokOrocenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stednjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stednjaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.glavnicaDataGridViewTextBoxColumn,
            this.konacanIznosDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.kamateDataGridViewTextBoxColumn,
            this.rKSDataGridViewTextBoxColumn,
            this.eKSDataGridViewTextBoxColumn,
            this.rokOrocenjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stednjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 59;
            // 
            // glavnicaDataGridViewTextBoxColumn
            // 
            this.glavnicaDataGridViewTextBoxColumn.DataPropertyName = "Glavnica";
            this.glavnicaDataGridViewTextBoxColumn.HeaderText = "Glavnica";
            this.glavnicaDataGridViewTextBoxColumn.Name = "glavnicaDataGridViewTextBoxColumn";
            this.glavnicaDataGridViewTextBoxColumn.Width = 74;
            // 
            // konacanIznosDataGridViewTextBoxColumn
            // 
            this.konacanIznosDataGridViewTextBoxColumn.DataPropertyName = "KonacanIznos";
            this.konacanIznosDataGridViewTextBoxColumn.HeaderText = "Konacan iznos";
            this.konacanIznosDataGridViewTextBoxColumn.Name = "konacanIznosDataGridViewTextBoxColumn";
            this.konacanIznosDataGridViewTextBoxColumn.Width = 102;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 62;
            // 
            // kamateDataGridViewTextBoxColumn
            // 
            this.kamateDataGridViewTextBoxColumn.DataPropertyName = "Kamate";
            this.kamateDataGridViewTextBoxColumn.HeaderText = "Kamate";
            this.kamateDataGridViewTextBoxColumn.Name = "kamateDataGridViewTextBoxColumn";
            this.kamateDataGridViewTextBoxColumn.Width = 68;
            // 
            // rKSDataGridViewTextBoxColumn
            // 
            this.rKSDataGridViewTextBoxColumn.DataPropertyName = "RKS";
            this.rKSDataGridViewTextBoxColumn.HeaderText = "RKS";
            this.rKSDataGridViewTextBoxColumn.Name = "rKSDataGridViewTextBoxColumn";
            this.rKSDataGridViewTextBoxColumn.Width = 54;
            // 
            // eKSDataGridViewTextBoxColumn
            // 
            this.eKSDataGridViewTextBoxColumn.DataPropertyName = "EKS";
            this.eKSDataGridViewTextBoxColumn.HeaderText = "EKS";
            this.eKSDataGridViewTextBoxColumn.Name = "eKSDataGridViewTextBoxColumn";
            this.eKSDataGridViewTextBoxColumn.Width = 53;
            // 
            // rokOrocenjaDataGridViewTextBoxColumn
            // 
            this.rokOrocenjaDataGridViewTextBoxColumn.DataPropertyName = "RokOrocenja";
            this.rokOrocenjaDataGridViewTextBoxColumn.HeaderText = "Rok orocenja";
            this.rokOrocenjaDataGridViewTextBoxColumn.Name = "rokOrocenjaDataGridViewTextBoxColumn";
            this.rokOrocenjaDataGridViewTextBoxColumn.Width = 96;
            // 
            // stednjaBindingSource
            // 
            this.stednjaBindingSource.DataSource = typeof(BankaHS.BLL.Stednja);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
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
            // frmStednjeKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStednjeKlijenta";
            this.Text = "frmStednjeKlijenta";
            this.Load += new System.EventHandler(this.frmStednjeKlijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stednjaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glavnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konacanIznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokOrocenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stednjaBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
    }
}