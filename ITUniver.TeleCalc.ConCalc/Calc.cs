using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    public class Calc
    {
        public double Sum(double x, double y)
        {
            return x+y;
        }

        public double Sub(double x, double y)
        {
            return x-y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("Деление на ноль невозможно!");
                return 0;
            }
            
        }

        public double Pow(double x, double y)
        {
           return Math.Pow(x, y);

        }

    }
}
