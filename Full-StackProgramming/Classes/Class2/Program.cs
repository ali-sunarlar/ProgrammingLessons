using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ogrenciler class oluşturulacak
            //ogrno, adsoyad,ortalama,adres
            //Burs adında metod oluştur (mühendislik böl tübitak 5000 tl burs veriyor)
            //veriler kullanıcı tarafından girilecek

            Ogrenciler ogrenciler1 = new Ogrenciler();
            
            Console.WriteLine("Öğrenci Numarasını Giriniz: ");
            ogrenciler1.ogrno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad Soyad Giriniz: ");
            ogrenciler1.adsoyad=Console.ReadLine();
            Console.WriteLine("Adres Giriniz: ");
            ogrenciler1.adres=Console.ReadLine();
            Console.WriteLine("Ortalama Notunu Giriniz: ");
            ogrenciler1.ortalama=Convert.ToInt32(Console.ReadLine()) ;

            Console.Clear();

            Console.WriteLine("------Öğrenci Bilgileri--------");
            Console.WriteLine("Öğrenci Numarası: "+ogrenciler1.ogrno);
            Console.WriteLine("Ad Soyad: " + ogrenciler1.adsoyad);
            Console.WriteLine("Adres: " + ogrenciler1.adres);
            Console.WriteLine("Ortalama: " + ogrenciler1.ortalama);

            ogrenciler1.Burs();

            Console.ReadLine();







        }
    }
}
