using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_Kalitim_Inheritance
{
    internal class MotorluTasitlar //Ana class, base class, super class, temel class 
    {
        public int tasitno;
        public int yakitlt;
        string vitesdr;
        int fiyat;
        string donanim;

        public string VDURUM
        {
            get { return vitesdr; }
            set
            {
                if(value=="manuel" || value=="otomatik")
                {
                    vitesdr = value;
                }
                else
                {
                    Console.WriteLine("Yanlış Giriş Yaptınız");
                }
            }
        }
        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value > 100000 && value< 500000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı");
                }
            }
        }
        public string Donanim
        {
            get { return donanim; }
            set
            {
                if(value=="boş" || value=="tam")
                {
                    donanim = value;
                }
                else
                {
                    Console.WriteLine("hatalı giriş yapıldı");
                }
            }
        }



        public void Verial()
        {
            Console.WriteLine("Taşıt No Giriniz: ");
            tasitno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yakıt Litre Giriniz: ");
            yakitlt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vites Durumu Giriniz: ");
            vitesdr = Console.ReadLine();
            Console.WriteLine("Fiyat Giriniz:");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donanım Durumu Giriniz: ");
            donanim = Console.ReadLine();
        }

            public void Yazdir()
            {
                Console.WriteLine("Taşıt No: "+tasitno);
                Console.WriteLine("Yakıt Litre: " + yakitlt);
                Console.WriteLine("Vites Durumu: " + vitesdr);
                Console.WriteLine("Fiyat: " + fiyat);
                Console.WriteLine("Donanım Durumu: " + donanim);
        }



        }
    }

