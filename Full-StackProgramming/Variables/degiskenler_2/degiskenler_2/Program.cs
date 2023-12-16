using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //anneadi,babaadi,uyesayisi,memleket,toplamkazanc

            string anneadi = "Ayse";
            string babaadi = "Ahmet";
            int uyesayisi = 4;
            string memleket = "Istanbul";
            string meslek = "Ogretmen";
            double kazanc = 30000d;

            Console.WriteLine(anneadi);
            Console.WriteLine(babaadi);
            Console.WriteLine(uyesayisi);   
            Console.WriteLine(memleket);
            Console.WriteLine(meslek);
            Console.WriteLine(kazanc);
            Console.WriteLine(Console.ReadLine());
        }
    }
}
