using EsperanzaAssgn1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EsperanzaAssgn1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.bodyMassIndex844 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(EsperanzaBMIAssgn1 model)
        {

            ViewBag.bodyMassIndex844 = model.CalculateBMI();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
