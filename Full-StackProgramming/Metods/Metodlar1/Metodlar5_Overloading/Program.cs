using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar5_Overloading
{
    internal class Program
    {
        public static void Topla()
        { }

        public static void Topla(int sayi)
        { }

        public static void Topla(int sayi1,int sayi2)
        { }
        static void Main(string[] args)
        {
            //method overloading: methodların aşırı yüklenmesi önlemek demek. aynı isimle method oluşturmak için kullanılır. fakat isimleri aynı olan methodların parametreleri farklı olmalıdır.
            //yani isimleri aynı parametreleri farkı methodlara overloading denir. 
            Topla();
            Topla(50);
            Topla(4, 10);
            Console.ReadLine();





        }
    }
}
