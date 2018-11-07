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
    public class Hyperlinks_Ancor_TagController : Controller
    {
        // GET: Hyperlinks_Ancor_Tag
        public ActionResult Index()
        {
            MvcDbContext db = new MvcDbContext();
            List<Employee> employeeList = db.Employees.ToList();

            List<EmployeeVM> employeeVmList = employeeList.Select(x => new EmployeeVM
            {
                Name = x.Name,
                Id = x.Id

            }).ToList();
            


            return View(employeeVmList);
        }

        public ActionResult EmployeeDetail(int EmpId)
        {
            MvcDbContext db = new MvcDbContext();

            Employee oneEmployeeData = db.Employees.SingleOrDefault(x => x.Id == EmpId);

            EmployeeVM oneEmployeeViewModelData = new EmployeeVM();

            oneEmployeeViewModelData.Name = oneEmployeeData.Name;
            oneEmployeeViewModelData.Address = oneEmployeeData.Address;
            oneEmployeeViewModelData.DepartmentName = oneEmployeeData.Department.Dpt_Name;

            return View(oneEmployeeViewModelData);
        }

    }
}