using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.EF.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeLogic Logic = new EmployeeLogic();
        public ActionResult Index()
        {
            var employees = Logic.GetAll();
            return View(employees);
        }

        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee) {



            return RedirectToAction("Index");
        }
    }
}