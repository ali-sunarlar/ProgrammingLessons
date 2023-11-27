using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar4
{
    internal class Program
    {
       private static void Hesapla()
        {
            Console.Write("Kısa Kenarı Girin: ");
            int kk=Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenarı Girin: ");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;
            Console.WriteLine("Alan= " + alan);
        }

        static void Main(string[] args)
        {
            //Hesapla adında method
            //Kısa ve Uzun kenar girilecek ve Alan hesaplanacak

            //Bu method 2 kez çalışsın..

            Hesapla();
            Hesapla();
            Console.ReadLine();









        }
    }
}
