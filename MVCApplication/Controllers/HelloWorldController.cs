using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<Dog> dogs = new List<Dog>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            Dog dog = new Dog();
            return View(dog);
        }
        public string Hello()
        {
            return "Hello";
        }
        public IActionResult CreateDog(Dog dogViewModel)
        { 
            dogs.Add(dogViewModel);
            return RedirectToAction("Index");
        }
    }
}
