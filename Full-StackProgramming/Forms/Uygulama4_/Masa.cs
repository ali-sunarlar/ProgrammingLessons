using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_
{
    internal class Masa:Mobilya
    {
        public string malzeme;

        public override void ozellikyaz()
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("Renk: "+renk);
            Console.WriteLine("Malzeme: "+malzeme);
        }
    }
}
