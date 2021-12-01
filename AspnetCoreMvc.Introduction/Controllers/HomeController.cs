using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreMvc.Introduction.Entities;
using AspnetCoreMvc.Introduction.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreMvc.Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from first app";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Aysun", LastName = "Bakkal", CityId=16},
                new Employee{Id=2, FirstName = "Aslı", LastName = "Bakkal", CityId=16},
                new Employee{Id=3, FirstName = "Mislina", LastName = "Sart", CityId=34}
            };
            List<string> cities = new List<string> { "Bursa", "İstanbul" };
            var employeeListViewModel = new EmployeeListViewModel
            {
                Employees = employees,
                Cities =cities
            };
            return View(employeeListViewModel);
        }
        public StatusCodeResult Index4()
        {
            return Ok();
        }
        public IActionResult Index5()
        {
            return StatusCode(400);// NotFound();
        }
        public RedirectResult Index6()
        {
            return Redirect("/Home/Index3");
        }
        public IActionResult Index7() // Hangi aksiyoma gideyim?
        {
            return RedirectToAction("Index2");
        }
        public IActionResult Index8() 
        {
            return RedirectToRoute("default");
        }
        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Aysun", LastName = "Bakkal", CityId=16},
                new Employee{Id=2, FirstName = "Aslı", LastName = "Bakkal", CityId=16},
                new Employee{Id=3, FirstName = "Mislina", LastName = "Sart", CityId=34}
            };
            return Json(employees);
        }
        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Aysun", LastName = "Bakkal", CityId=16},
                new Employee{Id=2, FirstName = "Aslı", LastName = "Bakkal", CityId=16},
                new Employee{Id=3, FirstName = "Mislina", LastName = "Sart", CityId=34}
            };
            List<string> cities = new List<string> { "Bursa", "İstanbul" };
            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };
            return View(model);
        }
        public JsonResult Index10(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName = "Aysun", LastName = "Bakkal", CityId=16},
                new Employee{Id=2, FirstName = "Aslı", LastName = "Bakkal", CityId=16},
                new Employee{Id=3, FirstName = "Mislina", LastName = "Sart", CityId=34}
            };
            if (String.IsNullOrEmpty(key))
            {
                return Json(employees);
            }
            var result = employees.Where(i=> i.FirstName.ToLower().Contains(key));
            return Json(result);
        }
        public ViewResult EmployeeForm()
        {
            return View();
        }
        public string RouteData(int id)
        {
            return id.ToString();
        }
    }
}