using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.ModelLayer.Repositories
{
    public sealed class ZaposlenikRepository
    {
        private static ZaposlenikRepository zaposlenikRepositoryInstance = null;
        private static readonly object padlock = new object();

        private ZaposlenikRepository()
        {
        }
        public static ZaposlenikRepository ZaposlenikRepositoryInstance
        {
            get
            {
                lock (padlock)
                {
                    if (zaposlenikRepositoryInstance == null)
                    {
                        zaposlenikRepositoryInstance = new ZaposlenikRepository();
                    }
                    return zaposlenikRepositoryInstance;
                }
            }
        }


        public List<Zaposlenik> DohvatiZaposlenike()
        {
            using (BankaEntities db = new BankaEntities())
            {
                return db.Zaposlenik.ToList();
            }
        }

        public Zaposlenik DohvatiZaposlenika(string username, string password)
        {


            return DohvatiZaposlenike().Where
                 (x => x.KorisnickoIme.Equals(username) && x.Lozinka.Equals(password))
                 .FirstOrDefault();

        }

        public void Unos(Zaposlenik novi)
        {
            using (var db = new BankaEntities())
            {
                db.Tip_zaposlenika.Attach(novi.Tip_zaposlenika);
                db.Zaposlenik.Add(novi);
                db.SaveChanges();
            }
        }

        public void Uredi(Zaposlenik uredi, string ime, string prezime, string email, string lozinka, string korime, string adresa, string brojTelefona, Tip_zaposlenika tip)
        {
            using (BankaEntities db = new BankaEntities())
            {
                db.Tip_zaposlenika.Attach(tip);
                db.Zaposlenik.Attach(uredi);
                uredi.Ime = ime;
                uredi.Prezime = prezime;
                uredi.Email = email;
                uredi.Lozinka = lozinka;
                uredi.KorisnickoIme = korime;
                uredi.Adresa = adresa;
                uredi.BrojTelefona = brojTelefona;
                uredi.Tip_zaposlenika = tip;
                db.SaveChanges();
            }
        }

        public void Izbrisi(Zaposlenik zaposlenik)
        {
            using (BankaEntities db = new BankaEntities())
            {

                db.Zaposlenik.Attach(zaposlenik);
                db.Zaposlenik.Remove(zaposlenik);
                db.SaveChanges();
            }
        }

        public List<Zaposlenik> DohvatiOdabraneTipoveZaposlenika(Tip_zaposlenika tip)
        {
            using (var db = new BankaEntities())
            {
                db.Tip_zaposlenika.Attach(tip);
                return tip.Zaposlenik.ToList();
            }
        }


    }
}
