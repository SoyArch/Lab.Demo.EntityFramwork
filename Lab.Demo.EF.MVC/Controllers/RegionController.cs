using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.EF.MVC.Controllers
{
    public class RegionController : Controller
    {
        public RegionLogic logic = new RegionLogic();

        public ActionResult Index()
        {

            var regions = logic.GetAll();

            return View(regions);

        }
        public ActionResult UpdateForm(int id)
        {

           var reg = logic.GetOne(id);

            return View(reg);

        }


        public ActionResult Update(Region region)
        {

            logic.Update(region);

            return RedirectToAction("Index");
        }

        public ActionResult CreateForm()
        {

            return View();
        }


        public ActionResult Create(Region region)
        {
            logic.Add(region);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteForm(int id)
        {
            var reg = logic.GetOne(id);

            return View(reg);
        }


        public ActionResult Delete(Region region)
        {

            var regiondelete = logic.GetOne(region.RegionID);

            logic.Delete(regiondelete);

            return RedirectToAction("Index");
        }

    }
}