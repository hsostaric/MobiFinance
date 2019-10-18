using BankaHS.PAL.FormeZaKredite;
using BankaHS.PAL.PALInterface;
using BankaHS.PAL.Validacije;
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

namespace BankaHS.PAL.Krediti
{
    public partial class frmZahtjevZaKredit : Form
    {
        private IValidacije validacija;
        private Klijent odabraniKlijent;
        public frmZahtjevZaKredit()
        {
            validacija = new Validacija();
            InitializeComponent();
            uiDatumPocetka.Format = DateTimePickerFormat.Custom;
            uiDatumPocetka.CustomFormat = "yyyy-MM-dd 00:00:00.000";
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmZahtjevZaKredit_Load(object sender, EventArgs e)
        {
            try
            {
                prikaziKlijente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod dohvaćanja klijenta iz baze. ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void prikaziKlijente()
        {
            klijentBindingSource.DataSource = null;
            klijentBindingSource.DataSource = Klijent.DohvatiPopisSvihKlijenata();
        }
        private void uiIzradiTablicu_Click(object sender, EventArgs e)
        {
            if (validacija.nazivKredita(uiNazivKredita.Text).Equals(true)
                && validacija.provjeraKamate(uiKamatnaStopa.Text).Equals(true))
            {
                frmOtplatnaTablica forma = new frmOtplatnaTablica(new Kredit_(uiDatumPocetka.Value, double.Parse(uiKamatnaStopa.Text),
                    double.Parse(uiGlavnicaKredita.Value.ToString()), int.Parse(uiBrojAnuiteta.Value.ToString()), uiNazivKredita.Text));
                forma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja !!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiIzracunajKreditniRejting_Click(object sender, EventArgs e)
        {
            if (validacija.nazivKredita(uiNazivKredita.Text).Equals(true)
                && validacija.provjeraKamate(uiKamatnaStopa.Text).Equals(true))
            {
                odabraniKlijent = (Klijent)klijentBindingSource.Current;
                uiKreditniRejting.Text = odabraniKlijent.VratiKreditniRejtingKlijenta(new Kredit_(uiDatumPocetka.Value, double.Parse(uiKamatnaStopa.Text),
                     double.Parse(uiGlavnicaKredita.Value.ToString()), int.Parse(uiBrojAnuiteta.Value.ToString()), uiNazivKredita.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja !!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiOtvoriKredit_Click(object sender, EventArgs e)
        {

        }
    }
}
