using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //araba adında class
            //renk, model, vites, fiyat alanları tanımlansın
            //verileri ana sayfada girdikten sonra çalıştıralım..

            Araba araba1 = new Araba();

            araba1.ARenk = "Siyah";
            araba1.AModel = "Audi-TT";
            araba1.AVites = "Manuel";
            araba1.AFiyat = 1600500;
            araba1.Plaka = "2";

            Console.WriteLine("Arabanın Rengi: " + araba1.ARenk);
            Console.WriteLine("Arabanın Modeli: " + araba1.AModel); 
            Console.WriteLine("Arabanın Vitesi: " + araba1.AVites);
            Console.WriteLine("Arabanın Fiyatı: " + araba1.AFiyat);
            Console.WriteLine("Arabanın Plakası: " + araba1.Plaka);
            Console.ReadLine();



        }
    }
}
