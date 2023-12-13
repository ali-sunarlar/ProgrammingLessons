using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaza
{
    internal class YazlikAyakkabilar:Ayakkabilar
    {
        public override int indirim(int fiyat, string marka)
        {
            if (marka == "puma" || marka == "polo")
            {
                fiyat -= fiyat * 20 / 100;
                return fiyat;
            }
            else
            {
                fiyat -= fiyat * 30 / 100;
                return fiyat;
            }
        }
        public override int Zam(int fiyat, string marka)
        {
            if(marka=="bambi")
            {
                fiyat += fiyat * 20 / 100;
                return fiyat;
            }
            else
            {
                fiyat += fiyat * 10 / 100;
                return fiyat;
            }
        }
        public override void ozellik(string marka, string model)
        {
            base.ozellik(marka, model);
        }
    }
}
