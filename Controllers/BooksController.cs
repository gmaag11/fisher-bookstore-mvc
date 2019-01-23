using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("Books -- Fisher Bookstore Index");
        }
        public IActionResult New()
        {
            return Content("New Books at the Fisher Bookstore");
        }
        
        [ActionName("best-sellers")]
        public IActionResult BestSellers()
        {
            return Content("Fisher Bookstore Best Sellers");
        }
    }
}