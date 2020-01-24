using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using System.Text.RegularExpressions;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //need one action to load our Registration page, also need a view
        //need one action to take those user inputs, and display the user name in a new view
        public IActionResult Registration()
        {
            //if no view is specified it defaults to the Action Name
            return View();
        }

        //public IActionResult ValidPasssword(string username,string password, string email)
        //{
        //    Match getMatch = Regex.Match(password, @"^[A - Za - z0 - 9]{6,30}$");
        //    if (password =="password")
        //    {
        //        return Registered(username, password, email);
        //    }
        //    else
        //    {
        //        return InvalidPassword();
        //    }
        //}
        
        public IActionResult Registered(User user)
        {
            //use ViewBag to hold data to be displayed in the View
            //ViewBag.UserName = username;
            //ViewBag.Password = password;
            //ViewBag.Email = email;

            return View(user);
        }

        public IActionResult InvalidPassword()
        {
            return View("InvalidPassword");
        }

        public IActionResult Privacy()
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
