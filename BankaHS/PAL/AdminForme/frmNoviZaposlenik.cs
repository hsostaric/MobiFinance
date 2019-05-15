using BankaHS.BLL;
using BankaHS.PAL.PALInterface;
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

namespace BankaHS.PAL.AdminForme
{
    public partial class frmNoviZaposlenik : Form, IForme
    {
        private bool uredi = false;
        private Zaposlenik zaposlenik = null;
        public frmNoviZaposlenik()
        {
            InitializeComponent();
        }

        public frmNoviZaposlenik(bool _uredi, Zaposlenik _zaposlenik)
        {
            uredi = _uredi;
            zaposlenik = _zaposlenik;
            InitializeComponent();
        }

        public void OdjaviMe(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                Zaposlenik.PrijavljeniZaposlenik = null;
                this.Close();
            }
        }

        public void PomocF1()
        {
            throw new NotImplementedException();
        }

        public bool ProvjeraAdmina()
        {
            throw new NotImplementedException();
        }

        public void ProvjeraPrijave()
        {
            if (Zaposlenik.PrijavljeniZaposlenik.Equals(null))
            {
                this.Close();
            }
        }

        private void frmNoviZaposlenik_Load(object sender, EventArgs e)
        {
            DohvatiTipoveZaposlenika();
            if (uredi.Equals(true))
            {
                button1.Text = "Ažuriraj";
                podaciZaUpdate();
            }
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdjaviMe(MessageBox.Show("Želite li se odjaviti sa sustava", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (provjeraImena(txtIme.Text).Equals(false)) errorIme.Text = "Morate unijeti ime";
            if (provjeraPrezimena(txtPrezime.Text).Equals(false)) errorPrezime.Text = "Morate unijeti prezime";
            if (provjeraEmaila(txtEmail.Text).Equals(false)) errorEmail.Text = "Email nije unešen ili nije u odgovarajućem formatu";
            if (provjeraKorisnickogImena(txtKorisnickoIme.Text).Equals(false)) errorKorisnickoIme.Text = "Korisničko ime nije uneseno ili nije u odgovarajućem formatu";
            if (provjeraLozinke(txtLozinka.Text, txtPonovljenaLozinka.Text).Equals(false)) errorLozinke.Text = "Lozinke se moraju podudarati";

            else
            {
                if (uredi == false)
                {
                    try
                    {

                        Zaposlenik novi = new Zaposlenik(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtAdresa.Text, txtBrojTelefona.Text, txtKorisnickoIme.Text, txtLozinka.Text, tipzaposlenikaBindingSource.Current as Tip_zaposlenika);
                        novi.DodajZaposlenika();
                        MessageBox.Show("Novi zaposlenik je uspješno dodan.", "Uspješno dodan zaposlenik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        zaposlenik.UrediZaposlenika(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtLozinka.Text, txtKorisnickoIme.Text, txtAdresa.Text, txtBrojTelefona.Text, (tipzaposlenikaBindingSource.Current as Tip_zaposlenika));
                        MessageBox.Show("Podaci su uspješno ažurirani.", "Uspješno ažururan zaposlenik", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.Close();
            }
        }
        private bool provjeraImena(string ime)
        {
            return (ime.Length == 0) ? false : true;
        }
        private bool provjeraPrezimena(string prezime)
        {
            return prezime.Length > 0 ? true : false;
        }

        private bool provjeraEmaila(string email)
        {

            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(email);
            return match.Success && email.Length > 0 ? true : false;
        }
        public bool provjeraKorisnickogImena(string korisnickoIme)
        {
            string reg = "^[a-z0-9_-]{3,15}$";
            return provjeraRegexa(korisnickoIme, reg) && korisnickoIme.Length > 0 ? true : false;
        }
        private bool provjeraRegexa(string polje, string izraz)
        {
            Regex regex = new Regex(@izraz);
            Match match = regex.Match(polje);
            return match.Success ? true : false;
        }
        private bool provjeraLozinke(string lozinka, string ponovljenaLozinka)
        {
            return (lozinka.Equals(ponovljenaLozinka) && lozinka.Length > 0) ? true : false;
        }
        private void DohvatiTipoveZaposlenika()
        {
            tipzaposlenikaBindingSource.DataSource = null;
            tipzaposlenikaBindingSource.DataSource = Tip_zaposlenika.DohvatiSveTipoveZaposlenika();
        }
        private void podaciZaUpdate()
        {
            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtAdresa.Text = zaposlenik.Adresa;
            txtBrojTelefona.Text = zaposlenik.BrojTelefona;
            txtLozinka.Text = zaposlenik.Lozinka;
            txtEmail.Text = zaposlenik.Email;
            txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;

        }
    }
}
