namespace BankaHS.PAL.FormsForClient
{
    partial class frmNoviKlijent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lasd = new System.Windows.Forms.Label();
            this.rbAnswerYes = new System.Windows.Forms.RadioButton();
            this.rbAnswerNo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValuePayment = new System.Windows.Forms.TrackBar();
            this.lnTrackBarValue = new System.Windows.Forms.Label();
            this.uiImeKlijenta = new System.Windows.Forms.TextBox();
            this.uiPrezimeKlijenta = new System.Windows.Forms.TextBox();
            this.uiEmailKlijenta = new System.Windows.Forms.TextBox();
            this.uiOIBKlijenta = new System.Windows.Forms.TextBox();
            this.uiKontaktKlijenta = new System.Windows.Forms.TextBox();
            this.uiAdresaKlijenta = new System.Windows.Forms.TextBox();
            this.uiAddUpdateClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbValuePayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "OIB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kontakt";
            // 
            // lasd
            // 
            this.lasd.AutoSize = true;
            this.lasd.Location = new System.Drawing.Point(37, 289);
            this.lasd.Name = "lasd";
            this.lasd.Size = new System.Drawing.Size(52, 16);
            this.lasd.TabIndex = 5;
            this.lasd.Text = "Adresa";
            // 
            // rbAnswerYes
            // 
            this.rbAnswerYes.AutoSize = true;
            this.rbAnswerYes.Location = new System.Drawing.Point(200, 326);
            this.rbAnswerYes.Name = "rbAnswerYes";
            this.rbAnswerYes.Size = new System.Drawing.Size(44, 20);
            this.rbAnswerYes.TabIndex = 6;
            this.rbAnswerYes.Text = "Da";
            this.rbAnswerYes.UseVisualStyleBackColor = true;
            // 
            // rbAnswerNo
            // 
            this.rbAnswerNo.AutoSize = true;
            this.rbAnswerNo.Checked = true;
            this.rbAnswerNo.Location = new System.Drawing.Point(260, 326);
            this.rbAnswerNo.Name = "rbAnswerNo";
            this.rbAnswerNo.Size = new System.Drawing.Size(44, 20);
            this.rbAnswerNo.TabIndex = 7;
            this.rbAnswerNo.TabStop = true;
            this.rbAnswerNo.Text = "Ne";
            this.rbAnswerNo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stalno zaposlenje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mjesečna primanja";
            // 
            // tbValuePayment
            // 
            this.tbValuePayment.LargeChange = 500;
            this.tbValuePayment.Location = new System.Drawing.Point(165, 368);
            this.tbValuePayment.Maximum = 50000;
            this.tbValuePayment.Name = "tbValuePayment";
            this.tbValuePayment.Size = new System.Drawing.Size(428, 45);
            this.tbValuePayment.TabIndex = 10;
            this.tbValuePayment.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbValuePayment.Scroll += new System.EventHandler(this.tbValue_Scroll);
            // 
            // lnTrackBarValue
            // 
            this.lnTrackBarValue.AutoSize = true;
            this.lnTrackBarValue.Location = new System.Drawing.Point(547, 368);
            this.lnTrackBarValue.Name = "lnTrackBarValue";
            this.lnTrackBarValue.Size = new System.Drawing.Size(0, 16);
            this.lnTrackBarValue.TabIndex = 11;
            // 
            // uiImeKlijenta
            // 
            this.uiImeKlijenta.Location = new System.Drawing.Point(180, 70);
            this.uiImeKlijenta.Name = "uiImeKlijenta";
            this.uiImeKlijenta.Size = new System.Drawing.Size(413, 22);
            this.uiImeKlijenta.TabIndex = 12;
            // 
            // uiPrezimeKlijenta
            // 
            this.uiPrezimeKlijenta.Location = new System.Drawing.Point(180, 113);
            this.uiPrezimeKlijenta.Name = "uiPrezimeKlijenta";
            this.uiPrezimeKlijenta.Size = new System.Drawing.Size(413, 22);
            this.uiPrezimeKlijenta.TabIndex = 13;
            // 
            // uiEmailKlijenta
            // 
            this.uiEmailKlijenta.Location = new System.Drawing.Point(180, 158);
            this.uiEmailKlijenta.Name = "uiEmailKlijenta";
            this.uiEmailKlijenta.Size = new System.Drawing.Size(413, 22);
            this.uiEmailKlijenta.TabIndex = 14;
            // 
            // uiOIBKlijenta
            // 
            this.uiOIBKlijenta.Location = new System.Drawing.Point(180, 205);
            this.uiOIBKlijenta.Name = "uiOIBKlijenta";
            this.uiOIBKlijenta.Size = new System.Drawing.Size(413, 22);
            this.uiOIBKlijenta.TabIndex = 15;
            // 
            // uiKontaktKlijenta
            // 
            this.uiKontaktKlijenta.Location = new System.Drawing.Point(180, 243);
            this.uiKontaktKlijenta.Name = "uiKontaktKlijenta";
            this.uiKontaktKlijenta.Size = new System.Drawing.Size(413, 22);
            this.uiKontaktKlijenta.TabIndex = 16;
            // 
            // uiAdresaKlijenta
            // 
            this.uiAdresaKlijenta.Location = new System.Drawing.Point(180, 286);
            this.uiAdresaKlijenta.Name = "uiAdresaKlijenta";
            this.uiAdresaKlijenta.Size = new System.Drawing.Size(413, 22);
            this.uiAdresaKlijenta.TabIndex = 17;
            // 
            // uiAddUpdateClient
            // 
            this.uiAddUpdateClient.Location = new System.Drawing.Point(40, 424);
            this.uiAddUpdateClient.Name = "uiAddUpdateClient";
            this.uiAddUpdateClient.Size = new System.Drawing.Size(112, 42);
            this.uiAddUpdateClient.TabIndex = 18;
            this.uiAddUpdateClient.Text = "Dodaj klijenta";
            this.uiAddUpdateClient.UseVisualStyleBackColor = true;
            this.uiAddUpdateClient.Click += new System.EventHandler(this.uiAddUpdateClient_Click);
            // 
            // frmNoviKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.uiAddUpdateClient);
            this.Controls.Add(this.uiAdresaKlijenta);
            this.Controls.Add(this.uiKontaktKlijenta);
            this.Controls.Add(this.uiOIBKlijenta);
            this.Controls.Add(this.uiEmailKlijenta);
            this.Controls.Add(this.uiPrezimeKlijenta);
            this.Controls.Add(this.uiImeKlijenta);
            this.Controls.Add(this.lnTrackBarValue);
            this.Controls.Add(this.tbValuePayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbAnswerNo);
            this.Controls.Add(this.rbAnswerYes);
            this.Controls.Add(this.lasd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNoviKlijent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi klijent";
            this.Load += new System.EventHandler(this.frmNoviKlijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbValuePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lasd;
        private System.Windows.Forms.RadioButton rbAnswerYes;
        private System.Windows.Forms.RadioButton rbAnswerNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbValuePayment;
        private System.Windows.Forms.Label lnTrackBarValue;
        private System.Windows.Forms.TextBox uiImeKlijenta;
        private System.Windows.Forms.TextBox uiPrezimeKlijenta;
        private System.Windows.Forms.TextBox uiEmailKlijenta;
        private System.Windows.Forms.TextBox uiOIBKlijenta;
        private System.Windows.Forms.TextBox uiKontaktKlijenta;
        private System.Windows.Forms.TextBox uiAdresaKlijenta;
        private System.Windows.Forms.Button uiAddUpdateClient;
    }
}