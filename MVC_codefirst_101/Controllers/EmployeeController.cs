using MVC_codefirst_101.Data;
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
    }
}