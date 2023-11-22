using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karar Kontrol Mekanizmaları


            //Soru: Vize ve Final Notlarını alıp ortalamaları 50 ve üzerinde ise Geçtin Tebrikler , değilse Bütünlemeye Kaldın  uyarısı veren programı yazınız..


            Console.Write("Öğrencinin vize notunu girin: ");
            int vizeNotu = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Öğrencinin final notunu girin: ");
            int finalNotu = Convert.ToInt32(Console.ReadLine());

            double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6); //(vize+final)/2
           
            Console.WriteLine("Ortalama: " + ortalama); 
           
            if (ortalama >= 0 && ortalama <= 50) 
            {
                Console.WriteLine("Bütünlemeye Kaldınız");
            } 
            else if (ortalama > 50 && ortalama <= 100) 
            { 
                Console.WriteLine("Geçtiniz, Tebrikler");
            }
            else { Console.WriteLine("Geçersiz not ortalaması"); }
            Console.ReadKey();
        }
    }
}
