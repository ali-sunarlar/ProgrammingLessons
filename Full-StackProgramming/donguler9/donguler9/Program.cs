using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet = 0; 
            Console.Write("Sayi: giriniz:"); 
            int sayi = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 75; i <= 300; i++) 
            { 
                if (i % sayi == 0) 
                { 
                    adet++; 
                } 
            }
            Console.WriteLine("Tam Bölünen Sayı Adedi:" + adet); 
            Console.ReadKey();
        }
    }
}
