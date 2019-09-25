using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.BLL.OstaleKlase
{
    public class Print
    {
        public DGVPrinter Printer { get; set; }

        public Print(DGVPrinter _printer)
        {
            Printer = _printer;
        }

        public void PrintToPDF(object dgvOtplatnaTablica)
        {
            Printer.Title = "Otplatna tablica ";
            Printer.SubTitle = string.Format("{0}", DateTime.Now.Date) + " " + Environment.NewLine + "Tablicu izdao: " + Zaposlenik.PrijavljeniZaposlenik.Ime + " " + Zaposlenik.PrijavljeniZaposlenik.Prezime;
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            Printer.PageNumberAlignment = StringAlignment.Far;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Moja banka";
            Printer.FooterSpacing = 15;
            Printer.PrintDataGridView(dgvOtplatnaTablica as DataGridView);
        }
    }
}
