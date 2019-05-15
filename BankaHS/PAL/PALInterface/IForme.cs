using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHS.PAL.PALInterface
{
   public interface IForme
    {
        void OdjaviMe(DialogResult result);

        bool ProvjeraAdmina();

        void ProvjeraPrijave();

        void PomocF1();
    }
}
