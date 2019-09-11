using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PAL.FormsForClient
{
    public partial class frmNoviKlijent : Form
    {
        public frmNoviKlijent()
        {
            InitializeComponent();
        }

        private void tbValue_Scroll(object sender, EventArgs e)
        {
            lnTrackBarValue.Text = String.Format(tbValuePayment.Value.ToString() + " HRK");
        }

        private void frmNoviKlijent_Load(object sender, EventArgs e)
        {

        }

        private void uiAddUpdateClient_Click(object sender, EventArgs e)
        {

        }
        private bool provjeraImena()
        {
            return uiImeKlijenta.Text.Length.Equals(0) ? false : true;
        }
        private bool provjeraPrezimena()
        {
            return uiPrezimeKlijenta.Text.Length.Equals(0) ? false : true;
        }
        private bool ispravnostEmaila()
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(uiEmailKlijenta.Text);
            return match.Success && uiEmailKlijenta.Text.Length > 0 ? true : false;
        }
    }
}
