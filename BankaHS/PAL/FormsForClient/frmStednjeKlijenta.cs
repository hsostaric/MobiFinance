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
    public partial class frmStednjeKlijenta : Form
    {

        private Klijent odabraniKlijent;
        public frmStednjeKlijenta()
        {
            InitializeComponent();
        }
        public frmStednjeKlijenta(Klijent _odabraniKlijent)
        {
            odabraniKlijent = _odabraniKlijent;
            InitializeComponent();
        }
        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStednjeKlijenta_Load(object sender, EventArgs e)
        {
            prikaziStednjeKlijenta();
        }

        public void prikaziStednjeKlijenta()
        {
            stednjaBindingSource.DataSource = null;
            stednjaBindingSource.DataSource = odabraniKlijent.StednjeKlijenta();
        }
    }
}
