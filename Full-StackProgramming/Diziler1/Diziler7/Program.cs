using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen 5 sayının karelerini , sayıların toplamını ve sayıların kareleri toplamını bulan program..

            int[] sayilar=new int[5];
            int kare = 0;
            int ktop = 0;
            int top = 0;


            for(int i = 0;i<5;i++) 
            {
                Console.Write(i + 1 + ". Sayıyı Girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

                kare = sayilar[i]*sayilar[i];
                ktop += kare;
                top += sayilar[i];

                Console.WriteLine(i+1+". Sayının Karesi: "+kare);


            }

            Console.WriteLine("Kareler Toplamı= "+ktop);
            Console.WriteLine("Sayıların Toplamı= " + top);
            Console.ReadLine();




        }
    }
}
