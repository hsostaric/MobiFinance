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

namespace BankaHS.PAL.Stednje
{
    public partial class frmPrikazStednji : Form
    {
        private Klijent klijent;
        public frmPrikazStednji()
        {
            InitializeComponent();
        }
        public frmPrikazStednji(Klijent odabraniKlijent)
        {
            klijent = odabraniKlijent;
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrikazStednji_Load(object sender, EventArgs e)
        {
            prikaziAktivneStednjeKlijenta();
        }

        private void prikaziAktivneStednjeKlijenta()
        {
            if (klijent.AktivneStednjeKlijenta().Count == 0)
            {
                MessageBox.Show("Odabrani klijent nema otvorenih štednji", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                stednjaBindingSource.DataSource = null;
                stednjaBindingSource.DataSource = klijent.AktivneStednjeKlijenta();
            }
        }

        private void uiZakljucajStednju_Click(object sender, EventArgs e)
        {
            if ((stednjaBindingSource.Current.Equals(null)))
            {
                MessageBox.Show("Niste odabrali niti jednu štednju !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Stednja odabranaStednja = stednjaBindingSource.Current as Stednja;
                odabranaStednja.AzurirajStatusStednje();

                MessageBox.Show("Štednja je uspješno zatvorena !", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (klijent.AktivneStednjeKlijenta().Count == 0) this.Close();
                prikaziAktivneStednjeKlijenta();
            }
        }
    }
}
