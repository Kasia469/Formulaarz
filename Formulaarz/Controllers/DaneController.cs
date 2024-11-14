using Formulaarz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Formulaarz.Controllers
{
    public class DaneController : Controller
    {
        

        public IActionResult Index()
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

        [HttpGet]
        public IActionResult Form()
        { return View(); }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else { return View(); }
        }

        [HttpPost]
        public IActionResult Wynik(Dane dane)
        { return View(dane); }


    }
}
