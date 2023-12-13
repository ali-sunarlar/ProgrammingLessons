using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Takımı fb olan yaşı 18 den büyük olanlar sisteme giriş yapabilsin
            //Yoksa Sisteme giriş yapamasın
            //sisteme giriş yapan kişinin cinsiyet ve meslek bilgilerini alıp onlara %10 indirim uygulasın (cinsiyet kadın ve meslek mühendis ise)
            go:
            Console.WriteLine("Takımınızı Giriniz: ");
            string takim=Console.ReadLine();
            Console.WriteLine("Yaşınızı Giriniz: ");
            int yas=Convert.ToInt32(Console.ReadLine());

            if (takim == "fb" && yas >= 18)
            {
                Console.WriteLine("FB sistemine Hoşgeldiniz"); ;
                int abonman = 500;

                Console.WriteLine("Cinsiyet Giiriniz: ");
                string cinsiyet = Console.ReadLine();
                Console.WriteLine("Meslek Giiriniz: ");
                string meslek = Console.ReadLine();

                if ((cinsiyet == "kadın" || cinsiyet == "KADIN") && (meslek == "mühendis" || meslek == "MÜHENDİS"))
                {
                    abonman -= abonman * 10 / 100;
                    Console.WriteLine("İndirimli Tutar: " + abonman);

                }
                else
                {
                    Console.WriteLine("Ödemeniz gereken tutar: " + abonman);
                }
            }
            else
            { 
                Console.WriteLine("Yanlış bilgiler girdiniz tekrar deneyin");
            }
            Console.WriteLine("Ana ekrana dönemk ister misiniz? ");
            string devam = Console.ReadLine();
            if(devam=="evet" || devam=="EVET")
            {
                Console.Clear();
                goto go;
            }
            else { Console.WriteLine("çıkış yapıyorsun güle güle"); }
            Console.ReadLine();













        }
    }
}
