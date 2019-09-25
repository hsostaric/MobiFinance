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

namespace BankaHS.PAL.FormsForClient
{
    public partial class frmFullDataOfClient : Form
    {
        private Klijent odabraniKlijent;
        public frmFullDataOfClient(Klijent pom)
        {
            InitializeComponent();
            odabraniKlijent = pom;
        }

        private void frmFullDataOfClient_Load(object sender, EventArgs e)
        {
            PrikaziPodatke();
        }
        private void PrikaziPodatke()
        {
            label9.Text = odabraniKlijent.Ime;
            label10.Text = odabraniKlijent.Prezime;
            label11.Text = odabraniKlijent.OIB;
            label12.Text = odabraniKlijent.Email;
            label13.Text = odabraniKlijent.Adresa;
            label14.Text = odabraniKlijent.Kontakt;
            label15.Text = odabraniKlijent.zaposlenje();
            label16.Text = String.Format(odabraniKlijent.Primanja.ToString() + "  HRK");
            uiLbBrojStednji.Text = odabraniKlijent.brojStednjiKlijenta().ToString();


        }


        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiStednje_Click(object sender, EventArgs e)
        {
            frmStednjeKlijenta forma = new frmStednjeKlijenta(odabraniKlijent);
            forma.ShowDialog();
        }
    }
}
