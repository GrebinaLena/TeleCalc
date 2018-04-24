using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITUniver.TeleCalc.Core.Operations;
using ITUniver.TeleCalc.Core;
using ITUniver.TeleCalc.Web.Models;

namespace ITUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        Calc Calc = new Core.Calc();


        [HttpPost]
        public PartialViewResult Exec(CalcModel model)
        {
            var result = double.NaN;

            if (Calc.GetOperNames().Contains(model.OperName))
            {
                result = Calc.Exec(model.OperName, model.InputData);
            }

            return PartialView("ExecResult", result);
        }

        [HttpGet]
        public ActionResult Exec()
        {
            var model = new CalcModel();
            model.OperationList = new SelectList(Calc.GetOperNames());
 
                return View(model);
        }

        [HttpGet]
        public ActionResult Index(string operName, double? x, double? y)
        {
            if (Calc.GetOperNames().Contains(operName))
            {
                ViewBag.OperName = operName;
                ViewBag.x = x;
                ViewBag.y = y;
                ViewBag.Result = Calc.Exec(operName, x ?? 0, y ?? 0);
            }
            else
            {
                ViewBag.Error = "Укажите операцию";
            }

            return View();
        }

        public ActionResult Operations()
        {

            ViewBag.operations = Calc.GetOperNames();
            return View();
        }
    }
}