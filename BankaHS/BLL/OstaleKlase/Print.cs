using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.BLL.OstaleKlase
{
    public class Print
    {
        public DGVPrinter Printer { get; set; }

        public Print(DGVPrinter _printer)
        {
            Printer = _printer;
        }

        public void PrintToPDF()
        {

        }
    }
}
