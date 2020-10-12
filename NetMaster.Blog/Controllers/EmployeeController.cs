using Microsoft.AspNetCore.Mvc;
using NetMaster.Blog.Models;
using NetMaster.Blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Controllers
{
    public class EmployeeController:Controller
    {
        public readonly IEmployeeService _employeeService;
        public readonly IDeparmentService _deparmentService;
        public EmployeeController(IEmployeeService empolyeeService,IDeparmentService deparmentService)
        {
            _employeeService = empolyeeService;
            _deparmentService = deparmentService;
        }
        public async Task<IActionResult> Index(int departmentId)
        {
            var department =await _deparmentService.GetById(departmentId);
            var employee = await _employeeService.GetByDepartemyId(department.Id);
            ViewBag.DepartmentId = departmentId;
            return View(employee);
        }
        public IActionResult Add(int departmentId)
        {
            ViewData["Title"] = "添加员工";
            ViewBag.DepartmentId = departmentId;
            return View(new Employee {
            DepartmentId=departmentId
            });
        }
        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
               await _employeeService.Add(employee);
            }
            return RedirectToAction("Index",new { departmentId = employee.DepartmentId});
        }

        public async Task<IActionResult> Fired(int employeeId)
        {
          var employee=  await _employeeService.Fired(employeeId);
            return RedirectToAction("Index", new { departmentId = employee.DepartmentId });
        }
    }
}
