using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITUniver.TeleCalc.Core.Operations;


namespace ITUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        [HttpGet]
        public ActionResult Index(string operName, double? x, double? y)
        {
            ViewBag.OperName = operName;
            ViewBag.x = x;
            ViewBag.y = y;
            return View();
        }

        public ActionResult Operations()
        {
            ViewBag.operations = new Core.Calc().GetOperNames();
            return View();
        }
    }
}