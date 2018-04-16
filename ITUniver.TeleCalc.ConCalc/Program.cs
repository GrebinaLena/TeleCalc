using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc Calculator = new Calc();
            double x;
            double y;
            bool args1 = (Double.TryParse(args[1], out x));
            bool args2 = (Double.TryParse(args[2], out y));

            if ((args1 == true) && (args2 == true))
            {
                if (args[0].ToLower() == "sum")
                {
                    Console.WriteLine(Calculator.Sum(x, y));
                }

                if (args[0].ToLower() == "sub")
                {
                    Console.WriteLine(Calculator.Sub(x, y));
                }

                if (args[0].ToLower() == "mul")
                {
                    Console.WriteLine(Calculator.Mul(x, y));
                }

                if (args[0].ToLower() == "div")
                {
                    Console.WriteLine(Calculator.Div(x, y));
                }

                if (args[0].ToLower() == "pow")
                {
                    Console.WriteLine(Calculator.Pow(x, y));
                }
                else
                {
                    Console.WriteLine("Операция не существует");
                }
            }

           else
            {
                Console.WriteLine("Операция не может быть выполнена");
            }

            Console.ReadLine();

        }

    }
}
