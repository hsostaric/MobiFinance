using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.PAL.PALInterface
{
    interface IValidacije
    {
        bool provjeraImena(string ime);
        bool provjeraPrzimena(string prezime);
        bool provjeraKorisnickogImena(string korisnickoIme);
        bool provjeraRegexa(string polje, string izraz);
    }
}
