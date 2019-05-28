using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnotherDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDomain = AppDomain.CurrentDomain;
            ShowDomainInfo(currentDomain);

            var calculatorDomain = AppDomain.CreateDomain("Calculator");
            ShowDomainInfo(calculatorDomain);

            string assemblyForCalculatorDomain = currentDomain.BaseDirectory + "CalculatorSum.exe";
            calculatorDomain.ExecuteAssembly(assemblyForCalculatorDomain, new string[] { "10", "15" });
            ShowDomainInfo(calculatorDomain);

            AppDomain.Unload(calculatorDomain);

            Console.ReadLine();
        }

        private static void ShowDomainInfo(AppDomain domain)
        {
            var sortedAsseblies = domain.
                GetAssemblies().
                OrderBy(assembly => assembly.
                GetName().Name);

            Console.WriteLine($"***{domain.FriendlyName}***");
            foreach (var assembly in sortedAsseblies)
            {
                Console.WriteLine($"{assembly.GetName().Name} - {assembly.Location}");
            }
        }
    }
}
