using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar3
{
    internal class Program
    {
       //geri değer döndüren 2 parametreli metod
        public static float Zam(float fiyat,float oran)
        {
            fiyat += fiyat * oran / 100;
            return fiyat;
        }

        public static float indirim(float fiyat,float oran)
        {
            if (fiyat < 100)
            {
                fiyat-=fiyat*oran / 100;
                fiyat -= 10;
                return fiyat;
            }
            else
            {
                return fiyat - 50;
            }
        }
        public static void Ozellik(string urunad,float fiyat)
        {
            if(urunad=="bardak" || urunad== "sürahi")
            {
                Console.WriteLine("bardak ve sürahide indirimden faydalanın");
            }
            else
            {
                Console.WriteLine("Diğer ürünlerde extra indirim var");
                Console.WriteLine("Fiş tutarı üzerinden 100 tl indiirim");
                fiyat -= 100;
                Console.WriteLine("Son Tutar= "+fiyat);
            }
            Console.WriteLine("Kampanyaya katılmak ister misiniz?");
            string deger = Console.ReadLine();

            if(deger=="evet")
            {
                int hediyeceki = 500;
                Console.WriteLine("Bir dahaki alışverişte " + hediyeceki + " kadar bonus para kazandınız");
            }
            else
            {
                Console.WriteLine("bye bye");
            }
        }
        
        
        static void Main(string[] args)
        {
            //1- Bardak
            //2-Sürahi
            //3-Termos

            float fiyat = 0;
            float oran = 0;

            Console.WriteLine("1-Bardak");
            Console.WriteLine("2-Sürahi");
            Console.WriteLine("3-Termos");
            Console.WriteLine("Ürün Seçiniz");

            string urun=Console.ReadLine();

            switch(urun)
            {
                case "bardak":
                    Console.WriteLine("Fiyat Giriniz: ");
                    fiyat=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Oran Giriniz: ");
                    oran = Convert.ToSingle(Console.ReadLine());

                    float sonuc=Zam(fiyat, oran);
                    Console.WriteLine("Ödemeniz gereken tutar= "+sonuc);
                    Ozellik(urun,fiyat);
                    break;

                case "sürahi":
                    Console.WriteLine("Fiyat Giriniz: ");
                    fiyat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Oran Giriniz: ");
                    oran = Convert.ToInt32(Console.ReadLine());

                    float tutar = indirim(fiyat, oran);
                    Console.WriteLine("Ödemeniz gereken tutar= " + tutar); Ozellik(urun, fiyat);
                    break;

                case "termos":
                    Console.WriteLine("Fiyat Giriniz: ");
                    fiyat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Oran Giriniz: ");
                    oran = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("Ödemeniz gereken tutar="+Zam(fiyat, oran));
                    break;



            }



            Console.ReadLine();
        }
    }
}
