using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //araba classı ac 
            //arabano  ----->6 haneli olucak(private)
            //arabaadi
            //motorgücü  ------->mgucu 1000 ile 2000 arasında olmalıdır(private)
            //vites durumu----------->otomatik veya manuel olmalıdır(private)
            //fiyat -------------->300000  1000000 olmalı(private) 
            //otv ---------------->10 ile 60 arasında olamlı (private)

            //return lu method fiyat üzerinde otv hesaplat 
            //retunlu vergi  otvhesaplat methdundan gelen fiyata %5 kdv uygula 
            //voidli method yaz içerisine
            //kasko istermisiniz diye sor eger kullanıcı evet derse 
            //fiyatı 15 bin olarak yazdır
            //hayır ise sgk ödemesi 10 bin olarak odemesi gerektigini yazdır.
            //------------------------------------------------------------------------
            //Main
            //1-Otombil
            //2-Servis araçları
            Console.WriteLine("Seçiminizi yapınız \n1- Otomobil\n2- Servis Araçları");
            int secim=Convert.ToInt32(Console.ReadLine());
            if(secim==1)
            {
                Araba arb1= new Araba();
                Console.WriteLine("Araç Nosu Giriniz: ");
                arb1.ArabaNo=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Araç Adı Giriniz: ");
                arb1.Arabaadi = Console.ReadLine();

                Console.WriteLine("Motor Gücü Giriniz: ");
                arb1.ArabaNo =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vites Türü Giriniz: ");
                arb1.VitesDr = Console.ReadLine();

                Console.WriteLine("Fiyatı Giriniz: ");
                arb1.Fiyat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("OTV Oranı Giriniz: ");
                arb1.OTV = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Araç No= " + arb1.ArabaNo);
                Console.WriteLine("Araç Adı= " + arb1.Arabaadi);
                Console.WriteLine("Motor Gücü= " + arb1.Motrgucu);
                Console.WriteLine("Vites Türü= " + arb1.VitesDr);
                Console.WriteLine("Araba Fiyatı: " + arb1.Fiyat);

                int otvlifiyat = arb1.OtvHesapla(arb1.Fiyat, arb1.OTV);
                Console.WriteLine("Vergili Fiyat= "+arb1.Vergi(otvlifiyat));
                arb1.Kasko();

                Console.ReadLine();
            }





        }
    }
}
