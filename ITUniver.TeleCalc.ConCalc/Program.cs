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
            string operName = " ";
            double x;
            double y;

            if (args.Length == 3)
            {
                operName = args[0];
                x = Double.Parse(args[1]);
                y = Double.Parse(args[2]);
            }

            else 
            {
              Console.WriteLine("Пожалуйста, выберите операцию:" + "\n");
              var list = calc.GetOperNames();
              foreach (var item in list)
              {
                Console.WriteLine(item);
              }

              operName = Console.ReadLine();
              Console.WriteLine("Введите параметры через пробел");
              var data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
              x = double.Parse(data[0]);
              y = double.Parse(data[1]);
              
            }
            

            var result = calc.Exec(operName, x, y);
            //double? result = calc.Exec(operName, x, y);
            Console.WriteLine(string.Format("{0}{1}{2} = {3}", x, operName, y, result));
            Console.ReadKey();

        }

    }
}
