using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //disaridan girilen 10 sayinin toplami



            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+". Sayiyi giriniz :");
                int sayi=Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                
            }

            Console.WriteLine("********************************************************");
            Console.WriteLine("Sayilarin Toplami:   " + toplam);
            Console.ReadLine();




        }
    }
}
