using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("About -- Fisher Bookstore Index");
        }
        public IActionResult History()
        {
            return Content("About the History of the Fisher Bookstore");
        }
        public IActionResult Location()
        {
            return Content("About the Location of the Fisher Bookstore");
        }
    }
}