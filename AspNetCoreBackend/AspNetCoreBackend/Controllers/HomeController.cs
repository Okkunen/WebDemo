using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreBackend.Models;

namespace AspNetCoreBackend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Kortit()
        {
            List<Kortti> kortit = new List<Kortti>()
            {
                new Kortti()
                {
                    Sana = "Olut",
                    Kaannos = "Beer"
                },
                new Kortti()
                {
                    Sana = "Koti",
                    Kaannos = "Home"
                },
                new Kortti()
                {
                    Sana = "Kuppi",
                    Kaannos = "Cup"
                }
            };

            return View(kortit);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
