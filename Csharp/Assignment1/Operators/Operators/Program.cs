using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 12;

            int add = num1 + num2;
            int subtract = num1 - num2;
            int multiply = num1 * num2;
            int divide = num1 / num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + subtract);
            Console.ReadKey();
        }
    }
}
