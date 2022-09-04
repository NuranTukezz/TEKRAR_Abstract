using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Abstract.Models
{
    public class ElekrikFaturası : FaturaBase
    {
        private const decimal enerjiTuketimVergisi = 3;

        //BirimFiyatı kullanıcıdan almazsak sabit bir birimFiyat girdik bu değer üzerinden birimFiyatı belirleyecek bu değeride yazılımcı belirler yani default değer
        public ElekrikFaturası()
        {
            this.birimFiyat = 1.25M;// M=> decimal
        }

        //FaturaBase abstract bir sınıf olduğu için newlenemiyor newlenemediği için ctorunu base keyvordüyle buradaki ctor üzerinden kullanabiliyoruz

        //Sınıfımız FaturaBase'den kalıtım aldığı için ctor unu base üzerinden kullanabiliyoruz yani buradaki ctor üzerinden FaturaBase'nin ctorunu kullanabiliyoruz FaturaBasenin 2 tane ctoru var hangisini kullanacağını seçeceksin ben burada parametreli olanı seçtim çünkü o ctor üzerinden işlem yapacağım

        // public ElekrikFaturası(decimal birimfiyat):base(birimfiyat) =>
        //:base(birimfiyat) =>FaturaBase'nin içindeki parametreli ctor 

        public ElekrikFaturası(decimal birimfiyat):base(birimfiyat)//base ctor ifadesi demek
        {
            //buradaki değer FaturaBase'in içindeki ctora gidecek
        }

        //metodum override olarak geldi yani Hesaplama metodumuzu istediğimiz hesaplamayı yaptırabiliriz
        //public override decimal Hesapla(FaturaBase faturaBase)
        //{
        //    decimal toplamTutar = faturaBase.KullanimMiktari * this.birimFiyat;

        //    decimal vergiliToplamTutar = toplamTutar * enerjiTuketimVergisi;

        //    return vergiliToplamTutar;
        //}

        //Parametresiz hesapla metodu
        public override decimal Hesapla()
        {
            decimal toplamTutar = this.KullanimMiktari * this.birimFiyat;

            decimal vergiliToplamTutar = toplamTutar * enerjiTuketimVergisi;

            return vergiliToplamTutar;
        }
    }
}
