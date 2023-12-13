using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    internal class KurumsalMusteriler:Musteriler
    {
        int faaliyetyili;
        int ticarioran;
        int yillikciro;

        public int FaaliyetYili
        {
            get { return faaliyetyili; }
            set
            {
                if (value >= 5 && value <= 20)
                {
                    faaliyetyili = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı");
                }
            }
        }
        public int TicariOran
        {
            get { return ticarioran; }
            set
            {
                if (value >= 5 && value <= 50)
                {
                    ticarioran = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıdı..");
                }
            }
        }

        public int Indirim(int yil, int oran, int fiyat)
        {
            if (yil > 5 && yil < 10)
            {
                int tutar = fiyat * oran;
                tutar -= tutar * 5 / 100;
                return tutar;
            }
            else if (yil > 10 && yil < 20)
            {
                int tutar = fiyat * oran;
                tutar -= tutar * 10 / 100;
                return tutar;
            }

            else
            {
                int tutar = fiyat * oran;
                return tutar;
            }

        }
        public void Vergi(int indirimlitutar)
        { 
            indirimlitutar -= (indirimlitutar * 2) / 100;
            Console.WriteLine("İndirimli Tutar :" + indirimlitutar); 
        }


        public int YillikCiro
        {
            get { return yillikciro; }
            set
            {
                if (value < 95000)
                {
                    yillikciro = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı!");
                }
            }

        }
        public void KM()
        {
            Verial();
            Console.WriteLine("Faaliyet Yılı Giriniz: ");
            faaliyetyili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ticari Oran Giriniz: ");
            ticarioran = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yıllık Ciro Giriniz: ");
            yillikciro = Convert.ToInt32(Console.ReadLine());

            Yazdir();
            Console.WriteLine("Faaliyet Yılı: " + faaliyetyili);
            Console.WriteLine("Ticari Oran:" + ticarioran);
            Console.WriteLine("Yıllık Ciro:" + yillikciro);
            int indirim = Indirim(FaaliyetYili, TicariOran, YillikCiro);
            Vergi(indirim);

        }
    }
}

    