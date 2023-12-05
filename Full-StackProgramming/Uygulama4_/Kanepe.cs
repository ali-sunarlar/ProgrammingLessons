using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4_
{
    internal class Kanepe:Mobilya
    {
        public string kumas;
        public override void ozellikyaz()
        {
            Console.WriteLine("Kanepenin Ozellikleri");
            Console.WriteLine("Renk : "+renk);
            Console.WriteLine("Kumaş: "+kumas);


        }

    }
}
