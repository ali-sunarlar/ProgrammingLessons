using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelUygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir komisyoncu sattigi mallardan fiyati 50 tl ye kadar olanlaardan %3, 
            //daha fazla olanlardan %2 komisyon almaktadar. 
            //Klavyeden girilen 5 malin komisyonlaran bulup ekrana yazdran ve en sonunda TOPLAM KOMISYONU yazan program. 

            //float komisyon = 0; 
            //float toplamkomisyon = 0; 
            //for (int i = 1; i <= 5; i++) 
            //{ 
            //    Console.Write($"{i}. fiyatı giriniz:"); 
            //    float fiyat = Convert.ToInt32(Console.ReadLine()); 
            //    if (fiyat <= 50) { komisyon += (fiyat * 2) / 100; 
            //        toplamkomisyon += komisyon; Console.WriteLine($"{i}. ödemeden alacağınız komisyon: {komisyon}TL"); 
            //    } 
            //    else 
            //    { 
            //        komisyon += (fiyat * 3) / 100; Console.WriteLine($"{i}. ödemeden alacağınız komisyon: {komisyon}TL"); 
            //        toplamkomisyon += komisyon; 
            //    } 
            //    Console.WriteLine("Toplam komisyon:" + toplamkomisyon); }
            //Console.ReadLine();

            //Alis fiyati girilen malin kullanicinin girdigi yuzdelik karla satis fiyatini bulan program

            //double alisfiyati,satisfiyati,yuzde

            Console.Write("Alis Fiyati Giriniz: ");
            int alisfiyati = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uygulanacak Yuzdeyi Giriniz: ");
            int yuzde = Convert.ToInt32(Console.ReadLine());

            double satisfiyati = 0;

            satisfiyati = alisfiyati+(alisfiyati * yuzde / 100);

            Console.WriteLine(satisfiyati);

            Console.ReadKey();

        }
    }
}
