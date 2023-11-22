using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 elemanlı dizi için kullanıcı değer girsin ve ortalamalarını bulsun

            double toplam = 0; 
            double ortalama = 0; 
            Console.Write("Dizinin Eleman Sayısını giriniz:");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine()); 
            double[] sayiDizisi = new double[elemanSayisi];
            for (int i = 0; i < sayiDizisi.Length; i++)
            { 
                Console.Write("Sayı Giriniz: ");
                sayiDizisi[i] = Convert.ToDouble(Console.ReadLine());
                 toplam += sayiDizisi[i]; 
            }
            Console.Write("Girilen Sayıların Ortalaması: " + (ortalama = (toplam / elemanSayisi)));
            Console.ReadLine();





        }
    }
}
