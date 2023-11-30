using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1= new Urunler();
            Console.WriteLine("Ürün No Giriniz: ");
            urun1.UrunNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürün Adı Giriniz: ");
            urun1.UrunAdi=Console.ReadLine();
            Console.WriteLine("Ürün Fiyatını Girin: ");
            urun1.Fiyat=Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ürün No: " + urun1.UrunNo);
            Console.WriteLine("Ürün Adı: " + urun1.UrunAdi);
            Console.WriteLine("Ürün Fiyat: " + urun1.Fis(urun1.Fiyat));

            Console.ReadLine();


        }
    }
}
