using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PAL.Stednje
{
    public partial class OtvoriStednju : Form
    {
        private Stednja stednja;
        private double glavnica = 0;
        private int rokOrocenja;
        private Klijent odabraniKlijent;
        public OtvoriStednju()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OtvoriStednju_Load(object sender, EventArgs e)
        {
            preuzmiKlijente();
            gb1.Visible = false;
        }

        private void preuzmiKlijente()
        {
            try
            {
                klijentBindingSource.DataSource = null;
                klijentBindingSource.DataSource = Klijent.DohvatiPopisSvihKlijenata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uiNaziv.Text.Length == 0)
            {
                uiGreskaImena.Text = "Morate unijeti ime štednje.";
                uiGreskaImena.ForeColor = Color.Red;
                gb1.Visible = false;
            }
            else
            {
                gb1.Visible = true;
                prikaziDetaljeStednje();
            }
        }

        public void prikaziDetaljeStednje()
        {
            glavnica = double.Parse(uiVrijednostStednje.Value.ToString());
            rokOrocenja = int.Parse(uiMjeseciStednje.Value.ToString());
            odabraniKlijent = (Klijent)klijentBindingSource.Current;
            stednja = new Stednja(glavnica, rokOrocenja, uiNaziv.Text, odabraniKlijent);
            popuniPodatke(stednja);
        }

        private void popuniPodatke(Stednja s)
        {
            uiStednjaImelb.Text = s.Naziv;
            uiEfektivnaValue.Text = s.EKS.ToString();
            uiUkupnaVijednostValue.Text = s.KonacanIznos.ToString("00.00");

        }

        private void uiDodajStednju_Click(object sender, EventArgs e)
        {
            try
            {
                glavnica = double.Parse(uiVrijednostStednje.Value.ToString());
                rokOrocenja = int.Parse(uiMjeseciStednje.Value.ToString());
                odabraniKlijent = (Klijent)klijentBindingSource.Current;
                stednja = new Stednja(glavnica, rokOrocenja, uiNaziv.Text, odabraniKlijent);
                odabraniKlijent.dodijeliKlijentuStednju(stednja);
                MessageBox.Show("Štednja je ugovorena", "Poruka uspjeha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom dodavanja !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiZakljucajStednju_Click(object sender, EventArgs e)
        {
            if ((klijentBindingSource.Current as Klijent).Equals(null))
            {
                MessageBox.Show("Niste odabrali klijenta !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Klijent odabraniKlijent = klijentBindingSource.Current as Klijent;
                frmPrikazStednji aktivneStednje = new frmPrikazStednji(odabraniKlijent);
                aktivneStednje.ShowDialog();
            }

        }
    }
}
