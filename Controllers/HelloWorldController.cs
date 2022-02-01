using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Messages"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");// interpolated string 
        }
    }
}
