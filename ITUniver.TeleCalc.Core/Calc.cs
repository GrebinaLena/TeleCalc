using ITUniver.TeleCalc.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core
{
    public class Calc
    {

        public IOperation[] operations { get; set; }
        public Calc()
   
        {

            var opers = new List<IOperation>();
            var assembly = Assembly.GetExecutingAssembly();//получить текущую сборку
            var classes = assembly.GetTypes();//получить все типы в ней
            foreach (var item in classes)
            {
                var interfaces = item.GetInterfaces();//получаем интерфейсы, которые реализует класс
                var isOperation = interfaces.Any(i => i == typeof(IOperation)); //если хотя бы один из интерфейсов имеет заданное имя
                foreach (var inter in interfaces)
                {
                    
                if (isOperation)
                    {
                        var obj = Activator.CreateInstance(item) as IOperation;
                        if (obj != null)
                        {
                            opers.Add(obj);
                        }
                        
                
                    }
                }
            }

            operations = opers.ToArray();
         

        }

        public double Exec(string operName, double x, double y)
        {
            IOperation operation = operations
            .FirstOrDefault(o => o.Name == operName);
            if (operation == null)
                return double.NaN;
         
            //var operation = new Sum();
            operation.Args = new double[] { x, y };
            return (double)operation.Result;
        }


        public double Sum(double x, double y)
        {
            var sum = new Sum();
            sum.Args = new double[] { x, y };
            return  (double)sum.Result;
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

        public double SQr(double x)
        {
            return Math.Pow(x, 2);
        }

    }
}
