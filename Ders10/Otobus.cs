using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Ders10
{
    public class Otobus
    {
        public string FirmaAdı;
        public int Toplamkoltuksayısı;
        public int Boskoltuksayısı;
        public string Gun;
        public string Saat;
        public string Plaka;
        public string Guzergah;
        public string MolaYer;
        public int İndirimli;
        public int Tam;
        public int Kazanc = 0;
        public int IptalSayisi = 0;
        public Otobus(string FirmaAdı, int koltukSayisi, string Gun, string Saat, string Plaka, string Guzergah,string MolaYer,int İndirimli,int Tam)
        {
            this.FirmaAdı = FirmaAdı;
            Toplamkoltuksayısı= koltukSayisi;
            Boskoltuksayısı = koltukSayisi;
            this.Gun = Gun;
            this.Saat = Saat;
            this.Plaka = Plaka;
            this.Guzergah = Guzergah;
            this.MolaYer = MolaYer;
            this.İndirimli=İndirimli;
            this.Tam = Tam;
        }

        public void BiletSat(bool İndirimliMi)
        {
            if(Boskoltuksayısı > 0)
            {
                Boskoltuksayısı = Boskoltuksayısı - 1;
                if (İndirimliMi)
                {
                    Kazanc = Kazanc + İndirimli;
                    Console.WriteLine("1 adet indirimli bilet sattınız");
                }
                else
                {
                    Kazanc = Kazanc + Tam;
                    Console.WriteLine("1 adet tam bilet sattınız");
                }
               
            }
            else
            {
                Console.WriteLine("Boş koltuk kalmamıştır");
            }
        }

        public void KazancOgren()
        {
            Console.WriteLine("Kazanç: " + Kazanc);
        }

        public void BosKoltukSayisiOgren()
        {
            Console.WriteLine((Toplamkoltuksayısı - Boskoltuksayısı) + " adet bilet sattınız ");
            Console.WriteLine("Boş Koltuk Sayısı : " + Boskoltuksayısı);
        }

        public void Biletİptal(bool İndirimliMi)
        {
            IptalSayisi++; 
            Boskoltuksayısı++;
            if (İndirimliMi)
            {
                Kazanc = Kazanc - İndirimli;
                Console.WriteLine("Bir adet indirimli bilet iptal edildi");
            }
            else
            {
                Kazanc = Kazanc - Tam;
                Console.WriteLine("Bir adet tam bilet iptal edildi");
            }
        }
        public void IptalSayisiOgren()
        {
            Console.WriteLine("İptal edilen bilet sayısı : " + IptalSayisi);
        }
    }
}
