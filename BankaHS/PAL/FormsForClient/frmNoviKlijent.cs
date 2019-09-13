
using BankaHS.BLL;
using BankaHS.PAL.PALInterface;
using BankaHS.PAL.Validacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PAL.FormsForClient
{
    public partial class frmNoviKlijent : Form
    {
        private IValidacije validacija;
        private Klijent odabraniKlijent = null;
        public frmNoviKlijent()
        {
            InitializeComponent();
            validacija = new Validacija();
        }
        public frmNoviKlijent(Klijent klijent)
        {
            InitializeComponent();
            validacija = new Validacija();
            odabraniKlijent = klijent;
        }

        private void tbValue_Scroll(object sender, EventArgs e)
        {
            lnTrackBarValue.Text = String.Format(tbValuePayment.Value.ToString() + " HRK");
        }

        private void frmNoviKlijent_Load(object sender, EventArgs e)
        {
            if (odabraniKlijent != null)
            {
                uiImeKlijenta.Text = odabraniKlijent.Ime;
                uiPrezimeKlijenta.Text = odabraniKlijent.Prezime;
                uiEmailKlijenta.Text = odabraniKlijent.Email;
                uiOIBKlijenta.Text = odabraniKlijent.OIB;
                uiAdresaKlijenta.Text = odabraniKlijent.Adresa;
                oznaciRadioButton();
                tbValuePayment.Value = provjeriOznaceniRadioButton().Equals(true) ? (int)odabraniKlijent.Primanja : 0;
                uiAddUpdateClient.Text = "Ažuriraj";
                lnTrackBarValue.Text = String.Format(tbValuePayment.Value.ToString() + " HRK");

            }
            tbValuePayment.Enabled = provjeriOznaceniRadioButton();

        }

        private void uiAddUpdateClient_Click(object sender, EventArgs e)

        {
            if (odabraniKlijent == null)
            {
                if (validacija.provjeraEmaila(uiEmailKlijenta.Text).Equals(false)) errorEmail.Text = "E-mail nije u pravilnom formatu.";

                if (validacija.provjeraImena(uiImeKlijenta.Text).Equals(false)) errorName.Text = "Morate unijeti ime.";

                if (validacija.provjeriOIB(uiOIBKlijenta.Text).Equals(false)) errorOIB.Text = "OIB nije u pravilnom formatu.";

                if (validacija.provjeraPrezimena(uiPrezimeKlijenta.Text).Equals(false)) errorSurname.Text = "Morate unijeti prezime.";

                else
                {

                    dodajKlijenta();
                    this.Close();
                }
            }
            else
            {
                if (validacija.provjeraEmaila(uiEmailKlijenta.Text).Equals(false)) errorEmail.Text = "E-mail nije u pravilnom formatu.";

                if (validacija.provjeraImena(uiImeKlijenta.Text).Equals(false)) errorName.Text = "Morate unijeti ime.";

                if (validacija.provjeriOIB(uiOIBKlijenta.Text).Equals(false)) errorOIB.Text = "OIB nije u pravilnom formatu.";

                if (validacija.provjeraPrezimena(uiPrezimeKlijenta.Text).Equals(false)) errorSurname.Text = "Morate unijeti prezime.";
                else
                {
                    urediKlijenta();
                    Close();
                }

            }
        }

        private void dodajKlijenta()
        {
            try
            {
                double vrijednostPrimanja = provjeriOznaceniRadioButton().Equals(true) ? tbValuePayment.Value : 0;
                Klijent noviKlijent = new Klijent(uiImeKlijenta.Text, uiPrezimeKlijenta.Text, uiOIBKlijenta.Text,
                    uiEmailKlijenta.Text, uiKontaktKlijenta.Text, uiAdresaKlijenta.Text, (provjeriOznaceniRadioButton()), vrijednostPrimanja);
                noviKlijent.DodajKlijenta();
                MessageBox.Show("Novi klijent je uspješno dodan u bazu podataka", "Poruka uspjeha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void urediKlijenta()
        {
            try
            {
                double vrijednostPrimanja = provjeriOznaceniRadioButton().Equals(true) ? tbValuePayment.Value : 0;
                odabraniKlijent.UrediKlijenta(uiImeKlijenta.Text, uiPrezimeKlijenta.Text, uiOIBKlijenta.Text,
                        uiEmailKlijenta.Text, uiKontaktKlijenta.Text, uiAdresaKlijenta.Text, (provjeriOznaceniRadioButton()), vrijednostPrimanja);
                MessageBox.Show("Uspješno ste uredili odabranog klijenta", "Poruka uspjeha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void rbAnswerNo_CheckedChanged(object sender, EventArgs e)
        {
            tbValuePayment.Enabled = provjeriOznaceniRadioButton();
        }

        private void rbAnswerYes_CheckedChanged(object sender, EventArgs e)
        {
            tbValuePayment.Enabled = provjeriOznaceniRadioButton();
        }
        private bool provjeriOznaceniRadioButton()
        {
            return (rbAnswerNo.Checked) ? false : true;

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void oznaciRadioButton()
        {
            if (odabraniKlijent.StalnoZaposlenje == true) rbAnswerYes.Checked = true;
            else rbAnswerNo.Checked = true;
        }
    }
}
