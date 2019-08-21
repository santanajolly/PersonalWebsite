using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Profile");
        }
        public ViewResult Education()
        {
            return View();
        }
        public ViewResult Projects()
        {
            return View();
        }
        public ViewResult Skills()
        {
            return View();
        }
        
        public ViewResult Resume()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }


    }
}
