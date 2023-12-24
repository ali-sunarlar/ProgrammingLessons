using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EFCoreExample.Models
{
    public class Kitap
    {
        [Key] // Bu öznitelik tanimlanmasa da KitapID ‘de ID eki yer aldığından //primary key olurdu
        
        public int KitapID { get; set; }

        [Required]

        [MaxLength(100)]

        [Display(Name = "Kitap Adı ")]

        public string KitapAdi { get; set; }

        public int YazarID { get; set; }

        [Display(Name = "Kitap Sayfa Sayisi")]
        [Range(10, 5000)] 
        public int KitapSayfasi { get; set; }

    public Yazar Yazar { get; set; }
    }
}
