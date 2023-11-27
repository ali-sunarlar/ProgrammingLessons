using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar1
{
    internal class Program
    {
       private static void veriler()
        {
            Console.WriteLine("Okul Yöneticisi: Neriman Atalı");
            Console.WriteLine("Öğretmen: Yasemin Eyşi");
            Console.WriteLine("Şehir:İstanbul");
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }
        
        static void Main(string[] args)
        {
            veriler();
            Console.WriteLine();
            veriler();
            veriler();
            Console.ReadLine();

        }
    }
}
