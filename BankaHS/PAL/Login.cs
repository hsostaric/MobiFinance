using BankaHS.BLL;
using BankaHS.PresentationLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankaHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uiGumbPrijava_Click(object sender, EventArgs e)
        {

            if (new Zaposlenik().provjeriPrijavu(txtUserName.Text, txtPassword.Text).Equals(false))
            {
                OcistiBoxove();
                MessageBox.Show("Unijeli ste pogresne podatke za prijavu,\nPokušajte ponovno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OcistiBoxove();
                PocetanIzbornik forma = new PocetanIzbornik();
                this.Hide();
                forma.ShowDialog();
                this.Show();


            }
        }

        public void OcistiBoxove()
        {
            txtPassword.ResetText();
            txtUserName.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
