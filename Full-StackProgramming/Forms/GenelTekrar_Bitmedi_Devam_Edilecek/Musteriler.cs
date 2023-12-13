using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    internal class Musteriler
    {
        public int mno; 
        public string adsoyad; 
        public int tel; 
        public string adres; 
        int alimadet; 
        int toplamalim; 
        public int fiyat;

        public int AlimAdet
        { get { return alimadet; }
            set { if (value < 100 && value > 1)
                { alimadet = value; } 
                else { Console.WriteLine("Geçersiz adet!"); } } }
        public int ToplamAlim
        { get { return toplamalim; } 
            set { if (value < 500 && value > 100) 
                { toplamalim = value; }
                else
                { Console.WriteLine("Geçersiz adet!"); } } }

        public void Verial()
        { Console.WriteLine("Müşteri no giriniz: ");
            mno = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Ad soyad giriniz: ");
            adsoyad = Console.ReadLine(); 
            Console.WriteLine("Telefon no giriniz: ");
            tel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adres giriniz: ");
            adres = Console.ReadLine();
            Console.WriteLine("Alım adeti giriniz: ");
            alimadet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam alım giriniz: ");
            toplamalim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine()); }

        //Tutar methodu
        // topadet,fiyat   Tutar
        //topadet 100-200 ise fiyata %5 indirim
        //değilse 200-500 ise fiyata %25 indirim

        public void Tutar(int topadet,int fiyat)
        { 
            if (topadet< 200 && topadet > 100) 
            { 
                fiyat -= (fiyat * 5) / 100;
            } 
            else if (toplamalim < 200 && toplamalim > 500)
            { 
                fiyat -= (fiyat * 25) / 100;
            }
        }
    }
}
