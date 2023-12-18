using Microsoft.AspNetCore.Mvc;
using ModelDogrulama_ModelValidation.Models;

namespace ModelDogrulama_ModelValidation.Controllers
{
    public class OgrenciController : Controller
    {
        static List<Ogrenci> ogrenciler=new List<Ogrenci>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            return View();
        }

        public IActionResult Liste()
        {
            return View(ogrenciler);
        }
        public IActionResult Kaydet( Ogrenci ogr)
        {
            if (ModelState.IsValid)
            {
                ogrenciler.Add(ogr); //Statice listeye ogrenci ekleniyor
                return View(ogr);
            }
            else
            {
                ViewBag.Hata = "Ogrenci Ekleme Basarisiz.";
                return View("Hata");
            }
            
        }
    }
}
