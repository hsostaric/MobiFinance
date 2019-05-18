using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BankaHS.BLL.OstaleKlase
{
    public class Tecaj
    {

        public int BrojTecajnice { get; set; }

        public string DatumPrimjene { get; set; }

        public string Drzava { get; set; }

        public string SifraValute { get; set; }

        public string Valuta { get; set; }

        public int Jedinica { get; set; }
        [JsonProperty(PropertyName = "Kupovni za devize")]
        public string KupovniZaDevize { get; set; }
        [JsonProperty(PropertyName = "Srednji za devize")]
        public string SrednjiZaDevize { get; set; }
        [JsonProperty(PropertyName = "Prodajni za devize")]
        public string ProdajniZaDevize { get; set; }
        public Tecaj()
        {

        }

        public static List<Tecaj> DohvatiRESTPodatke(string uri)
        {

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            string podaci = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            return JsonConvert.DeserializeObject<List<Tecaj>>(podaci);
        }

        public static bool ProvjeraUnosa(string unos)
        {

            return (double.TryParse(unos, out double broj)) ? true : false;
        }

        public double KonvertirajIznosUKune(string iznos)
        {
            double mnozenik = double.Parse(iznos, CultureInfo.CurrentCulture);
            double mnozitelj = double.Parse(this.KupovniZaDevize, CultureInfo.CurrentCulture);
            if (this.SifraValute.Equals("348") || this.SifraValute.Equals("392")) mnozitelj /= 100;
            return Math.Round(mnozenik * mnozitelj, 2);
        }

    }
}
