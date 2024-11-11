using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View(dogs);
        }
        public string Hello()
        {
            return "Hello";
        }
        private static List<Dog> dogs = new List<Dog>();
        public IActionResult Create()
        {
            Dog dog = new Dog();
            return View(dog);
        }
        public IActionResult CreateDog(Dog dogViewModel) {
            dogs.Add(dogViewModel);
            return RedirectToAction("Index");
    }
}
