using BankaHS.BLL;
using BankaHS.PAL.PALInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PAL.AdminForme
{
    public partial class frmZaposlenici : Form, IForme
    {
        private bool uredi = false;
        public frmZaposlenici()
        {
            InitializeComponent();
        }
        public enum ETipoviZaposlenika
        {
            Svi, Administrator, Obican
        };
        public void OdjaviMe(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                Zaposlenik.PrijavljeniZaposlenik = null;
                this.Close();
            }
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

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {

            podaciComboboxa();
            OsvjeziPrikaz();
        }
        private void podaciComboboxa()
        {
            cbUloge.DataSource = null;
            cbUloge.DataSource = Enum.GetValues(typeof(ETipoviZaposlenika));
            cbUloge.SelectedItem = ETipoviZaposlenika.Svi;
        }
        private void PostaviEnumUCombobox()
        {
            cbUloge.DataSource = null;
            cbUloge.DataSource = Enum.GetValues(typeof(ETipoviZaposlenika));
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdjaviMe(MessageBox.Show("Želite li se odjaviti sa sustava", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

        private bool ProvjeraBrojaZaposlenih(List<Zaposlenik> lista)
        {
            return (lista.Count > 0) ? true : false;
        }

        private void OsvjeziPrikaz()
        {
            if (ProvjeraBrojaZaposlenih(Zaposlenik.PrikazZaposlenika()).Equals(true))
            {
                zaposlenikBindingSource.DataSource = null;
                zaposlenikBindingSource.DataSource = Zaposlenik.PrikazZaposlenika();
            }
            else MessageBox.Show("U bazi nema zaposlenika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PomocF1()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNoviZaposlenik novi = new frmNoviZaposlenik();
            this.Hide();
            novi.ShowDialog();
            ProvjeraPrijave();
            this.Show();
            OsvjeziPrikaz();
        }

        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            uredi = true;
            if ((zaposlenikBindingSource.Current as Zaposlenik).Equals(null)) MessageBox.Show("Morate odabrati zaposlenikaza ažuriranje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                frmNoviZaposlenik forma = new frmNoviZaposlenik(uredi, zaposlenikBindingSource.Current as Zaposlenik);
                this.Hide();
                forma.ShowDialog();
                this.Show();
                OsvjeziPrikaz();
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if ((zaposlenikBindingSource.Current as Zaposlenik).Equals(null)) MessageBox.Show("Morate odabrati zaposlenikaza brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati sljedećeg zaposlenika ?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {
                        (zaposlenikBindingSource.Current as Zaposlenik).ObrisiZaposlenika();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Zaposlenik je uklonjen iz baze", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OsvjeziPrikaz();
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
            txtIme.Clear();
            txtPrezime.Clear();

        }



        private void FiltrirajZaposlenike(List<Zaposlenik> zaposlenici)
        {
            zaposlenikBindingSource.DataSource = null;
            zaposlenikBindingSource.DataSource = zaposlenici;
        }



        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Zaposlenik> lista = null;
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Svi))
            {
                lista = Zaposlenik.PrikazZaposlenika();
            }
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Administrator) && txtIme.Text == "" && txtPrezime.Text == "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipAdmin());
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Administrator) && txtIme.Text != "" && txtPrezime.Text == "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipAdmin(), txtIme.Text, 1);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Administrator) && txtIme.Text == "" && txtPrezime.Text != "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipAdmin(), txtPrezime.Text, 2);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Administrator) && txtIme.Text != "" && txtPrezime.Text != "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipAdmin(), txtIme.Text, txtPrezime.Text);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Obican) && txtIme.Text == "" && txtPrezime.Text == "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipObican());
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Obican) && txtIme.Text != "" && txtPrezime.Text == "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipObican(), txtIme.Text, 1);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Obican) && txtIme.Text == "" && txtPrezime.Text != "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipObican(), txtPrezime.Text, 2);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Obican) && txtIme.Text != "" && txtPrezime.Text != "") lista = Zaposlenik.DohvatiOdredjeneZaposlenike(Tip_zaposlenika.TipObican(), txtIme.Text, txtPrezime.Text);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Svi) && txtIme.Text == "" && txtPrezime.Text == "") lista = Zaposlenik.PrikazZaposlenika();
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Svi) && txtIme.Text != "" && txtPrezime.Text == "") lista = Zaposlenik.PrikazZaposlenika(txtIme.Text, 1);
            if (cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Svi) && txtIme.Text != "" && txtPrezime.Text != "") lista = Zaposlenik.PrikazZaposlenika(txtIme.Text, txtPrezime.Text);
            if ((cbUloge.SelectedValue.Equals(ETipoviZaposlenika.Svi) && txtIme.Text == "" && txtPrezime.Text != "")) lista = Zaposlenik.PrikazZaposlenika(txtPrezime.Text, 2);
            FiltrirajZaposlenike(lista);
        }
    }
}

