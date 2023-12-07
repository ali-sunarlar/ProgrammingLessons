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
        public string tel;
        public string adres;
        int alimadet;
        int toplamalim;
        public int fiyat;

        public int AlimAdet
        {
            get { return alimadet; }
            set
            {
                if (value > 1 && value < 100)
                { alimadet = value; }
                else { Console.WriteLine("Geçersiz adet!"); }
            }
        }
        public int ToplamAlim
        {
            get { return toplamalim; }
            set
            {
                if (value > 100 && value < 500)
                { toplamalim = value; }
                else
                { Console.WriteLine("Geçersiz adet!"); }
            }
        }

        public void Verial()
        {
            Console.WriteLine("Müşteri no giriniz: ");
            mno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad soyad giriniz: ");
            adsoyad = Console.ReadLine();
            Console.WriteLine("Telefon no giriniz: ");
            tel = Console.ReadLine();
            Console.WriteLine("Adres giriniz: ");
            adres = Console.ReadLine();
            Console.WriteLine("Alım adeti giriniz: ");
            alimadet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam alım giriniz: ");
            toplamalim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
        }

        //Tutar methodu
        // topadet,fiyat   Tutar
        //topadet 100-200 ise fiyata %5 indirim
        //değilse 200-500 ise fiyata %25 indirim

        public int Tutar()
        {
            if (ToplamAlim > 100 && ToplamAlim < 200)
            {
                return (fiyat * ToplamAlim) - (((fiyat * ToplamAlim) * 5) / 100);
            }
            else if (ToplamAlim > 200 && ToplamAlim < 500)
            {
                return (fiyat * ToplamAlim) - (((fiyat * ToplamAlim) * 25) / 100);
            }
            else
            {
                return fiyat * ToplamAlim;
            }
        }

        public void Yazdir()
        {
            Console.WriteLine("Müşteri : " + mno);
            Console.WriteLine("Ad soyad : " + adsoyad);
            Console.WriteLine("Telefon no : " + tel);
            Console.WriteLine("Adres : " + adres);
            Console.WriteLine("Alım adeti : " + alimadet);
            Console.WriteLine("Toplam alım Adet : " + ToplamAlim);
            Console.WriteLine("Ödemeniz Gereken Tutar: " + Tutar());


        }
    }
    
}
