using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari
{
    class Calisan
    {
        public int TCkimlikNo { get; set; }
        public double maas { get; set; }
        public string ElemanTuru { get; set; }

        public override string ToString()
        {
            return string.Format("T.C. Kimlik No\t: {0} \t Maaş : {1}", TCkimlikNo, maas);
        }

        public virtual double PrimliMaasHesapla(int satisAdeti)
        {
            double prim = satisAdeti * 10;
            return maas + prim;
        }
    }
}
