using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace master.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Budgetor App";
 
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your Budgetor page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
