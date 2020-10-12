using Microsoft.AspNetCore.Mvc;
using NetMaster.Blog.Models;
using NetMaster.Blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Controllers
{
    public class DepartmentController:Controller
    {
        private readonly IDeparmentService _deparmentServices;
        public DepartmentController( IDeparmentService  deparmentServices)
        {
            _deparmentServices = deparmentServices;
        }

       

        public async Task< IActionResult> Index()
        {
            ViewData["Title"] = "员工";
            return View( await _deparmentServices.GetAll());
        }

        public IActionResult Add()
        {
            return View(new Department());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Department department)
        {
            if (ModelState.IsValid)
            {
                await _deparmentServices.Add(department);
            }
            return RedirectToAction("Index");
        }
    }
}
