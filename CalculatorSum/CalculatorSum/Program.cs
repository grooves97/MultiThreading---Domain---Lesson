using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSum
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Error");
            }
            else
            {
                var firsNumber = int.Parse(args[0]);
                var secondNumber = int.Parse(args[1]);

                Console.WriteLine($"Сумма из приложения калькулятора = {firsNumber + secondNumber}");
            }
        }
    }
}
