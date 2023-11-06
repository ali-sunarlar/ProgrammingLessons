using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ad soyad,cinsiyet meslek, Kazanc

            string adsoyad = "ali";
            char cinsiyet= 'E';
            string meslek = "IT";
            double Kazanc = 30000d;
            Console.WriteLine("Ad Soyad " + adsoyad);
            Console.WriteLine("Cinsiyet "+cinsiyet);
            Console.WriteLine("Meslek "+meslek);
            Console.WriteLine("Kazanc "+Kazanc);
            Console.WriteLine(Console.ReadLine());

        }
    }
}
