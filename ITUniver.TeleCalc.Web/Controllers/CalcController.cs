using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITUniver.TeleCalc.Core.Operations;
using ITUniver.TeleCalc.Core;


namespace ITUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        Calc Calculator = new Core.Calc();
        [HttpGet]
        public ActionResult Index(string operName, double? x, double? y)
        {
            ViewBag.OperName = operName;
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.Result = Calculator.Exec(ViewBag.OperName, ViewBag.x, ViewBag.y);
            return View();
        }

        public ActionResult Operations()
        {
            ViewBag.operations = Calculator.GetOperNames();
            return View();
        }
    }
}