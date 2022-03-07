using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_3
{
    abstract class Tekstil
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Tshirt : Tekstil
    {
        
        public override decimal FiyatHesapla()
        {
            return AlisFiyati + (KarYuzdesi * AlisFiyati);
        }
    }

    class Elbise : Tekstil
    {
        public decimal EkMasraf { get; set; }
        public override decimal FiyatHesapla()
        {
            return AlisFiyati + EkMasraf + (AlisFiyati * KarYuzdesi);
        }
    }
}
