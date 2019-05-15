using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.DAL.Repositories
{
    public sealed class TipZaposlenikaRepository
    {
        private static TipZaposlenikaRepository instance = null;
        private static readonly object padlock = new object();
        private TipZaposlenikaRepository()
        {

        }

        public static TipZaposlenikaRepository Instance
        {

            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TipZaposlenikaRepository();
                    }
                    return instance;
                }
            }
        }
        public List<Tip_zaposlenika> DohvatiSveVrsteZaposlenih()
        {
            using (BankaEntities db = new BankaEntities())
            {
                return db.Tip_zaposlenika.ToList();
            }
        }
        public Tip_zaposlenika ProvjeriTipZaposlenog(Zaposlenik zaposlenik)
        {
            return DohvatiSveVrsteZaposlenih().FirstOrDefault(x => x.Id.Equals(zaposlenik.Tip_id));
        }

        public Tip_zaposlenika TipZaposlenikaAdmin()
        {
            using (var db = new BankaEntities())
            {
                return db.Tip_zaposlenika.FirstOrDefault(x => x.Naziv.Equals("Administrator"));
            }
        }
        public Tip_zaposlenika TipZaposlenikaObican()
        {
            using (var db = new BankaEntities())
            {
                return db.Tip_zaposlenika.FirstOrDefault(x => x.Naziv.Equals("Obican"));
            }
        }





    }
}
