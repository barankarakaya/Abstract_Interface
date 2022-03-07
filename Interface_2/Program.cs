using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Yonetici y = new Yonetici();
            y.adSoyad = "Tahsin Canpolat";
            y.departman = "Satın alma";
            adSoyadBilgisi(y);
            Console.ReadLine();
        }

        static void adSoyadBilgisi(IKisi kisi)
        {
            Console.WriteLine(kisi.adSoyad);
        }
    }
    interface IKisi
    {
        string adSoyad { get; set; }
        string adres { get; set; }
        string departman { get; set; }

        void bilgi();
    }

    class Yonetici : IKisi
    {
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }

        public void bilgi()
        {
            Console.WriteLine("{0} isimli çalışan {1} departmanında yöneticidir",adSoyad,departman);
        }
    }

    class Isci : IKisi
    {
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }

        public void bilgi()
        {
            Console.WriteLine("{0} isimli çalışan {1} departmanında işçidir", adSoyad, departman);
        }
    }
}
