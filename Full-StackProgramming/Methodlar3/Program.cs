using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar3
{
    internal class Program
    {
       
        private static int kupu(int sayi)
        {
            int kupdeger = sayi * sayi * sayi;
            return kupdeger;
        }
        
        
        
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Girin: ");
            int s=Convert.ToInt32(Console.ReadLine());

            Console.Write("Sonuç: " + kupu(s));
            Console.ReadLine();

        }
    }
}
