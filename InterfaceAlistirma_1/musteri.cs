using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlistirma_1
{
    public class musteri : Imusteri
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri Eklendi..");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri Getirildi...");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güncellendi..");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri Silindi.");
        }
    }
}
