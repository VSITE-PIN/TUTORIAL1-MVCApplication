using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        
      
        public string Hello()
        {
            return "hello";
        }

        private static List<Dog> dogs = new List<Dog>()
        {
            new Dog { Name = "Rex", Age = 3}
        };

        public IActionResult Index()
        {
            return View(dogs);
        }

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
