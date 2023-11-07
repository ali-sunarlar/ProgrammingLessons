using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //klavyeden girilen 10 sayidan ciftlerin kareleri toplami, teklerin ise küplerin toplamı bulunuz

            int sayi = 0;
            int kup = 0;
            int kare = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". Sayiyi Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    kare += sayi * sayi;
                }
                else
                {
                    kup += sayi * sayi *sayi;
                }
            }
            Console.WriteLine("cift sayilarin karesi toplami:" + kare);
            Console.WriteLine("tek Sayıların kupu toplami: " + kup);

            Console.ReadLine();


        }
    }
}
