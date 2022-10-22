// ---------> generacion por defecto
// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

// namespace MvcCadeteria.Controllers
// {
//     [Route("[controller]")]
//     public class HelloWorldController : Controller
//     {
//         private readonly ILogger<HelloWorldController> _logger;

//         public HelloWorldController(ILogger<HelloWorldController> logger)
//         {
//             _logger = logger;
//         }

//         public IActionResult Index()
//         {
//             return View();
//         }

//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View("Error!");
//         }
//     }
// }
// --------->fin  generacion por defecto
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcCadeteria.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/

        public string Index1()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome1()
        {
            return "This is the Welcome action method...";
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome2(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        public string Welcome3(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}