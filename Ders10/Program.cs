using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ogrenci o = new Ogrenci();
             o.Ad = "Ali";
             o.Soyad = "Veli";
             o.OgrNo = "123456";

             o.BilgiGoster();
             o.DersSec();

             Akademisyen a = new Akademisyen();
             a.Ad = "Hayri";
             a.Soyad = "Can";
             a.Unvan = "Prof";
             a.BilgiGoster();
             a.NotGiris();*/

            /* B b = new B();*/

            Otobus otobus = new Otobus("Metro",40,"Pazartesi","15:00","34 ABC 123","Düzce - İstanbul","Berceste",400,600);
            Console.WriteLine("Otobüs Firması: " + otobus.FirmaAdı);
            Console.WriteLine("Hareket Saati : " + otobus.Saat);

            otobus.BiletSat(true);
            otobus.BiletSat(true);
            otobus.BiletSat(true);
            otobus.BiletSat(false);
            otobus.BiletSat(false);
            otobus.BiletSat(false);

            otobus.BosKoltukSayisiOgren();
            otobus.KazancOgren();
            otobus.Biletİptal(true);
            otobus.Biletİptal(false);
            otobus.KazancOgren();
            otobus.BosKoltukSayisiOgren();
            otobus.IptalSayisiOgren();


        }
    }
}
