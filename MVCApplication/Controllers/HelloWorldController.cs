using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {

        /*public IActionResult Index()
        {
            Dog dog = new Dog();
            dog.Name = "Rex";
            dog.Age = 2;
            return View(dog);
        }
        public string Hello()
        {
            return "Hello";
        }
        public IActionResult Create()
        {
            return View();
        }*/
        //lista koja simulira bazu i u nju dodajemo nove pse
        private static List<Dog> dogs = new List<Dog>();

        public IActionResult Index()
        {
            //vraća Index view koji nam služi za prikaz svih pasa u listi
            return View(dogs);
        }

        public IActionResult Create()
        {
            //pozivamo Create View i proslijeđujemo prazan objekt
            Dog dog = new Dog();
            return View(dog);
        }

        public IActionResult CreateDog(Dog dogViewModel)
        {
            //dodajemo psa u listu
            dogs.Add(dogViewModel);
            //preusmjeravamo na akciju Index kako bi prikazali sve pse
            return RedirectToAction("Index");
        }

    }

}
