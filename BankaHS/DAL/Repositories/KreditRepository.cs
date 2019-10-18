using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.DAL.Repositories
{
    public sealed class KreditRepository
    {
        private static KreditRepository instance = null;
        private static readonly object padlock = new object();

        private KreditRepository()
        {

        }
        public static KreditRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new KreditRepository();
                    }
                    return instance;
                }
            }
        }

        public List<Kredit_> DohvatiSveAktivneKrediteKorisnika(Klijent klijent)
        {
            using (var db = new BankaEntities())
            {
                db.Klijent.Attach(klijent);
                return klijent.Kredit_.Where(x => x.Status.Equals(1)).ToList();
            }
        }
    }
}
