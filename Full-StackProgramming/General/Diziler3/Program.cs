using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı dizide kullanıcıdan girilen dizi elemanlarından çiftlerin toplamı
            //teklerin toplamını ayrı ayrı gösteren programı yazınız..

            double cifttoplam = 0, tektoplam = 0;

            for(int i=1;i<=10;i++)
            {
                Console.Write("{0} . Sayısı Girin: ", i  );
                double sayi=Convert.ToDouble(Console.ReadLine());

                if(sayi%2==0 )
                {
                    cifttoplam += sayi;
                }
                else
                {
                    tektoplam += sayi;
                }
                
            }
            Console.WriteLine("Çiftlerin Toplamı={0}\nTeklerin Toplamı={1}", cifttoplam, tektoplam);
            Console.ReadLine();

        }
    }
}
