using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreExample.Controllers
{
    public class YazarController : Controller
    {
        private KitaplikContext k = new KitaplikContext();
        public IActionResult Index()
        {


            //var m =k.Yazarlar.ToList();

            //linq ile
            var m = from yazar in k.Yazarlar 
                    where yazar.YazarID == 1 
                    select yazar;

            return View(m);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Yazar y)
        {

            if (ModelState.IsValid)
            {
                k.Add(y);
                k.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                ViewBag.msj = "Yazar Eklenemedi !!";
                return View(y);
            }
            
        }
    }
}
