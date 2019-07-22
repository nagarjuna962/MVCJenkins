using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;
using MVCJenkins.Models;

namespace MVCJenkins.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        SampleEntities db = new SampleEntities();
        public ActionResult ViewEmployees()
        {
            List<sp_viewemployee_Result> list = new List<sp_viewemployee_Result>();
            list = db.sp_viewemployee().ToList();
            return View(list);
        }
    }
}