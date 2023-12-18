using System.ComponentModel.DataAnnotations;

namespace ModelDogrulama_ModelValidation.Models
{
    public class Ogrenci
    {
        [Required(ErrorMessage = "Isim Alani Zorunludur.")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Cinsiyet Secilmelidir.")]
        public string Cinsiyet { get; set; }

        [Range(1, 6, ErrorMessage = "Secilen Sinif 1-6 Arasinda Olmalidir.")]
        public int Sinif { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Geçerli bir mail adresi giriniz")] 
        public string Email { get; set; }

    }
}
