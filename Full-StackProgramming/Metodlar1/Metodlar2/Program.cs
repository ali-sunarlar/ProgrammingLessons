using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar2
{
    internal class Program
    {
       public static void Topla(int sayi1,int sayi2)
        {
            int toplam=sayi1+sayi2;
            Console.WriteLine("Toplam Sonucu= "+toplam);
        }
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Girin: ");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Topla(sayi1,sayi2);
            Console.ReadLine();



        }
    }
}
