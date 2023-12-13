using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar4
{
    internal class Program
    {

        static int fiyat; // her yerden erişilebilen değişken tipi tanımlama
        
        public static void AnaMenu(int secim)
        {
            if (secim==1)
            {
                Console.WriteLine("m- mercimek çorbası");
                Console.WriteLine("t- tarhana çorbası");
                char corba = Convert.ToChar(Console.ReadLine());

                if(corba=='m' || corba=='M')
                {
                    fiyat += 100;
                    int sontutar = fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar= "+sontutar);
                }
                else
                {
                    fiyat += 150;
                    int sontutar = fis(fiyat);
                    Console.WriteLine("Ödemeniz gereken tutar= " + sontutar);
                }

            }
        }
        
        public static int fis(int fiyat)
        {
            Console.WriteLine("İçecek ister misiniz?");
            char cevap=Convert.ToChar(Console.ReadLine());
            if(cevap=='e' || cevap=='E')
            {
                fiyat += 20;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        static void Main(string[] args)
        {
            //Restaurant Programı
            //1- Çorba 
            //2-Sebze Yemekleri
            //Mercimek Çorbası mı? (m), Tarhana Çorbası mı?? (t)
            //Fiyat hesapla
            //Fis metodunda içecek sorsun
            //e ise +20 tl 
            //değilse
            //fiyat

            Console.WriteLine("1- Çorba");
            Console.WriteLine("2- Sebze Yemekleri");
            int secim=Convert.ToInt32(Console.ReadLine());
            AnaMenu(secim);
            Console.ReadLine();





        }
    }
}
