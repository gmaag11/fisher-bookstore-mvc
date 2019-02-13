using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("history")]
        public IActionResult History()
        {
            return View();
        }

        [Route("location")]
        public IActionResult Location()
        {
            return View();
        }
    }
}