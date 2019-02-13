using System;
using Microsoft.AspNetCore.Mvc;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Controllers
{
    [Route("authors")]
    public class AuthorsController : Controller
    {

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("featured")]
        public IActionResult Featured()
        {
            // we would normally get this from a database
            var featuredAuthor = new Author()
            {
                AuthorId = 1,
                Name = "J.K. Rowling" //or pick your favorite
            };
            return View(featuredAuthor);
        }
    }
}