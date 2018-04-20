﻿using System;
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


        [HttpGet]
        public ActionResult Exec()
        {
            return View();
        }

        [HttpPost]


        public ActionResult Exec(CalcModel model)
        {
            if (Calc.GetOperNames().Contains(model.OperName))
            {
                model.Result = Calc.Exec(model.OperName, model.X, model.Y);
            }
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