using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizideki negatif sayıları pozitif sayılara çeviren programı yazınız
            // (eksi değerler girilmesi istensin)

            Console.Write("Dizinin Eleman Sayısını giriniz: "); 
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[elemanSayisi]; 
            
            for (int i = 0; i < sayiDizisi.Length; i++)
            { 
                Console.Write("Negatif Sayi Giriniz: "); 
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayiDizisi[i] * -1); 
            }
            Console.ReadLine();



        }
    }
}
