using BankaHS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHS.DAL.Repositories
{
    public class VrstaStednjeRepository
    {
        private static VrstaStednjeRepository instance = null;
        private static readonly object padlock = new object();
        private VrstaStednjeRepository()
        {

        }
        public static VrstaStednjeRepository Instance
        {

            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new VrstaStednjeRepository();
                    }
                    return instance;
                }
            }
        }
        public List<VrstaStednje> DohvatiSveTipoveStednje()
        {
            using (var db = new BankaEntities())
            {
                return db.VrstaStednje.ToList();
            }
        }

    }
}
