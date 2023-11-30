using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           insan insan1 = new insan(); // insan1 adında bir nesne ürettik
            insan1.adsoyad = "Yasemin Eyşi";
            insan1.sehir = "İstanbul";
            insan1.adres = "Kartal";
            

            Console.WriteLine("Ad Soyad: "+insan1.adsoyad);
            Console.WriteLine(" Şehir: " +insan1.sehir);



            Console.ReadLine();



        }
    }
}
