using ITUniver.TeleCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Пожалуйста, выберите номер операции:" + "\n");
                    var list = calc.operations;
                    for (int i = 1; i <= list.Length; i++)
                    {
                        Console.WriteLine(i.ToString() + ". " + list[i-1] + "\n");
                    }

                    string a = Console.ReadLine();
                    int number;
                    if (Int32.TryParse(a, out number))



                    Console.ReadKey();
                    return;
                }

                string operName = args[0];

                double x = Double.Parse(args[1]);
                double y = Double.Parse(args[2]);

                
                double? result = calc.Exec(operName, x, y);

                Console.WriteLine(string.Format("{0}{1}{2} = {3}", x, operName, y, result));
                Console.ReadKey();
            }

        }

    }
}
