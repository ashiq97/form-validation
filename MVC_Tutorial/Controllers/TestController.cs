using MVC_Data.Models;
using MVC_Data.Models.ViewModels;
using MVC_Database.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MvcDbContext db = new MvcDbContext();

            Employee employee = db.Employees.SingleOrDefault(x => x.Id == 1);
            


            EmployeeVM employeeVm = new EmployeeVM();

            employeeVm.Id = employee.Id;
            employeeVm.Name = employee.Name;
            employeeVm.DepartmentId = employee.DepartmentId;
            employeeVm.Address = employee.Address;
             


            return View(employeeVm);
        }
    }
}