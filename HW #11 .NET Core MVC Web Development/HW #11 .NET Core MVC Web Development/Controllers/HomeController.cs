using System.Diagnostics;
using HW__11_.NET_Core_MVC_Web_Development.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW__11_.NET_Core_MVC_Web_Development.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TemperatureConverterModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ConvertedTemperature = 0;
                return View(model);
            }

            model.ConvertTemperature();
            return View(model);
        }

        public IActionResult Questions()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }


    }
}
