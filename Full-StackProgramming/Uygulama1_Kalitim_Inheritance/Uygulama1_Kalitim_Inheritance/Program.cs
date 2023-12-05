using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1_Kalitim_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım : Miras bırakma
            //Ana classtan yavru classlara kalıtım bırakılarak ana classtaki özelliklerin yavru classlar tarafından kullanılabilmesi sağlanmış olur.

            Kamyon k1= new Kamyon();
            k1.Fiyat = 300000;
            k1.agirlik = 10;
            k1.tip = "csgh";

            k1.kveri();
            k1.Yazdir();

            Otomobil oto1= new Otomobil();
            oto1.Donanim = "tam";
            oto1.Fiyat = 800000;
            oto1.model = "sedan";
            oto1.kapisayisi = 5;

            oto1.otoverial();
            oto1.otoyazdir();

            Console.ReadLine();


        }
    }
}
