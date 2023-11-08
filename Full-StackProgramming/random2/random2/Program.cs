using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace random2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random skor =new Random();
            int fb=skor.Next(0,5);
            int gs=skor.Next(0,5);

            if(fb==gs)
            {
                Console.WriteLine("Berabere Kaldininiz");
                Console.WriteLine("FB: " + fb + " - " + "GS: " + gs);
            }
            else if (fb<gs)
        {
                Console.WriteLine("FB Kazandi");
                Console.WriteLine("FB: " + fb + " - " + "GS: " + gs);

            }
            else
            {

                Console.WriteLine("GS Kazandi");
                Console.WriteLine("FB: " + fb + " - " + "GS: " + gs);
            }

             

            Console.ReadKey();
        }
    }
}
