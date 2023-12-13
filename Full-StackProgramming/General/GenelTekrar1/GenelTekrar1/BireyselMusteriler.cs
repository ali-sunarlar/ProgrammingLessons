using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    internal class BireyselMusteriler : Musteriler
    {
        public int kredipuani;
        public int faiztutar;

        public void BM()

        {
           
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Verial();
            Console.WriteLine("Kredi Puanı Giriniz: ");
            kredipuani = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("faiz Tutarı Giriniz: ");
            faiztutar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Yazdir();
            Console.WriteLine("Kredi Puanı: " + kredipuani);
            Console.WriteLine("Faiz Tutarı:" + faiztutar);
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Kampanya(Tutar());
        }



        public void Kampanya(int Tutar)
        {
           if (Tutar>5000)
            {
                Console.WriteLine("Tebrikler bir hafta kaplıca kazandınız");
            }
            else
            {
                Console.WriteLine("2 Günlük Sapanca tatili ...");
            }
           //Zam methodu - parametreleri fiyat ve kredipuani
           //kredipauni>100 ise %5 zam
           //değilse fiyat aynı
        }
        public int Zam(int fiyat, int kredipuani)
        { 
            if (kredipuani > 100) 
            {
                fiyat += (fiyat * 5) / 100;
                return fiyat; 
            }
            else 
            { return fiyat; } }
    }
    

  }

    

