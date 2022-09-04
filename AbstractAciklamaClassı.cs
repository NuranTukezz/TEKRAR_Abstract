using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Abstract
{
    class AbstractAciklamaClassı
    {
        //Abstract=Soyut
        //Abstract classlar interfacelerle virtual metodlar gibi düşünebiliriz.
        //abstract class veya metod oluştururken class'a ve metoda abstract keyvord'ünü yazmak zorundayız.
        //Abstract metodlar override edilir bu da şu anlama geliyor
        //oluşturduğum abstact metodumu çağırdığımda hangi amaçla kullanacaksam ona göre metodumun içini doldururum
        //abstract classlar newlenenmez
        //abstact class lar birer Inheritancedir.
        //yani kalıtım verilebilir ve birden fazla kalıtım veremezsin
        //örn:=>
        
        /* 
         -----------------------------------------------------------------------
        
          public abstract class Database  => bu class olsun.
        {
           public void Add()
            {
              consol.writeLine ("ekleme yapıldi");
            }

           public absract void Delete();

        }
       -------------------------------------------------------------------------   
         

        public class SqlServer:Database  =>başka bir class Databaseden miras aldı
        {
        
          public override void Delete()
          {
            thorrow new Not Implemented Exeption();
          } => metod class'a implemente edildiğinde bu şekilde geliyor
        
        }

        -------------------------------------------------------------------------

        Bu demek oluyor ki Ddelete metodu implemente edilen her class'ta farklı işlevi var NORMALDE
        BÖYLEBİEŞEY YOK YANİ DELETE METODU STANDARTTIR ben sadece örnek için yazdım

         */


    }
}
