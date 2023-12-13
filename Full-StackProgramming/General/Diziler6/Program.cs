using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random atanan 7 sayının son rakamı 0 olanların toplamını bulan program
            //(100-300 arası random sayı)

            int[] sayilar = new int[7];
            int toplam = 0;

            Random rastgele = new Random();

            for (int i = 0; i < 7; i++)
            {
                int sayi = rastgele.Next(100, 301);
                sayilar[i] = sayi;
                
                if (sayilar[i] % 10 == 0)
                {
                    toplam += sayilar[i];                 

                }

                Console.WriteLine((i + 1) + ".Sayı: " + sayilar[i]);

            }
            Console.WriteLine("Son rakamı 0 olanların toplamı= " + toplam);
            Console.ReadLine();
        }
    }
}
