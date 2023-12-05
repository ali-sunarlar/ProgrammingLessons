using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_Kalitim_Inheritance
{
    internal class Otomobil:MotorluTasitlar
    {
        public string model;
        public int kapisayisi;

        public void otoverial()
        {
            Console.WriteLine("*****OTOMOBİL VERİ ALMA EKRANI*****");
            Verial();
        }

        public void otoyazdir()
        {
            Console.WriteLine("OTOMOBİL ÖZELLİKLERİNİ YAZDIRMA****");
            Yazdir();
        }


    }
}
