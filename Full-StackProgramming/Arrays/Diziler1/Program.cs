using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diziler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 elemanli dizi icin kullanicidan deger girsin ve ortalamalarini bulsun



            /*double toplam = 0, ortalama = 0; 
            Console.Write("Dizinin Eleman Sayısını giriniz:"); 
            int elemanSayisi = Convert.ToInt32(Console.ReadLine()); 
            int[] sayiDizisi = new int[elemanSayisi]; 
            for (int i = 0; i < sayiDizisi.Length; i++) 
            { 
                Console.Write("Sayı Giriniz: "); 
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine()); 
                toplam += sayiDizisi[i]; 
            }
            Console.Write("Girilen Sayıların Ortalaması: " + (ortalama = (toplam / elemanSayisi))); 
            Thread.Sleep(3000);
            */

            //10 elemanli bir dizi kullanicidan girilen dizi elemanlarindan cift'lerin toplami
            //tek'lerin toplami

            /*double ciftoplam = 0;
            double tektoplam = 0;


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}. Sayiyi Giriniz: ",i+1);
                double sayi=Convert.ToDouble(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    ciftoplam += sayi;

                }
                else
                {
                    tektoplam += sayi;
                }
                
            }
            Console.WriteLine("Ciftlerin Toplami={0}\nTeklerin Toplami={1}", ciftoplam, tektoplam);
            Console.ReadKey();
            */


            //dizideki negatif sayilari pozitif sayilara ceviren program yaziniz

            /*Console.Write("Dizinin Eleman Sayısını giriniz: ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[elemanSayisi];
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Negatif Sayi Giriniz: ");
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayiDizisi[i] * -1);
               
            }
            Console.ReadLine();*/


            //girilen 5 isim arasindan aradigimizin ismin kacinci sirada oldugunu bulan program

            //string[] isimler = new string[5];
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ". Ismi Giriniz: ");
            //    isimler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Aradiginiz ismi Giriniz: ");
            //string metin = Console.ReadLine();

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin == isimler[i])
            //    {

            //        Console.WriteLine(metin[i]);
            //    }
            //}


            //random atanan 7 sayinin son rakami 0 olanlarinin toplamini bulan program
            //100 ile 300 arasinda


            //int toplam = 0; 
            //Random random = new Random(); 
            //int[] sayilar = new int[7]; 
            //Console.WriteLine("Oluşturulan Sayılar:"); 
            //for (int i = 0; i < 7; i++) 
            //{ 
            //    sayilar[i] = random.Next(100, 301); 
            //    Console.Write(sayilar[i] + " "); 
            //    if (sayilar[i] % 10 == 0) 
            //    { 
            //        toplam += sayilar[i]; 
            //    } 
            //}
            //Console.WriteLine("\n\nSon rakamı 0 olan sayıların toplamı: " + toplam); Console.ReadLine();


            //Girilen 5 sayinin kareleri toplami ayrica karelerin toplamini bulan

            int[] sayilar= new int[5];


            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1+". Sayiyi Giriniz:    ");
                sayilar[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();




        }
    }
}
