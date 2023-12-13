using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string ad = Console.ReadLine();

            Console.WriteLine("Mezuniyet Notunuzu Giriniz: ");
            float not = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Tecrübe Yılı Giriniz: ");
            int tecrube = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cinsiyeti Giriniz: E/K");
            char cinsiyet = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ödeme Tutarını Giriniz: ");
            int tutar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KDV Tutarını Giriniz: ");
            int kdv = Convert.ToInt32(Console.ReadLine());

            decimal sonuc = tutar + tutar * kdv / 100;

            Console.WriteLine("İsim:" + ad);
            Console.WriteLine("Mezuniyet Notu:" + not);
            Console.WriteLine("Tecrübe(Yıl): " + tecrube);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Tutar: " + tutar);
            Console.WriteLine("KDV: " + kdv);
            Console.WriteLine("Toplam Tutar: " + sonuc);
            Console.ReadLine();
        }
    }
}
