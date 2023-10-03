using IlkUygMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IlkUygMVC1.Controllers
{
    public class OgrenciController : Controller
    {
        Ogrenci ogr = new Ogrenci();
        public string Index(int id) 
        {
            ogr.OgrNo = id;
            return "Gelen Id = " + id;
        }

        public IActionResult Bilgi()
        {
            return View();

        }
        //public string Index()
        //{
        //    return "Merhaba Dünya!";
        //}
    }
}
