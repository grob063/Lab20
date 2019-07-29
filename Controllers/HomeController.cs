using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab20EFCore.Models;
using Lab20EFCore.GenesCoffee;
using System.Configuration;
using Microsoft.AspNetCore.Authorization;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace Lab20EFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyCoffeeContext _context;  

        public HomeController(MyCoffeeContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([Bind("UserName,Password")] User user)
        { 
            if (ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
            }

            HttpContext.Session.SetString("userName", user.UserName);
            return View("Welcome");
        }

        public IActionResult Login(string username)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Welcome()
        {            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
