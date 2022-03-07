using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_3
{
    class Program
    {
        // Ödev : Abstract Class tanımlayarak vasıta adlı bir sınıf oluşturun bunda türeyen sınıflar(otomobil,motosiklet,bisiklet,at arabası) ötv,kdv bilgilerini yeniden yapılandırabilsin.
        // Temel sınıfta propery olarak Vasıta ismi, Fiyat , Favori (boolean)
        // Türeyen sınıflarda belli başlı özel propertyler olabilir örneğin : Otomobilde Vites,KasaTipi,Motor gücü
        // Bunları örneklem olarak oluşturup favorilistem adlı bir liste oluşturup bu listeyi göstereceksiniz.
        static void Main(string[] args)
        {
            Tshirt tshirt = new Tshirt()
            {
                AlisFiyati = 120,
                KarYuzdesi = (decimal)20 / 100
            };

            Console.WriteLine("Tshirt Fiyatı : {0}",tshirt.FiyatHesapla());

            Elbise elbise = new Elbise()
            {
                AlisFiyati = 230,
                KarYuzdesi = (decimal)25 / 100,
                EkMasraf = 20
            };

            Console.WriteLine("Elbise Fiyatı : {0}",elbise.FiyatHesapla());

            Console.ReadLine();
        }
    }
}
