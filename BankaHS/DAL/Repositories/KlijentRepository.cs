using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.DAL.Repositories
{
    public sealed class KlijentRepository
    {
        private static KlijentRepository instance = null;
        private static readonly object padlock = new object();

        private KlijentRepository()
        {

        }
        public static KlijentRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new KlijentRepository();
                    }
                    return instance;
                }
            }
        }

        public List<Klijent> DohvatiSveKlijente()
        {
            using (var db = new BankaEntities())
            {
                return db.Klijent.ToList();
            }
        }

        public void DodajKlijentaUBazu(Klijent noviKlijent)
        {
            using (var db = new BankaEntities())
            {
                db.Klijent.Add(noviKlijent);
                db.SaveChanges();
            }
        }
    }
}
