using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operations
{
    internal class Sub : IOperation
    {
        public string Name => "sub";
        //public string Name { get { return "sub"; } }
        public double[] Args {
            set
            {
                var sub = 0d;
                foreach (var item in value)
                {
                    sub = sub - item;
                }
                Result = sub;
            }
             get { return new double[0]; }
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}
