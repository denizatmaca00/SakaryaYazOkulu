using Microsoft.AspNetCore.Mvc;
using SakaryaYazOkulu.Models;
//using SakaryaYazOkulu.Models.Entity;

namespace SakaryaYazOkulu.Controllers
{
    public class AnimalController : Controller
    {
        Context c = new Context();

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CRUD()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RealCreate()
        {
            return View();
        }
        [HttpPost]
       public ActionResult RealCreate(Animal animal)
        {
            c.Animals.Add(animal);
            c.SaveChanges();
            return View();
        }
    }
}
