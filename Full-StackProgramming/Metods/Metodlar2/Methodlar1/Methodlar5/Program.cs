using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar5
{
    internal class Program
    {
       
            private static void veri()
        { 
            Console.Write("1. Sayıyı giriniz: "); 
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: "); 
            int sayi2 = Convert.ToInt32(Console.ReadLine()); 
            if (sayi1 > sayi2)
            { 
                Console.WriteLine("Büyük Sayı: " + sayi1);
            } 
            else 
            {
                Console.WriteLine("Büyük Sayı: " + sayi2);
            } 
            
        }
        static void Main(string[] args) 
        {
            //BuyukSayi method adı          
            //Kullanıcının girdiği iki sayıdan büyük olanı ekrana yazdırsın
            veri();
            Console.ReadLine();
        }

        
            




        }
    }




