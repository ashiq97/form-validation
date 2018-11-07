using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Data.Models;
using MVC_Data.Models.ViewModels;
using MVC_Database.DatabaseContext;

namespace MVC_Tutorial.Controllers
{
    public class ShowMultipleTableDataController : Controller
    {
        // GET: ShowMultipleTableData
        public ActionResult Index()
        {
            MvcDbContext db = new MvcDbContext();
            List<Employee> employeeList = db.Employees.ToList(); // take the list of employee from database

           // EmployeeVM employeeVm = new EmployeeVM(); // my customized data model that means view model


            List<EmployeeVM> employeeVmList = employeeList.Select(x => new EmployeeVM
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                DepartmentId = x.DepartmentId,
                DepartmentName = x.Department.Dpt_Name         

            }).ToList();

            return View(employeeVmList);
        }
    }
}