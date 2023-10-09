using Microsoft.AspNetCore.Mvc;
using WebFormUyg.Views.Ogrenci;

namespace WebFormUyg.Controllers
{
    public class OgrenciController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //Post ile gelmemişse Kaydet metodu'u çalışmayacaktır.
        public string Kaydet()
        {
            string txt;
            string ad = HttpContext.Request.Query["OgrAd"];
            string soyad = HttpContext.Request.Query["OgrSoyad"];
            string numara = HttpContext.Request.Query["OgrNo"];
            txt= ad+" "+soyad+" "+numara;
            return txt;
        }

        /*[HttpGet]
        public string Kaydet2()
        {
            string txt;
            string ad = HttpContext.Request.Query["ad"];
            string soyad = HttpContext.Request.Query["soyad"];
            string numara = HttpContext.Request.Query["numara"];
            txt = ad + " " + soyad + " " + numara;
            return txt;
        }*/

        [HttpPost] //Post ile gelmemişse Kaydet metodu'u çalışmayacaktır.
        public string Kaydet3(Ogrenci ogr)
        {
            string txt;
            txt = ogr.OgrAd + " " + ogr.OgrSoyad + " " + ogr.OgrNo + " " + ogr.OgrYas;
            return txt;
        }
    }
}
