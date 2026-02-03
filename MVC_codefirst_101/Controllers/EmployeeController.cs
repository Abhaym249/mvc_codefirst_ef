using MVC_codefirst_101.Data;
using MVC_codefirst_101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_codefirst_101.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationdbContext context;
        public EmployeeController()
        {
            context = new ApplicationdbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employeesList = context.Employees.ToList();

            return View(employeesList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (employee == null) return HttpNotFound();

            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {
            var employee = context.Employees.Find(id);
            if (employee == null) return HttpNotFound();
            return View(employee);
        }
    }
}