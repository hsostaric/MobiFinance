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

namespace BankaHS.PAL.AdminForme
{
    public partial class frmTipStednje : Form
    {
        public frmTipStednje()
        {
            InitializeComponent();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajVrstuStednje_Click(object sender, EventArgs e)
        {
            frmNovaVrstaStednje forma = new frmNovaVrstaStednje();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void frmTipStednje_Load(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }
        private void OsvjeziPrikaz()
        {
            vrstaStednjeBindingSource.DataSource = null;
            vrstaStednjeBindingSource.DataSource = VrstaStednje.DohvatiTipoveStednja();
        }
    }
}
