using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaza
{
   abstract internal class Ayakkabilar
    {
        private int fiyat;
        public string marka;
        private string model;

        public int Fiyat
        { get { return fiyat; }
            set
            { 
            if(value>1000 && value<2000)
                {
                    fiyat = value;
                }
            else
                {
                    Console.WriteLine("Fiyat limiti dışında değer girdiniz!");
                }
            } 
        }
        public string Model
        {
            get { return model; }
            set
            {
                if(value=="spor" || value=="klasik")
                {
                    model = value;

                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız!");
                }
            }
        }
        public virtual int Zam(int fiyat,string marka)
        {
            if(marka=="nike" || marka=="adidas")
            {
                fiyat += fiyat * 20 / 100;
                return fiyat;
            }
            else
            {
                fiyat += fiyat * 5 / 100;
                return fiyat;
            }
        }
        public virtual int indirim(int fiyat,string marka)
        {
            if(marka=="puma" || marka=="polo")
            {
                fiyat-=fiyat*20 / 100;
                return fiyat;
            }
            else
            {
                fiyat -= fiyat * 5 / 100;
                return fiyat;
            }
        }
        public virtual void ozellik(string marka,string model)
        {
            if(marka=="nike" || model=="spor")
            {
                Console.WriteLine("2 garantili temizleme spreyi bedava");

            }
            else
            { Console.WriteLine("1 yıl garantili ve 50 tl indirim çeki ");
            }
        }
        public void Tum()
        {
            Console.WriteLine("Fiyat Giriniz= ");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka Giriniz= ");
            marka = Console.ReadLine();
            Console.WriteLine("Model Giriniz= ");
            model = Console.ReadLine();

            Console.WriteLine("Fiyat= " + fiyat);
            Console.WriteLine("Marka= " + marka);
            Console.WriteLine("Model= " + model);

        }


    }
}
