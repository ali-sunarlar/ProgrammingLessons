using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baslangic ve bitis sayisini belirle
            //ve bu sayilarin arasindaki 3 ve 5 e bolunenlerin adedini bulun

            int adet = 0; 
            Console.WriteLine("başlangıc degerını gırınız"); 
            int baslangic = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("bitiş değerini giriniz"); 
            int bitis = Convert.ToInt32(Console.ReadLine()); 
            for (int i = baslangic; i <= bitis; i++) 
            { 
               if (i % 3 == 0 && i % 5 == 0) 
                { 
                    Console.WriteLine(i); adet++; 
                } 
            }
            Console.WriteLine("3 ve 5 e bölünen sayıların adedi" + adet); 
            Console.ReadLine();
        }
        
    }
}
