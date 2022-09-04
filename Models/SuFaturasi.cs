using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Abstract.Models
{
    public class SuFaturasi : FaturaBase
    {
        private const decimal suTuketimVergisi = 0.5M;

        public SuFaturasi()
        {
            this.birimFiyat = 0.75M;
        }
        public SuFaturasi(decimal birimFiyat):base(birimFiyat)
        {

        }

        //public override decimal Hesapla(FaturaBase faturaBase)
        //{
        //    decimal toplamTutar = faturaBase.KullanimMiktari * this.birimFiyat;

        //    decimal vergiliToplamTutar = toplamTutar * suTuketimVergisi;

        //    return vergiliToplamTutar;
        //}

        //Parametresiz hesapla metodu

        public override decimal Hesapla()
        {
            decimal toplamTutar = this.KullanimMiktari * this.birimFiyat;

            decimal vergiliToplamTutar = toplamTutar * suTuketimVergisi;

            return vergiliToplamTutar;
        }
    }
}
