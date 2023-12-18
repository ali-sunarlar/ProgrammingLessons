using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBagViewDataTempData.Models;

namespace ViewBagViewDataTempData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            /*ViewBag.msj = "ViewBag";
            ViewData["msj2"] = "ViewData Verisi";
            TempData["msj3"] = "TempData Verisi";
            return RedirectToAction("Goster");*/
        }
        public IActionResult Goster()
        {
            return View();
        }
        public IActionResult Kaydet(Ogrenci ogr)
        {
            //Veritabani kaydetme vs diğer islemler de yapilabilir
            return View(ogr);
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}