using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //program rastgele sayi tutsun(1,20)
            //kullanici sayiyi tahmin etmeye çalışsın
            //kacinci kerede tahminin tutuldugunu yazdirsin
            //girilen sayi rastgele sayi buyuk veya kucukse sayiyi buyutme ve kucultme icin yonlendirsin


            //try catch kontrol eder hata ile karsilasildiginda catch blogu calistirilir


            Random rnd = new Random();
            int rastgele = rnd.Next(1, 20);
            int sayac = 0;

            go:
            try
            {
            
                Console.WriteLine("1-20 arasi rastgele sayi giriniz");

                int tahmin = Convert.ToInt32(Console.ReadLine());
                sayac++;

                if (tahmin > rastgele)
                {
                    Console.WriteLine("Sayiyi Kucultunuz");
                    goto go; //tutmadigi durumda go'ya dondurur.
                }
                else if (tahmin < rastgele)
                {
                    Console.WriteLine("Sayiyi Buyutunuz");
                    goto go;
                }
                else
                {
                    Console.WriteLine("Tebrikler");
                    Console.WriteLine("Tahmin edilen sayi: " + tahmin + " - " + "Rastgele Sayi: " + rastgele);
                    Console.WriteLine(sayac + ". kerede sayiyi tutturdun");

                }
            }
            catch (Exception) //Exception calisma durumundaki hatalarin kontrolu icin kullanilir
            {
                Console.WriteLine("Lutfen Sayisal deger giriniz");
                goto go;
            }
            Console.ReadKey();


            //Random random = new Random(); 
            //int rastgeleSayi = random.Next(1, 20); 
            //int tahmin1 = 0; 
            //int deneme = 0; 
            //Console.WriteLine("1 ile 20 arasında ki sayıyı tahmin etmeye çalışın !"); 
            //for (; tahmin1 != rastgeleSayi; deneme++) 
            //{ 
            //    Console.Write("Tahmininizi girin: "); 
            //    tahmin1 = Convert.ToInt32(Console.ReadLine()); 
            //    if (tahmin1 < rastgeleSayi) 
            //    { 
            //        Console.WriteLine("Daha büyük bir sayı girin"); 
            //    } 
            //    else if 
            //        (tahmin1 > rastgeleSayi) 
            //    { 
            //        Console.WriteLine("Daha küçük bir sayı girin"); 
            //    } 
            //}
            //Console.WriteLine("Tebrikler! {0}. denemede doğru tahminde bulundun :) ", deneme);
            //Console.Read();
        }

    }
}
