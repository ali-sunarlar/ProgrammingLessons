using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Ogrenciler
    {
        string tcno;
        string ogrencino;
        public string AdSoyad; //bu alanda kontrol yapmaya gerek olmadığı için public yaptık
        int not;
        public int burs; //bu alanda kontrol yapmaya gerek olmadığı için public yaptık

        public string TcNo
        {
            get { return tcno; }
            set
            {
                if (value.Length == 11)
                {
                    tcno = value;
                }
                else
                {
                    Console.WriteLine("Tc Noyu 11 hane olarak giriniz");
                    Console.WriteLine("Tc No Giriniz"); // tc no yu yeniden gir
                    TcNo = Console.ReadLine();


                }
            }
        }
        public string OgrenciNo
        {
            get { return ogrencino; }

            set
            {
                if (value.Length == 4)
                {
                    ogrencino = value;
                }
                else
                {
                    Console.WriteLine("Öğrenci No 4 haneli olacak şekilde giriniz");
                    Console.WriteLine("Öğrenci No Giriniz");
                    OgrenciNo = Console.ReadLine();

                }
            }
        }
        public int Not
        {
            get { return not; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    not = value;
                }
                else
                {
                    Console.WriteLine("Öğrenci noyunu 0-100 arasında giriniz"); Console.WriteLine("Öğrenci notunu giriniz");
                    Not = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int BursVer(int not, int burs)
        {
            if (not >= 80 && not <= 100)
            {
                burs += 500;
                return burs;
            }
            else
            {
                return burs;
            }
        }


        public void Hediye(int TotalBurs)
        {
            if (TotalBurs > 750)
            {
                Console.WriteLine("MacBook kazandınız.");
            }
            else
            {
                Console.WriteLine("Asus kazandınız.");
            }
        }



    }
}
