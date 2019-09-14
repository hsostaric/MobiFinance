using BankaHS.BLL;
using BankaHS.PAL.FormsForClient;
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
    public partial class frmKlijenti : Form
    {

        public frmKlijenti()
        {
            InitializeComponent();
        }
        private Klijent odabraniKlijent;
        private void btnNoviKlijent_Click(object sender, EventArgs e)
        {

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKlijenti_Load(object sender, EventArgs e)
        {
            prikaziKlijente(Klijent.DohvatiPopisSvihKlijenata());
        }
        private void prikaziKlijente(List<Klijent> lista)
        {
            try
            {
                klijentBindingSource.DataSource = null;
                klijentBindingSource.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void nazadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            frmNoviKlijent newClient = new frmNoviKlijent();
            newClient.ShowDialog();
            prikaziKlijente(Klijent.DohvatiPopisSvihKlijenata());

        }

        private void uiFullClientData_Click(object sender, EventArgs e)
        {
            try
            {
                odabraniKlijent = (Klijent)klijentBindingSource.Current;
                frmFullDataOfClient forma = new frmFullDataOfClient(odabraniKlijent);
                forma.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAzurirajKlijenta_Click(object sender, EventArgs e)
        {
            odabraniKlijent = (Klijent)klijentBindingSource.Current;
            frmNoviKlijent forma = new frmNoviKlijent(odabraniKlijent);
            forma.ShowDialog();
            prikaziKlijente(Klijent.DohvatiPopisSvihKlijenata());
        }

        private void uiReset_Click(object sender, EventArgs e)
        {
            try
            {
                prikaziKlijente(Klijent.DohvatiPopisSvihKlijenata());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uiSearchClients_Click(object sender, EventArgs e)
        {
            try
            {
                prikaziKlijente(Klijent.PretraziKlijente(uiClientName.Text, uiClientSurname.Text, uiClientOIB.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
