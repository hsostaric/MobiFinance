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
            prikaziZaposlenike();
        }
        private void prikaziZaposlenike()
        {
            try
            {
                klijentBindingSource.DataSource = null;
                klijentBindingSource.DataSource = Klijent.DohvatiPopisSvihKlijenata();
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
    }
}
