using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionCookieExample.Models;
using SessionStateCookie_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SessionStateCookie_1.Controllers
{
    public class HomeController : Controller
    {
        //static user listesi olusturuldu
        static List<User> users = new List<User>()
        {
            new User() { UserName = "ali",UserPass="123",UserColor="Green"},
            new User() { UserName = "amine",UserPass="456",UserColor="Pink"},
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User usr)
        {
            foreach (var item in users)
            {
                if (item.UserName == usr.UserName && item.UserPass == usr.UserPass)
                {
                    HttpContext.Session.SetString("SessionUser", item.UserName);
                    var cookop = new CookieOptions
                    {
                        Expires = DateTime.Now.AddSeconds(50)
                    };
                    HttpContext.Response.Cookies.Append("UserColor", item.UserColor, cookop);
                    //Yukaridaki durum uygunsa Giris isimli bir view cagiracak
                    return View("Giris");
                }
            }
            ViewBag.msj = "Hatali Giris Gerceklestirdiniz!!";
            //if icerisine girmezse Index view'i görüntülenecek
            return View("Index");
        }

        public IActionResult Icerik()
        {
            if (HttpContext.Session.GetString("SessionUser") is null)
            {
                return View("Index");
            }

            return View();
        }

        public IActionResult Cikis()
        {
            HttpContext.Session.Clear();  //Veriler clear ediliyor

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
