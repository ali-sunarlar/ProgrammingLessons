using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while déngiisii: 
            //belirlenen komut blodgunun verilen sart sajlandiga siirece dénmesini saglayan déngii modelidir. For déngiisiinden farki sadece sarta kontrol etmesidir. //Mlavyeden 15 girilene kadar sayilari toplayip ekrana yazdiran program. 

            /*int top = 0; 
            int sayi = 0; 
            while (sayi != 15)
            {
                Console.WriteLine("Say1 Giriniz: "); 
                sayi = Convert.ToInt32(Console.ReadLine());

                if(sayi == 15)
                {
                    break;
                }

                top += sayi;
            }
            Console.WriteLine("Toplam Sonuc:"+top+"]");
            Console.WriteLine("Islem Bitti");
            Console.ReadLine();
            }*/


            //Klavyeden negatif sayi girilene kadar girilen diger sayilari toplayan programi yaziniz.

            /*int top = 0;
            int sayi = 0; 
            while (true)
            {
                Console.WriteLine("Sayi Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    break;
                }

                top += sayi;
            }
            Console.WriteLine("Toplam Sonuc:" + top + "]");
            Console.WriteLine("Islem Bitti");
            Console.ReadLine();

            */

            //2. yol
            /*int top = 0;
            int sayi = 1;
            while (sayi >= 0)
            {
                Console.WriteLine("Sayi Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    break;
                }
                top += sayi;
            }
            Console.WriteLine("Toplam Sonuc:" + top + "]");
            Console.WriteLine("Islem Bitti");
            Console.ReadLine();

            */


            //250 ile 1000 arasında rastgele çift sayinin ekrana yazdirilmasi en son toplam sonucunu
            //ekranda gösteren programi yaziniz.

            /*Random random = new Random(); 
            int toplam = 0; 
            int sayiAdedi = 0; 
            while (sayiAdedi < 10) 
            { 
                int sayi = random.Next(250, 1001); 
                if (sayi % 2 == 0) { Console.WriteLine(sayi); 
                    toplam += sayi; 
                    sayiAdedi++; } }
            Console.WriteLine("Toplam Sayı: " + toplam); 
            Console.ReadKey();
            */

            //foreach dongusu:

            // koleksiyonlar Gzerinde kullamilir.

            // Koleksiyon bir dizi veya bir liste olabilr. dizi veya listedeki her eleman igin calistaralar.

            //Dizileler (Arrays) farkli degerler icin ayri degiskenler atamak yerine birden cok degeri ayni degisken turunde depolamak icin kullamilar 


            /*int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.WriteLine(sayilar[1]);
           


            string[] isimler = { "ali", "veli", "ayse", "amine" };
            Console.WriteLine(isimler[2]);
            Console.ReadKey(); 
            */


            /*string[] isimler = { "Ali", "Test", "Test2" };

            foreach (string s in isimler)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            */


            /*string[] isimler = { "Ali", "Test", "Test2" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*/



            //notlar dizisinde 0-100 arasinda degerler girilsin. Girilen not 50'den buyuk ise basarili degilse basarisiz yazsin

            int[] notlar = { 45, 80, 30, 58, 78, 15, 56 };

            foreach (int i in notlar)
            {
                if (i >= 50)
                {
                    Console.WriteLine(i+" Basarilidir");
                }
                else { Console.WriteLine(i+": Basarisizdir "); }}
            Console.ReadLine();
            }
        
       





        }
    }

