using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetMaster.MVC.Controllers
{
    public class ErrorController : Controller
    {
        //[Route("error/404")]
        //public IActionResult Error404()
        //{
        //    return View();
        //}
        [Route("error/{code:int}")]
        public IActionResult Error404(int code)
        {

            return View();
        }
        //通配符
        //[Route("{*url}",Order =999)]
        //public IActionResult Error()
        //{
        //    return View();
        //}
    }
}
