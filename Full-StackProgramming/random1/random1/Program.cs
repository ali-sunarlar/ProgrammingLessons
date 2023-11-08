using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random : rastgele bir sayi atama
            //random bir class

            Random rnd = new Random();
            int sayi = rnd.Next(10, 100);
            Console.WriteLine(sayi);



            //1 ile 10 arasinda

            Random rnd1 = new Random();
            int sayi1 = rnd1.Next(1, 10);
            Console.WriteLine(sayi1);
            Console.Read();


            //random ornek1




        }
    }
}
