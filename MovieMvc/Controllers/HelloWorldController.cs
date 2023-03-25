using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
