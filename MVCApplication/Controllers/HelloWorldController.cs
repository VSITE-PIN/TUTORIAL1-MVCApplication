using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public String Hello()
        {
            return "Hello";
        }
    }
}
