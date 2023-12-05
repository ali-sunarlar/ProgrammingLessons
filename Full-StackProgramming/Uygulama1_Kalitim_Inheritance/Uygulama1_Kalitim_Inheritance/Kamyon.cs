using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_Kalitim_Inheritance
{
    internal class Kamyon:MotorluTasitlar
    {
        public int agirlik;
        public string tip;

        public void kveri()
        {
            Console.WriteLine("****KAMYON VERİ ALMA EKRANI****");
            Verial();
            Console.WriteLine("Ağırlık Giriniz: ");
            agirlik=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tip Giriniz: ");
            tip = Console.ReadLine();
        }

        public void kyazdir()
        {
            Console.WriteLine("****KAMYON ÖZELLİKLERİNİ YAZDIRMA***");
            Yazdir();
            Console.WriteLine("Ağırlık : "+agirlik);
            Console.WriteLine("Tip : "+tip);



        }




    }
}
