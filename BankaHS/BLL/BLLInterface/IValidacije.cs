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
        bool provjeraPrezimena(string prezime);
        bool provjeraKorisnickogImena(string korisnickoIme);
        bool provjeraRegexa(string polje, string izraz);
        bool provjeraLozinke(string lozinka, string ponovljenaLozinka);
        bool provjeriOIB(string oib);
        bool provjeraEmaila(string email);
    }
}
