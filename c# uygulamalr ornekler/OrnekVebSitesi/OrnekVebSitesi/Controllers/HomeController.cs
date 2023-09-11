using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using OrnekVebSitesi.Busniess;
using OrnekVebSitesi.Models;
using OrnekVebSitesi.Models.EfCore.Entities;
using OrnekVebSitesi.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekVebSitesi.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
          

            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Launge dil)
        {
            
            return View();
        }
       public class Launge
        {
            public string dil { get; set; }
        }

        public IActionResult BizeUlaşın()
        {
            return View();
        }

        public IActionResult GirişYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GirişYap(KullaniciGirişiViewModel kullanici)
        {

            var data = Kullaniciİşlemleri.Giriş(kullanici);
            data.Wait();
            var data1 = data.Result;

            if (data1.Item1)
            {

                return View("Index");
            }
            else
            {
                return View();
            }
            return View();
        }

        public IActionResult KayıtOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayıtOl(KullanıcıKaytViewModel kullanıcı)
        {
            if (ModelState.IsValid)
            {
                Kullanıcı kullanıcı1 = kullanıcı;
                var kontrol = Kullaniciİşlemleri.Kayıt(kullanıcı1);
                kontrol.Wait();
                var kontrolsonuc = kontrol.Result;
                if (kontrolsonuc)
                {
                    return View("GirişYap");
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }

        }

        public IActionResult Hakkımızda()
        {
            return View();
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
