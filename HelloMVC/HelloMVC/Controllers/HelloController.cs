using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]//specifies get requests only
        public IActionResult Index()
        {

            //string html = "<form method='post' action='/Hello/Display'>" +
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" + 
                "<form>";

            //return Content(html, "text/html");
            return Redirect("/Hello/Goodbye");
        }

        //Hello form request
        [Route("/Hello")]
        [HttpPost]//allows handling of just post method
        public IActionResult Display(string name = "World")
        {
            //if (string.IsNullOrEmpty(name))
            //{
            //    name = "World";
            //}
            return Content($"<h1>Hello {name}</h1>", "text/html");
        }

        //handle request to hello/name to demonstrate url segment request handling
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content($"<h1>Hello {name}</h1>", "text/html");
        }


        // /Hello/Goodbye
        // alter the route to be /Hello/Aloha
        // [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
