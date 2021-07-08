using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // IActionResult
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
