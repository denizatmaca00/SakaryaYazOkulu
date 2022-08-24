using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SakaryaYazOkulu.Data;
using SakaryaYazOkulu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SakaryaYazOkulu.Controllers
{
    public class AdminController : Controller
    {
       private readonly ApplicationDbContext _db;
        Context c = new Context();
       
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult CRUD()
        {
            return View();
        }

        public ActionResult CreateAnimal(Animal a)
        {
           
            var an = c.Animals.ToList();

            return View(an);
        }
        [HttpGet]
        public ActionResult RealCreate()
        {
            return View();

        }

        [HttpPost]
        public ActionResult RealCreate(Animal a)
        {
            var ani = new Animal()
            {
                AnimalId = a.AnimalId,
                Name = a.Name,
                Old = a.Old,
                IsBoy = a.IsBoy,
                IsOwned = a.IsOwned,
            };
            c.Animals.Add(a);
            c.SaveChanges();
            return RedirectToAction("CreateAnimal");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Admin loginAdmin)
        {

            if (AdminUser(loginAdmin.UserName, loginAdmin.Password))
            {
                var claims = new List<Claim>
            {
            new Claim(ClaimTypes.Name, loginAdmin.UserName)

            };
                var userIdentity = new ClaimsIdentity(claims, "login");

                await _db.SaveChangesAsync();
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        private bool AdminUser(string userName, string password)
        {
            if (userName == "211210032@gmail.com" || password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
