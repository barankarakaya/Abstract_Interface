using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* InterFace(Arayüz) Nedir?
             * Bir sınıf kalıtımla sadece bir sınıftan türeyebilir. Ancak bu kısıtlama interface(arayüz) sayesinde ortadan kalkar ve bir sınıf birden çık interface ile türeyebilir.
             * Interfaceler sınıflar gibi kod ve veri içermez !! sadece tanımlamalar içerir.
             * Aslında Soyut (Abstract) sınıflara çok benzer fakar abstract sınıflarda veriler ve kodlar içerebilir.
             * Interface neden kullanılır?
             * Büyük çaplı ve çok kullanıcılı projelerde geliştiricilerin belirli kurallar tanımlayıp bu kurallar çerçevesinde sınıflar oluşturmasını sağlar.
             * Farklı olarak public,private, protected gibi erişim belirleyiciler kullanılmaz !! 
             * Method gövdesi noktalı virgülle ayrılır.
             * Interface tanımlarken başında "I" ifadesi olmasına dikkat etmemiz gerekmektedir.
             * Bu sayede sınıflar miras aldığı interface in arayüz olup olmadığını rahat şekilde anlar (IArayuz)
             * Interfaceler interfacelerden türeyebilir.
             * Bir ınterface in içinde constructor,destructor tanımlanmaz.

            */
        }
    }
    interface IInsan
    {
        string Ad { get; set; }
    }

    class Insan : IInsan
    {
        public string Ad
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Buyu()
        {
            throw new NotImplementedException();
        }
    }

    // Interface Implementasyon kuralları
    /*
     * Bir arayüzü uyguladığında her methodun kendine uygun bir arayüz methoduyla tam olarak eşleşmesi garanti altına alınmalıdır.
     * Arayüz tanımı ve arayüz uygulaması arasında bir fark var ise hata alırız uygulama derlenmez.
     * Arayüzden türetilen sınıf içerisinde oluşturulan arayüze ait methodlar mutlaka public olarak tanımlanmalıdır.
     * 
     --- Bir sınıf hem bir sınıftan hemde  bir interfaceten miras alabilir.
     
     
     */ 
    class Ogrenci : Insan , IInsan { 
    
        new public void Buyu()
        {

        }
        public Ogrenci(string ad)
        {
            this.Ad = ad;
        }
    }
     
}
