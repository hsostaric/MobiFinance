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
    public partial class AdminIzbornik : Form, IForme
    {
        public AdminIzbornik()
        {
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

        private void AdminIzbornik_Load(object sender, EventArgs e)
        {

        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdjaviMe(MessageBox.Show("Želite li se odjaviti sa sustava", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uibtnAdminZaposlenici_Click(object sender, EventArgs e)
        {
            frmZaposlenici zaposlenici = new frmZaposlenici();
            this.Hide();
            zaposlenici.ShowDialog();
            ProvjeraPrijave();
            this.Show();
        }

        public void PomocF1()
        {
            throw new NotImplementedException();
        }


    }
}
