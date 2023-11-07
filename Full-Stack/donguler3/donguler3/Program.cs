using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 ile 30 arasindaki sayilarin ortalamasini bulun

            int toplam = 0; 
            int ortalama = 0; 
            int adet = 0; 
            for (int i = 10; i < 30; i++) { 
                 
                adet++;
                toplam += i;
                ortalama = (toplam / adet);

            }
             
            Console.WriteLine("Ortalama: " + ortalama);
            Console.WriteLine("Toplam: " + toplam);
            //Console.ReadLine();


            /*int baslangic = 10; 
            int bitis = 30; 
            int toplam = 0; 
            int sayac = 0; 
            for (int i = baslangic; i <= bitis; i++) 
            { 
                toplam += i; sayac++; 
            }
            double ortalama = (double)toplam / sayac; 
            Console.WriteLine(ortalama);*/

            /*int toplam = 0; 
            int ortalama = 0;
            for (int i = 10; i <= 30; i++)
            {
                Console.WriteLine("Sayılar: " + i);
                toplam += i; ortalama = toplam / 2;
                Console.WriteLine("Sayılar Toplamı: " + toplam);
                Console.WriteLine("Sayıların Ortalaması: " + ortalama);
            }*/

                Console.ReadLine();

        }
        
    }
}
