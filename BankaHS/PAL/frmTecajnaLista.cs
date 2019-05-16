using BankaHS.BLL.OstaleKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PAL
{
    public partial class frmTecajnaLista : Form
    {
        public frmTecajnaLista()
        {
            InitializeComponent();
        }

        private void frmTecajnaLista_Load(object sender, EventArgs e)
        {
            try
            {
                PrikaziPodatke("http://api.hnb.hr/tecajn/v1");
                NapuniCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrikaziPodatke(string uri)
        {
            List<Tecaj> lista = Tecaj.DohvatiRESTPodatke(uri);
            dgvTecajnaLista.DataSource = null;
            dgvTecajnaLista.DataSource = lista;

        }

        private void NapuniCombobox()
        {
            List<Tecaj> lista = Tecaj.DohvatiRESTPodatke("http://api.hnb.hr/tecajn/v1");
            cbValute.DisplayMember = "Valuta";
            cbValute.SelectedValue = "Valuta";
            cbValute.DataSource = null;
            cbValute.DataSource = lista;
        }

        private void btnActualyList_Click(object sender, EventArgs e)
        {

            try
            {
                PrikaziPodatke("http://api.hnb.hr/tecajn/v1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDateValueFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DohvatiOdredjeneTecaje("http://api.hnb.hr/tecajn/v1", dTimePickerOD.Value, dTimePickerDo.Value, (cbValute.SelectedItem as Tecaj).Valuta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DohvatiOdredjeneTecaje("http://api.hnb.hr/tecajn/v1", dTimePickerOD.Value, dTimePickerDo.Value, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private void DohvatiOdredjeneTecaje(string uri, DateTime datumPocetka, DateTime datumKraja, string valuta)
        {
            string nastavak = "?";
            string datumPocetak = datumPocetka.ToString("yyyy-MM-dd");
            string datumKraj = datumKraja.ToString("yyyy-MM-dd");
            if (datumPocetka.Date > DateTime.Now.Date || datumKraja.Date > DateTime.Now.Date) MessageBox.Show("Vrijednosti nesmiju biti veće od današnjeg dana", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (datumPocetka > datumKraja)
                {
                    string pom = "";
                    pom = datumPocetak;
                    datumPocetka = datumKraja;
                    datumKraj = pom;
                }
                else
                {
                    if (!valuta.Equals(""))
                    {
                        nastavak += "valuta=" + valuta;
                        nastavak += datumPocetka.Equals(datumKraja) ? "&datum=" + datumPocetak : "&datum-od=" + datumPocetak + "&datum-do=" + datumKraj;
                    }
                    else if (valuta.Equals(""))
                    {
                        nastavak += datumPocetka.Equals(datumKraja) ? "datum=" + datumPocetak : "datum-od=" + datumPocetak + "&datum-do=" + datumKraj;
                    }

                    PrikaziPodatke(uri += nastavak);
                }
            }


        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTecajnaLista_SelectionChanged(object sender, EventArgs e)
        {
            label5.Text = dgvTecajnaLista.CurrentRow.Cells[4].Value.ToString();
            txtStranaValuta.Clear();
            uiIznosUKunama.Clear();
        }

        private void uibtnPretvori_Click(object sender, EventArgs e)
        {
            if (Tecaj.ProvjeraUnosa(txtStranaValuta.Text).Equals(false)) MessageBox.Show("Provjerite jeste li uniejli broj", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                uiIznosUKunama.Text = ((dgvTecajnaLista.SelectedRows[0].DataBoundItem) as Tecaj).KonvertirajIznosUKune(txtStranaValuta.Text).ToString();
            }
        }
    }
}

