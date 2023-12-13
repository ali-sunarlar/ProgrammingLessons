using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kanepe knp = new Kanepe();
            Masa masa= new Masa();
            knp.renk = "Sarı";
            knp.kumas = "Deri";
            masa.renk = "Siyah";
            masa.malzeme = "Ahşap";

            knp.ozellikyaz();
            Console.WriteLine();
            masa.ozellikyaz();

            Console.ReadLine();


        }
    }
}
