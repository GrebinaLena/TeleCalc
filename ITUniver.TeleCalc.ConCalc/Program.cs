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
            string args0 = args[0].ToLower();

            if ((args1 == true) && (args2 == true))
            {
                switch (args0)
                {
                    case "sum":
                        Console.WriteLine(Calculator.Sum(x, y));
                        break;

                    case "sub":
                        Console.WriteLine(Calculator.Sub(x, y));
                        break;

                    case "mul":
                        Console.WriteLine(Calculator.Mul(x, y));
                        break;

                    case "div":
                        Console.WriteLine(Calculator.Div(x, y));
                        break;

                    case "pow":
                        Console.WriteLine(Calculator.Pow(x, y));
                        break;

                    default:
                        Console.WriteLine("Операция не существует");
                        break;

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
