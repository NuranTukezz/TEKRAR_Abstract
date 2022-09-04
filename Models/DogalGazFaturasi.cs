using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Abstract.Models
{
    public class DogalGazFaturasi : FaturaBase
    {
        private const decimal dogalgazTuketimVergisi = 0.80M;

        public DogalGazFaturasi()
        {
            this.birimFiyat = 3M;
        }
        public DogalGazFaturasi(decimal birimFiyat):base(birimFiyat)
        {

        }

        //public override decimal Hesapla(FaturaBase faturaBase)
        //{
        //    decimal toplamTutar = faturaBase.KullanimMiktari * this.birimFiyat;

        //    decimal vergiliToplamTutar = toplamTutar * dogalgazTuketimVergisi;

        //    return vergiliToplamTutar;
        //}


        //Parametresiz hesapla metodu

        public override decimal Hesapla()
        {
            decimal toplamTutar = this.KullanimMiktari * this.birimFiyat;

            decimal vergiliToplamTutar = toplamTutar * dogalgazTuketimVergisi;

            return vergiliToplamTutar;
        }
    }
}
