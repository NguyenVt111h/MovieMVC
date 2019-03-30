using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class Movie2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello(string name, int numtimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numtimes;

            return View();
        }
    }
}