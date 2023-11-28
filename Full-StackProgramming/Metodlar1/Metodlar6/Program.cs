using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar6
{
    internal class Program
    {

        public static void nothesaplama(int n1,int n2)
        {
            int ort = (n1 + n2) / 2;
            Console.WriteLine("Not Ortalaması= "+ort);
        }
        public static void nothesaplama(int n1, int n2,int sozlu)
        {
            int ort = (n1 + n2+sozlu) / 3;
            Console.WriteLine("Not Ortalaması= " + ort);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1- İlkokul");
            Console.WriteLine("2- Ortaokul");
            Console.WriteLine("3- Lise");
             int okul=Convert.ToInt32(Console.ReadLine());
            if(okul==1)
            {
                Console.WriteLine("1. Sınav Notu= ");
                int not1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sınav Notu= ");
                int not2 = Convert.ToInt32(Console.ReadLine());
                nothesaplama(not1,not2);


            }
            else if (okul == 2)
                {
                Console.WriteLine("1. Sınav Notu= ");
                int not1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sınav Notu= ");
                int not2 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Sözlü Notu= ");
                int sozlu = Convert.ToInt32(Console.ReadLine());
                nothesaplama(not1,not2,sozlu);
            }
            Console.ReadLine();

        }
    }
}
