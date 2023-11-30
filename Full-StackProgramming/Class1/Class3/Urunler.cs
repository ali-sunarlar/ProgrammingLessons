using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Urunler
    {
        public int UrunNo;
        public string UrunAdi;
        public int Fiyat;

        public int Fis(int Fiyat)
        { 
            if(Fiyat >=10000 )
            {
                Fiyat -= Fiyat * 5 / 100;
                return Fiyat;
            }
            else
            {
                Fiyat-=Fiyat * 3 / 100;
                return Fiyat;
            }


        }



    }
}
