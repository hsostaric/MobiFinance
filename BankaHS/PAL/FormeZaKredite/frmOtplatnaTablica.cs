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

namespace BankaHS.PAL.FormeZaKredite
{
    public partial class frmOtplatnaTablica : Form
    {
        private Kredit_ kredit;

        public frmOtplatnaTablica()
        {
            InitializeComponent();
        }
        public frmOtplatnaTablica(Kredit_ _kredit)
        {
            kredit = _kredit;
            InitializeComponent();

        }

        private void uiZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOtplatnaTablica_Load(object sender, EventArgs e)
        {
            PrikazOtplatneTablice();
        }

        public void PrikazOtplatneTablice()
        {
            try
            {
                otplatnatablicaBindingSource.DataSource = null;
                kredit.IzracunajOtplatnuTablicu();
                otplatnatablicaBindingSource.DataSource = kredit.KolekcijaZapisa;
            }
            catch
            {
                MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
