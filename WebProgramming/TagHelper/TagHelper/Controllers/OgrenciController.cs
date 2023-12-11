using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TagHelper.Controllers
{
    public class OgrenciController : Controller
    {

        public IActionResult OgrEkle() 
        {
            ViewBag.SehirKod = new List<SelectListItem>
            {
                new SelectListItem {Value="06",Text="Ankara"},
                new SelectListItem {Value="34",Text="Istanbul"},
                new SelectListItem {Value="42",Text="Konya"},
                new SelectListItem {Value="32",Text="Isparta"}

            };
            
            return View(); 
        
        }

        [HttpPost]
        public IActionResult OgrKaydet(OgrenciController ogr)
        {
            //Kaydet vb Islemler
            ViewBag.KayitDurum = "Kayit Islemi Basarili";
            return View();
        }


    }
}
