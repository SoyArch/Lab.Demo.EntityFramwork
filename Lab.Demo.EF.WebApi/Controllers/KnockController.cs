using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.EF.WebApi.Controllers
{
    public class KnockController : Controller
    {
        // GET: Knock
        public ActionResult Index()
        {
            return View();
        }
    }
}