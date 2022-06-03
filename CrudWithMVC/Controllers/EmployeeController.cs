using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudWithMVC.Models;
namespace CrudWithMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _DbContext;
        public EmployeeController(ApplicationDbContext dbContext)
        {
            this._DbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee> emps = _DbContext.Employees.ToList();
            return View(emps);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee Emp)
        {
            if (ModelState.IsValid)
            {
                _DbContext.Employees.Add(Emp);
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            var emps = _DbContext.Employees.SingleOrDefault(e => e.Id == id);
            if (emps!=null)
            {
                _DbContext.Employees.Remove(emps);
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");

            }
           
        }
        public IActionResult Edit(int id)
        {
            var emp = _DbContext.Employees.SingleOrDefault(e => e.Id == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emps)
        {
            _DbContext.Employees.Update(emps);
            _DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var emps = _DbContext.Employees.SingleOrDefault(e => e.Id == id);
            return View(emps);
        }
        [HttpPost]
        public IActionResult Details(Employee emp)
        {
            _DbContext.Employees.Find(emp);
            _DbContext.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
