using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Musteriler Class - mno,adsoyad,tel,adres,alimadet(private),toplamalim(private),fiyat
            //BireyselMusteriler Class - kredipuani, faiztutar
            //KurumsalMusteriler Class - faaliyetyili,ticarioran,yillikciro (hepsi private olacak)

            Console.WriteLine("1- Bireysel Müşteri");
            Console.WriteLine("2- Kurumsal Müşteri");
            Console.Write("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                BireyselMusteriler m1 = new BireyselMusteriler();
                m1.BM();
            }
            else
            {
                KurumsalMusteriler km1 = new KurumsalMusteriler();
                km1.KM();
            }
            Console.ReadLine();


        }
    }
}
