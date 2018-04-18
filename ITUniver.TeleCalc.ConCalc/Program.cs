using ITUniver.TeleCalc.Core;
using ITUniver.TeleCalc.Core.Operations;
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
                    Console.WriteLine("Пожалуйста, выберите операцию:" + "\n");
                    var list = calc.operations;
                    for (int i = 1; i <= list.Length; i++)
                    {
                        Console.WriteLine(i.ToString() + ". " + list[i-1] + "\n");
                    }

                    string oppname = Console.ReadLine();
                    IOperation oper = list.FirstOrDefault(c => c.Name == oppname);
                    if (oper == null)
                        Console.WriteLine("Операция не существует");
                    else
                    {
                        Console.WriteLine("Введите аргументы через пробел");

                    }
                   



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
