using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITUniver.TeleCalc.Web.Models
{
    public class CalcModel
    {
        public string OperName { get; set; }

        public double X { get; set; }

        [Required(ErrorMessage = "Пропустил!")]
        public double Y { get; set; }

        [ReadOnly(true)]
        public double Result { get; set; }

    }
}