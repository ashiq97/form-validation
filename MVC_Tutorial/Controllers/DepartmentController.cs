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
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            MvcDbContext db = new MvcDbContext();

            List<Department> dptList = db.Departments.ToList();

            ViewBag.DepartmentList = new SelectList(dptList, "Id", "Dpt_Name");
 
            return View();
        }
        
        [HttpPost]

        public ActionResult Index(EmployeeVM model)
        {
            if (ModelState.IsValid == true)
            {
                // write your code may be you can save the data in database then return it

            }
            MvcDbContext db = new MvcDbContext();
            List<Department> dptList = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(dptList, "Id", "Dpt_Name");

            return View(model);
        }



        /*
                [HttpPost]

                public ActionResult Index(EmployeeVM model)
                {
                    if(ModelState.IsValid == true)
                    {
                        // write your code may be you can save the data in database then return it

                    }
                    MvcDbContext db = new MvcDbContext();
                    List<Department> dptList = db.Departments.ToList();
                    ViewBag.DepartmentList = new SelectList(dptList, "Id", "Dpt_Name");

                    return View(model);
                }
                */

        /*
                public ActionResult SaveRecord(EmployeeVM model)
                {

                    try
                    {
                        MvcDbContext db = new MvcDbContext();

                        Employee emp = new Employee();

                        emp.Name = model.Name;
                        emp.Address = model.Address;
                        emp.DepartmentId = model.DepartmentId;

                        db.Employees.Add(emp);
                        db.SaveChanges();

                        int latestEmpId = emp.Id;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }




                    return RedirectToAction("Index");

                }
                */
        //[HttpPost]

        //public ActionResult SaveRecord(EmployeeVM model)
        //{
        //    try
        //    {
        //        MvcDbContext db = new MvcDbContext();

        //        List<Department> list = db.Departments.ToList();

        //        ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");

        //        Employee emp = new Employee();
        //        emp.Address = model.Address;
        //        emp.Name = model.Name;
        //        emp.DepartmentId = model.DepartmentId;
        //        db.Employees.Add(emp);
        //        db.SaveChanges();
        //        int latestEmpId = emp.Id;
        //        return RedirectToAction("Index");
        //    }

        //    catch (Exception ex)
        //    {
        //        throw ex;

        //    }
        //}


    }
}