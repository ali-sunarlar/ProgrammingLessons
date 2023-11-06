using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tam saya: int (integer) 
            //ondalakla saya: float (10,2) double (10,2d), decimal (10,2m) //tek karakter : char bool : true , false 
            //deiskenler tamimlana kurallar : say1 ve ozel karakterlerle baslanaz. 
            //degisken adinda bosluk olmaz 
            //ayn1 isin birden fazla kullanamayaz 
            //dasaridan girilen tim veriler string alanir. 
            //difer defisken tirleri ile islem yap 
            //convert icin
            //int --> toInt32
            //char --> ToChar
            //float --> ToSingle
            //Decimal --> ToDecimal
            //double --> ToDouble

            string adsoyad = "Ali";
            string il = "Turkey";
            int yas = 35;
            float fiyat = 100.5f;
            double fiyat2 = 100.5d;
            decimal fiyat3 = 100.5m;
            char cinsiyet= 'E';



            //WriteLine alt alta yazar
            Console.WriteLine("Adi Soyadi : " + adsoyad);
            Console.WriteLine("Il : " + il);
            Console.WriteLine("yas : " + yas);
            Console.WriteLine("fiyat : " + fiyat);
            Console.WriteLine("fiyat2 : " + fiyat2);
            Console.WriteLine("fiyat3 : " + fiyat3);


            //Write yan yana yazar

            Console.Write("Adi Soyadi : "+ adsoyad);
            Console.Write("Il : " + il);
            Console.Write("yas : " + yas);
            Console.Write("fiyat : " + fiyat);
            Console.Write("fiyat2 : " + fiyat2);
            Console.Write("fiyat3 : " + fiyat3);


            

            //readline 
            Console.ReadLine();
        }
    }
}
