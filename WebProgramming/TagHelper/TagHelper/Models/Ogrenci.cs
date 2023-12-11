using System.ComponentModel.DataAnnotations;

namespace TagHelper.Models
{
    public class Ogrenci
    {
        [Display(Name="Öğrenci Adı")]
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrNo { get; set; }
        public string Sehirler { get; set; }
        public string DogumTarihi { get; set; }




    }
}
