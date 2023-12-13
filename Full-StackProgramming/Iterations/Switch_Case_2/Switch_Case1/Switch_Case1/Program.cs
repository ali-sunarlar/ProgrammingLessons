using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case durumlara göre işlem yapar.
            //if else den farkı şart kısmında ve veya kullanılamıyor olması.

            Console.WriteLine("1- İSTANBUL");
            Console.WriteLine("2- ANKARA");
            Console.WriteLine("3- İZMİR");
            Console.WriteLine("4- EDİRNE");

            Console.Write("Lütfen İl Kodu Giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            switch(sayi)
            {
                case 1:
                    Console.WriteLine("İlçeler: Kartal, Maltepe");
                    break;
                case 2:
                    Console.WriteLine("İlçeler: Mamak, Çankaya");
                    break;
                case 3:
                    Console.WriteLine("İlçeler: Foça, Konak");
                    break;
                case 4:
                    Console.WriteLine("İlçeler: Havsa, Meriç");
                    break;
                default: 
                    Console.WriteLine("Üzgünüm başka bir il bilgisi bulunamadı");
                    break;
            }
            Console.ReadLine();







        }
    }
}
