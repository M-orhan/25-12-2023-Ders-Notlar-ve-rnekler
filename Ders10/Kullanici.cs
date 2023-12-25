using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10
{
    public class Kullanici
    {
        public string Ad;
        public string Soyad;

        public void BilgiGoster()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
        }



    }
}
