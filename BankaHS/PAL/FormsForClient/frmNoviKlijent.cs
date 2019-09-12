
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
            else errorEmail.Text = "";
            if (validacija.provjeraImena(uiImeKlijenta.Text).Equals(false)) errorName.Text = "Morate unijeti ime.";
            else errorName.Text = "";
            if (validacija.provjeriOIB(uiOIBKlijenta.Text).Equals(false)) errorOIB.Text = "OIB nije u pravilnom formatu.";
            else errorOIB.Text = "";
            if (validacija.provjeraPrezimena(uiPrezimeKlijenta.Text).Equals(false)) errorSurname.Text = "Morate unijeti prezime.";
            if (validacija.provjeraPrezimena(uiPrezimeKlijenta.Text).Equals(true)) errorSurname.Text = "";
            else
            {

            }
        }
        private bool provjeraImena()
        {
            return uiImeKlijenta.Text.Length.Equals(0) ? false : true;
        }
        private bool provjeraPrezimena()
        {
            return uiPrezimeKlijenta.Text.Length.Equals(0) ? false : true;
        }
        private bool ispravnostEmaila()
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(uiEmailKlijenta.Text);
            return match.Success && uiEmailKlijenta.Text.Length > 0 ? true : false;
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
