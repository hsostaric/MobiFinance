using BankaHS.BLL;
using BankaHS.PAL.AdminForme;
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

namespace BankaHS.PresentationLayer
{
    public partial class PocetanIzbornik : Form, IForme
    {
        public PocetanIzbornik()
        {
            InitializeComponent();
        }

        private void PocetanIzbornik_Load(object sender, EventArgs e)
        {

        }



        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdjaviMe(MessageBox.Show("Želite li se odjaviti sa sustava", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

        public void OdjaviMe(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                Zaposlenik.PrijavljeniZaposlenik = null;
                this.Close();
            }
        }

        private void adminStraniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProvjeraAdmina().Equals(true))
            {
                AdminIzbornik adminIzbornik = new AdminIzbornik();
                this.Hide();
                adminIzbornik.ShowDialog();
                ProvjeraPrijave();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nemate pristup traženom području.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ProvjeraAdmina()
        {
            return (Tip_zaposlenika.ProvjeriPrijavljenog(Zaposlenik.PrijavljeniZaposlenik).Equals(true)) ? true : false;
        }

        public void ProvjeraPrijave()
        {
            if (Zaposlenik.PrijavljeniZaposlenik.Equals(null))
            {
                this.Close();
            }
        }

        public void PomocF1()
        {
            throw new NotImplementedException();
        }
    }
}
