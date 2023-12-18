using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ1.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }

        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }

        public int KitapSayfasi { get; set; }
    }
}
