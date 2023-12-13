using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilikOrnek1
{
    internal class Topla:Islemler
    {
        public override void Islem()
        {
            int sayi1, sayi2,sayi3;

            Console.WriteLine("1. Sayı: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayı: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayı: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
