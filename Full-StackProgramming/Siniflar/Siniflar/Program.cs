using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TC NO, OgrenciNo, AdSoyad, Not, Burs değişkenlerimiz
            //TC NO 11 haneli, OgrenciNO 4 haneli, Not Girişi için 0-100 arası rakam girilebilsin.
            //BursVer metodu 80-100 arasında ise +500 burs (not , burs parametreleri kullan)
            //Hediye Metodu TotalBurs >750 macbook kazandın, değilse Asus (geriye değer döndürmeyen metod kullanılacak)

            Console.WriteLine("Seçiminizi Yapınız: ");
            Console.WriteLine("1- İlkokul");
            Console.WriteLine("2- Lise");
            Console.WriteLine("3- Üniversite");

            int secim=Convert.ToInt32(Console.ReadLine());

            if (secim==1)
            {
                Ogrenciler ogrenciler = new Ogrenciler();
                Console.WriteLine("Tc No Giriniz: ");
                ogrenciler.TcNo = Console.ReadLine();               
                Console.WriteLine("Öğrenci No Giriniz: ");
                ogrenciler.OgrenciNo = Console.ReadLine();
                Console.WriteLine("Öğrenci Adı Soyadı Giriniz: ");
                ogrenciler.AdSoyad = Console.ReadLine();
                Console.WriteLine("Öğrenci Notu Giriniz:");
                ogrenciler.Not=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Öğrenci Bursu Giriniz: ");
                ogrenciler.burs = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Tc No= "+ogrenciler.TcNo);
                Console.WriteLine("Öğrenci= " + ogrenciler.OgrenciNo);
                Console.WriteLine("Adı Soyadı= " + ogrenciler.AdSoyad);
                Console.WriteLine("Öğrenci Notu= " + ogrenciler.Not);
                Console.WriteLine("Öğrenci Bursu= " + ogrenciler.burs);

                int totalburs = ogrenciler.BursVer(ogrenciler.Not, ogrenciler.burs);
                Console.WriteLine("Burs = " + totalburs);
                ogrenciler.Hediye(totalburs);
            }
            else if (secim == 2)
            {
                Ogrenciler ogrenciler = new Ogrenciler();
                Console.WriteLine("Tc No Giriniz: ");
                ogrenciler.TcNo = Console.ReadLine();
                Console.WriteLine("Öğrenci No Giriniz: ");
                ogrenciler.OgrenciNo = Console.ReadLine();
                Console.WriteLine("Öğrenci Adı Soyadı Giriniz: ");
                ogrenciler.AdSoyad = Console.ReadLine();
                Console.WriteLine("Öğrenci Notu Giriniz:");
                ogrenciler.Not = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Öğrenci Bursu Giriniz: ");
                ogrenciler.burs = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Tc No= " + ogrenciler.TcNo);
                Console.WriteLine("Öğrenci= " + ogrenciler.OgrenciNo);
                Console.WriteLine("Adı Soyadı= " + ogrenciler.AdSoyad);
                Console.WriteLine("Öğrenci Notu= " + ogrenciler.Not);
                Console.WriteLine("Öğrenci Bursu= " + ogrenciler.burs);

                int TotalBurs = ogrenciler.BursVer(ogrenciler.Not, ogrenciler.burs);
                Console.WriteLine("Burs = " + TotalBurs);
                ogrenciler.Hediye(TotalBurs);
            }
            Console.ReadLine();

        }
    }
}
