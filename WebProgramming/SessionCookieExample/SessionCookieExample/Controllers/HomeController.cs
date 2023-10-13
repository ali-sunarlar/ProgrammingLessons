using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SessionCookieExample.Models;
using System.Diagnostics;

namespace SessionCookieExample.Controllers
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
            foreach (var item in users) { 
            if(item.UserName==usr.UserName && item.UserPass == usr.UserPass)
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
            //if icerisine girmezse Index view'i görüntülenecek
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}