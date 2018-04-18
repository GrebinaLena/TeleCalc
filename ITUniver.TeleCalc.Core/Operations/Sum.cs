﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operations
{
    internal class Sum : IOperation
    {
        public string Name => "sum";
        //public string Name { get { return "sum"; } }
        public double[] Args
        {
           
                set { Result = value.Aggregate((x, y) => x + y); }
                get { return new double[0]; } 
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}
