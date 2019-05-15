namespace BankaHS.PresentationLayer
{
    partial class PocetanIzbornik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminStraniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStednje = new System.Windows.Forms.Button();
            this.btnOtplatnaTablica = new System.Windows.Forms.Button();
            this.btnTecaj = new System.Windows.Forms.Button();
            this.tbnTransakcije = new System.Windows.Forms.Button();
            this.btnPregledKlijenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKrediti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminStraniceToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(936, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(128, 544);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminStraniceToolStripMenuItem
            // 
            this.adminStraniceToolStripMenuItem.Name = "adminStraniceToolStripMenuItem";
            this.adminStraniceToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.adminStraniceToolStripMenuItem.Text = "Admin stranica";
            this.adminStraniceToolStripMenuItem.Click += new System.EventHandler(this.adminStraniceToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.odjaviSeToolStripMenuItem.Text = "Odjava";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // btnStednje
            // 
            this.btnStednje.Location = new System.Drawing.Point(15, 52);
            this.btnStednje.Name = "btnStednje";
            this.btnStednje.Size = new System.Drawing.Size(125, 60);
            this.btnStednje.TabIndex = 1;
            this.btnStednje.Text = "Otvaranje štednje";
            this.btnStednje.UseVisualStyleBackColor = true;
            // 
            // btnOtplatnaTablica
            // 
            this.btnOtplatnaTablica.Location = new System.Drawing.Point(193, 52);
            this.btnOtplatnaTablica.Name = "btnOtplatnaTablica";
            this.btnOtplatnaTablica.Size = new System.Drawing.Size(159, 60);
            this.btnOtplatnaTablica.TabIndex = 2;
            this.btnOtplatnaTablica.Text = "Otplatne tablice kredita";
            this.btnOtplatnaTablica.UseVisualStyleBackColor = true;
            // 
            // btnTecaj
            // 
            this.btnTecaj.Location = new System.Drawing.Point(400, 52);
            this.btnTecaj.Name = "btnTecaj";
            this.btnTecaj.Size = new System.Drawing.Size(155, 60);
            this.btnTecaj.TabIndex = 3;
            this.btnTecaj.Text = "Tečajna lista";
            this.btnTecaj.UseVisualStyleBackColor = true;
            // 
            // tbnTransakcije
            // 
            this.tbnTransakcije.Location = new System.Drawing.Point(193, 162);
            this.tbnTransakcije.Name = "tbnTransakcije";
            this.tbnTransakcije.Size = new System.Drawing.Size(159, 60);
            this.tbnTransakcije.TabIndex = 4;
            this.tbnTransakcije.Text = "Transakcije";
            this.tbnTransakcije.UseVisualStyleBackColor = true;
            // 
            // btnPregledKlijenta
            // 
            this.btnPregledKlijenta.Location = new System.Drawing.Point(400, 164);
            this.btnPregledKlijenta.Name = "btnPregledKlijenta";
            this.btnPregledKlijenta.Size = new System.Drawing.Size(155, 57);
            this.btnPregledKlijenta.TabIndex = 5;
            this.btnPregledKlijenta.Text = "Podaci o kijentu";
            this.btnPregledKlijenta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnKrediti);
            this.groupBox1.Controls.Add(this.btnStednje);
            this.groupBox1.Controls.Add(this.btnPregledKlijenta);
            this.groupBox1.Controls.Add(this.btnOtplatnaTablica);
            this.groupBox1.Controls.Add(this.tbnTransakcije);
            this.groupBox1.Controls.Add(this.btnTecaj);
            this.groupBox1.Location = new System.Drawing.Point(77, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 417);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnKrediti
            // 
            this.btnKrediti.Location = new System.Drawing.Point(15, 162);
            this.btnKrediti.Name = "btnKrediti";
            this.btnKrediti.Size = new System.Drawing.Size(125, 60);
            this.btnKrediti.TabIndex = 6;
            this.btnKrediti.Text = "Zahtjev za kredit";
            this.btnKrediti.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Otvaranje računa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PocetanIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PocetanIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transakcija";
            this.Load += new System.EventHandler(this.PocetanIzbornik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminStraniceToolStripMenuItem;
        private System.Windows.Forms.Button btnStednje;
        private System.Windows.Forms.Button btnOtplatnaTablica;
        private System.Windows.Forms.Button btnTecaj;
        private System.Windows.Forms.Button tbnTransakcije;
        private System.Windows.Forms.Button btnPregledKlijenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKrediti;
    }
}