using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.DAL.Repositories
{
    public sealed class StednjaRepository
    {
        private static StednjaRepository instance = null;
        private static readonly object padlock = new object();

        private StednjaRepository()
        {

        }
        public static StednjaRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new StednjaRepository();
                    }
                    return instance;
                }
            }
        }

        public void dodajStednju(Stednja s, Klijent k)
        {
            using (var db = new BankaEntities())
            {
                db.Klijent.Attach(k);
                db.Zaposlenik.Attach(Zaposlenik.PrijavljeniZaposlenik);
                db.Stednja.Add(s);
                db.SaveChanges();
            }
        }

        public List<Stednja> DohvatiAktivneStednjeKlijenta(Klijent klijent)
        {
            using (var db = new BankaEntities())
            {

                db.Klijent.Attach(klijent);
                return klijent.Stednja.Where(x => x.Status > 0).ToList();
            }
        }
        public void AzurirajStatusStednje(Stednja s)
        {
            using (var db = new BankaEntities())
            {
                db.Stednja.Attach(s);
                s.Status = 0;
                db.SaveChanges();
            }
        }
    }
}
