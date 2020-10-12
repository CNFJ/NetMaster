using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetMaster.Blog.Services;

namespace NetMaster.Blog.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IClock clock)
        {
                
        }
        public IActionResult Index()
        {
            ViewData["Controller"] = "Home";
            ViewData["Action"] = "Index";
          
            return View();
        }
    }
}
