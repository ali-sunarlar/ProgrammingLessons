using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı Adı ve Şifre istesin doğru ise Hoşgeldiniz ,
            //yanlış ise  Giriş Hatalı yazan program
            //Kullanıcı Adı: Yasemin
            //Şifre:123

            Console.WriteLine(("Kullanıcı Adını Giriniz: "));
            string kad = Console.ReadLine();

            if (kad == "yasemin")
            {
                Console.WriteLine("Şifreyi Giriniz");
                string sifre = Console.ReadLine();

                if (sifre == "123")
                {
                    Console.WriteLine("Hoşgeldiniz");
                }
                else
                {
                    Console.WriteLine("Şifre Hatalı");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Hatalı");
            }
            Console.ReadLine();





        }
    }
}
