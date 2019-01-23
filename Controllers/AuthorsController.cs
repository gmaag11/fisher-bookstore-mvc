using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Authors -- Fisher Bookstore Index");
        }
        public IActionResult Featured()
        {
            return Content("Fisher Bookstore Featured Authors");
        }
    }
}