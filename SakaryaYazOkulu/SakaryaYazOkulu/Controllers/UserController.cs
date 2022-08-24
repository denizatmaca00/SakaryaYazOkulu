using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Threading.Tasks;
using SakaryaYazOkulu.Data;
using SakaryaYazOkulu.Models;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;


namespace SakaryaYazOkulu.Controllers
{
    public class UserController : Controller
    {

          private readonly ApplicationDbContext _db;

          public UserController(ApplicationDbContext db)
          {
              _db = db;
          }

         public async Task<IActionResult> Index()
         {
             return View( await _db.UserClaims.ToListAsync());
         }
         [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User loginModel)
        {
            
            if (LoginUser(loginModel.UserName, loginModel.Password))
            {
                var claims = new List<Claim>
            {
            new Claim(ClaimTypes.Name, loginModel.UserName)

            };
                var userIdentity = new ClaimsIdentity(claims, "login");

                await _db.SaveChangesAsync();
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
                }
                    return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }

        private bool LoginUser(string userName, string password)
        {
            if(userName =="211210180@gmail.com"  || password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IActionResult SignIn()
        {
            return View();
        }

    }
}
