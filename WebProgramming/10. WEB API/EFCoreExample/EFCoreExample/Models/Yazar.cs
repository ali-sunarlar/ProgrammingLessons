using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreExample.Models
{
    public class Yazar
    {
        public int YazarID { get; set; }
        [Required]

        [MaxLength(100)]

        [Display(Name = "Yazar Ad")]

        public string YazarAd { get; set; }

        [Required]

        [MaxLength(100)]

        [Display(Name = "Yazar Soyad")]

        public string YazarSoyad { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
