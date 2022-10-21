using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     return "Esta es mi acción predeterminada...";
        // }
        // --******************parte de agregar vista
        public IActionResult Index()
        {
            return View();
        }

        //+++++++++++++++++++++++++++++++++ paso 1
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "Este es el método de acción de bienvenida...";
        // }
        //+++++++++++++++++++++++++++++++++ paso 2
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}