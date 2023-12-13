using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Yazlık \n2-Kışlık Ayakkabılar");
            Console.WriteLine();
            int secim=Convert.ToInt32(Console.ReadLine());

            if(secim==1)
            {
                YazlikAyakkabilar y1=new YazlikAyakkabilar();
                y1.Tum();
                Console.WriteLine("Son Tutar= " + y1.indirim(y1.Fiyat, y1.marka));
                Console.WriteLine("Son Tutar= " + y1.Zam(y1.Fiyat, y1.marka));
            }
            else
            {
                KislikAyakkabilar k1=new KislikAyakkabilar();
                k1.Tum();
                Console.WriteLine("Son Tutar= "+k1.indirim(k1.Fiyat,k1.marka));
                Console.WriteLine("Son Tutar= " + k1.Zam(k1.Fiyat, k1.marka));
                
            }
            Console.ReadLine();
        }
    }
}
