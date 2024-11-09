using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using System.Linq.Expressions;
using System.Xml;

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
        private static List<Dog> dogs = new List<Dog>()
        {
            new Dog {Name = "Rex", Age = 3 },
            new Dog {Name = "Spike", Age = 1 },
            new Dog {Name = "Buddy", Age = 5 }
        };
        public IActionResult Create()
        {
            Dog dog = new Dog();
            return View(dog);
        }
        public IActionResult CreateDog(Dog dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction("Index");
        }
    }
}