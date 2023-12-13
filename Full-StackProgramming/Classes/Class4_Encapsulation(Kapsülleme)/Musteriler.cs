using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class Musteriler
    {
        private int mno;
        private string madsoyad;
        float bakiye;

        //bir class içerisinde bulunan bazı alanlara başka class içerisinden her zaman ulaşmak gerekmez. 
        //property (Nitelik) : oluşturulan private alanlara kontrollü bir şekilde erişim sağlamak için tanımlanır.
        public string MAdSoyad
        { get; set; }
        
        public float Bakiye
        {
            get { return bakiye; }
            set
            {
                if (value > 1000 && value < 2000)
                {
                    bakiye = value;

                }
                else
                {
                    Console.WriteLine("Bakiyeniz düşük");
                }
            }
        }
            public int Mno
        {
            get { return mno; }
            set
            {
                if(value>5 && value<50)
                {
                    mno = value;
                }
                else
                { Console.WriteLine("Girdiğiniz Müşteri Numarası 5 ile 50 arasında olmalı"); }
            }
        }
        }


    }

