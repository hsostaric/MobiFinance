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
        public frmKlijenti() => InitializeComponent();

        private void btnNoviKlijent_Click(object sender, EventArgs e)
        {

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKlijenti_Load(object sender, EventArgs e)
        {

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
    }
}
