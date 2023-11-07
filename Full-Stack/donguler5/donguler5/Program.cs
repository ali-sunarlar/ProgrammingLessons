using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //disaridan girilen cift sayilarin toplami

            int toplam = 0;

            for (int i = 0; i <=10; i++) 
            {
                Console.WriteLine(i + ". Sayiyi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
            }
            Console.ReadLine();


        }
    }
}
