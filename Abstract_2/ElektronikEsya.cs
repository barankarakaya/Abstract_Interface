using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_2
{
    /* *** Açıklama *****
      1- Abstract olarak işaretlenen FiyatHesapla() methodunun gövdesi abstract olarak tanımlanan temel sınıfta kodlanmaz.
      2- Abstract olan ElektronikEsya sınıfından türetilen sınıflar, ElektronikEsya'nın abstract üyelerini içermek zorundadır.
     */
    abstract class ElektronikEsya
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Telefon : ElektronikEsya
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyati + (KarYuzdesi * AlisFiyati);
        }
    }

    class Bilgisayar : ElektronikEsya
    {
        public decimal EkMasraf { get; set; }

        public override decimal FiyatHesapla()
        {
            return EkMasraf + AlisFiyati + (AlisFiyati * KarYuzdesi);
        }
    }


}
