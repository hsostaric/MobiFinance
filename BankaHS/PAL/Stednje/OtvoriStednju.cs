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
    public partial class OtvoriStednju : Form
    {
        private Stednja stednja;
        private double glavnica = 0;
        private int rokOrocenja;
        private Klijent odabraniKlijent;
        public OtvoriStednju()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OtvoriStednju_Load(object sender, EventArgs e)
        {
            preuzmiKlijente();
            gb1.Visible = false;
        }

        private void preuzmiKlijente()
        {
            try
            {
                klijentBindingSource.DataSource = null;
                klijentBindingSource.DataSource = Klijent.DohvatiPopisSvihKlijenata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            prikaziDetaljeStednje();
        }

        public void prikaziDetaljeStednje()
        {
            glavnica = double.Parse(uiVrijednostStednje.Value.ToString());
            rokOrocenja = int.Parse(uiMjeseciStednje.Value.ToString());
            odabraniKlijent = (Klijent)klijentBindingSource.Current;
            stednja = new Stednja(glavnica, rokOrocenja, uiNaziv.Text, odabraniKlijent);
            MessageBox.Show(stednja.EKS.ToString());
        }
    }
}
