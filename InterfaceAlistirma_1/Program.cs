using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlistirma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();
            musteri1.ekle();
            musteri1.getir();
            musteri1.guncelle();
            musteri1.sil();
            Console.ReadLine();
        }
    }
}
