using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absctarct_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Abstarct Nedir?
             Bu classlar oluşturulması istenen classların sadece base sınıf olarak davranması ve üzerinde instance oluşturulmasının istendiği durumlarda kullanılır.
            c#'da bu durumu sağlamak için classlarda absctarct ifadesini kullanmamız yeterli olacaktır.
            *Bir abstract (soyut) sınıf oluşturuyorsak sınıf içerisinde muhakkak bir abstract metot, eğer bir abstract metot tanımlıyorsak muhakkak sınıf yapısının da abstract class olması gerekmektedir.
            *Abstract sınıf kullanılarak türetilen sınıf içerisindeki abstract metot yapısı override edilerek içerisinin doldurulması gerekir.

            */

            TureyenSinif tureyen = new TureyenSinif();
            tureyen.Method_1();

            //TemelSinif temel = new TemelSinif(); // Soyut bir sınıf abstract sınıf bunu nesne olarak oluşturamayız.
        }

    }
    public abstract class TemelSinif
    {
        public void Method_1()
        {
            Console.WriteLine("Abstract Sınıf içersinde oluşturulmuş Method.");
        }

        public abstract void Method_2();
    }

    /* TemelSinif abstract bir sınıf olduğu için sadece kalıtım amaçlı kullanılır. Method_1 Temel siniftan türetilen sınıflara doğrudan aktarılacaktır.
      Abstarct bildirimi yapılmış olan Method_2'nin ise türetilmiş sınıflar içerisinde tanımlanması (gövdesinin yazılması) gerekmektedir.
    */


    public class TureyenSinif : TemelSinif
    {
        
        public override void Method_2()
        {
            Console.WriteLine("Türetilmiş sınıf içerisinde tanımlanmış method.");
        }
    }

    /* Abstract sınıfların Normal sınıflardan Farkı Nedir?
     *Fark1 : Normal sınıflar içerisinde method bildirimi yapılmazken, Abstract sınıflar içerisinde tıpkı Arayüzler (Interfaceler) de olduğu gibi method bildirimi yapılabilir.
     *Bildirimi yapılan methodlar, Abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.
     *Fark2 : Normal sınıflarda "new()" anahtar kelimesini kullanarak nesneler oluşturulabilirken. Abstract sınıflar tamamen
     *kalıtım amaçlı geliştirilidiği için nesne oluşturulamaz!!     
     */

}
