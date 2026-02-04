using MVC_codefirst_101.Data;
using MVC_codefirst_101.Models;
using System.Linq;
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
        public ActionResult Edit(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee == null) return HttpNotFound();
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (employee == null) return HttpNotFound();
            var emloyeefromDb = context.Employees.Find(employee.Id);
            if (emloyeefromDb == null) return HttpNotFound();
            emloyeefromDb.Name = employee.Name;
            emloyeefromDb.Address = employee.Address;
            emloyeefromDb.Salary = employee.Salary;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var employeefromDb = context.Employees.Find(id);
            if (employeefromDb == null) return HttpNotFound();
            return View(employeefromDb);

        }
        public ActionResult Delete(int id)
        {
            var employeefromDb = context.Employees.Find(id);
            if (employeefromDb == null) return HttpNotFound();
            return View(employeefromDb);
        }
        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            if (employee == null) return HttpNotFound();
            var employeefromDb = context.Employees.Find(employee.Id);
            if (employeefromDb == null) return HttpNotFound();
            context.Employees.Remove(employeefromDb);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}