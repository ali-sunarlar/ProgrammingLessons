using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen 5 isim arasından aradığımız ismin kaçıncı sırada olduğunu bulan program..
            int sayac = 0;
            
            string[] isimler = new string[5];
            {
                for (int i = 0; i < isimler.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". isim giriniz: ");
                    isimler[i] = Console.ReadLine();
                }
                Console.WriteLine("Aradığınız ismi giriniz: ");
                string metin = Console.ReadLine();

                for (int i = 0; i < isimler.Length; i++)
                {
                    if (metin == isimler[i])
                    {
                        Console.WriteLine("Aradığınız isim " + (i + 1) + ". Sıradadır");
                    }
                    else
                    {
                        sayac++;
                    }
                }
                if (isimler.Length == sayac)
                {
                    Console.WriteLine("Aradığınız isim bulunamadı");
                }
                Console.ReadLine();






            }
        }
    }
}
