using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //disaridan girilen 20 sayinin ciftlerin adedi teklerin de carpimi buldurun

            int sayi = 0; 
            int carpim = 1; 
            int cAdet = 0; 
            for (int i = 1; i <= 20; i++) 
            { 
            Console.Write(i + ". Sayıyı Giriniz: "); 
            sayi = Convert.ToInt32(Console.ReadLine()); 
            if (sayi % 2 == 0) 
            { 
            cAdet += 1; 
            }
            else 
            { 
            carpim *= sayi; 
            } 
            }
            Console.WriteLine("Çift Sayı Adedi:" + cAdet); 
            Console.WriteLine("Tek Sayıların Çarpımı: " + carpim);

            Console.ReadLine();


        }
    }
}
