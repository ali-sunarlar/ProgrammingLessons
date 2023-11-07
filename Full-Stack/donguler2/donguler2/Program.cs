using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 ile 30 arasindaki sayilarin toplami
            int toplam = 0;
            for (int i = 5;i<=30;i++)
            {
                Console.WriteLine("sayilar: "+i);
                toplam = toplam + i;
                //farkli yontemle yazilis sekli
                //toplam += i;

            }
            Console.WriteLine("Sayilarin Toplami: " + toplam);

            Console.ReadLine();
        }
    }
}
