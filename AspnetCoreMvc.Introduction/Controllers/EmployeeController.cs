using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreMvc.Introduction.Entities;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvc.Introduction.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspnetCoreMvc.Introduction.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Bursa",Value="16"},
                    new SelectListItem{Text = "İstanbul",Value="34"}
                }
            };
            return View(employeeAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Employee employee){
            return View();
        }
    }
}