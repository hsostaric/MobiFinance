
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
        public frmNoviKlijent()
        {
            InitializeComponent();
            validacija = new Validacija();
        }

        private void tbValue_Scroll(object sender, EventArgs e)
        {
            lnTrackBarValue.Text = String.Format(tbValuePayment.Value.ToString() + " HRK");
        }

        private void frmNoviKlijent_Load(object sender, EventArgs e)
        {
            tbValuePayment.Enabled = provjeriOznaceniRadioButton();

        }

        private void uiAddUpdateClient_Click(object sender, EventArgs e)
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

        private void dodajKlijenta()
        {
            try
            {
                Klijent noviKlijent = new Klijent(uiImeKlijenta.Text, uiPrezimeKlijenta.Text, uiOIBKlijenta.Text,
                    uiEmailKlijenta.Text, uiKontaktKlijenta.Text, uiAdresaKlijenta.Text, (provjeriOznaceniRadioButton()), tbValuePayment.Value);
                noviKlijent.DodajKlijenta();
                MessageBox.Show("Novi klijent je uspješno dodan u bazu podataka", "Poruka uspjeha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
