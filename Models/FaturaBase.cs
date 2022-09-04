using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Abstract.Models
{
    public abstract class FaturaBase
    {
        //fielt lere değeri ctor üzerinden atıyoruz yani değer set ediyoruz
        public decimal birimFiyat;//birim fiyata her fatura hesaplaması farklı olacağı için değer ataması yapmadık

        public int IlkIndex { get; set; }
        public int SonIndex { get; set; }
        public int KullanimMiktari
        {
            get
            {
                return this.SonIndex - this.IlkIndex;
            }
        }

        public FaturaBase(decimal birimFiyat)//birim fiyat üzerinden hesaplama yapılacak
        {
            this.birimFiyat = birimFiyat;
        }//=> Parametreli ctor

        public FaturaBase()
        {

        }//=>Boş ctor parametresiz


        //Parametresiz hesapla metodu

        public abstract decimal Hesapla();//=>abstract metod


        // public abstract decimal Hesapla(FaturaBase faturaBase);//=>abstract metod

        //=> Hesapla(FaturaBase faturaBase); FaturaBasenin içindeki propları kullanarak hesaplama yap diyoruz

        //anstract metodlarda metodum body2si yazılmaz yani metodun içindeki kodlar
        //neden yazılmaz çünkü sınıflara miras verecek  yani
        //Hesapla metodunu kullanacağımız diğre sınıflarda başka hesaplamalar yapacak
        //Hepsinde başka hesaplama yapacak
        //Eğer bu metodun body'si olsaydı miras alan bütün sınıflarda aynı hesaplamayı yapacaktı
        //ama biz başka hesaplamalarda istediğimiz için abstrack oluşturduk


    }
}
