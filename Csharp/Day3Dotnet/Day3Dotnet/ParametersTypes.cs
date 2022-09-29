using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Dotnet
{
    class ParametersTypes
    {
        public void ValueType(int x)
        {
            Console.WriteLine(x);
            Console.WriteLine("Value is passed");
            x = 100;
            Console.WriteLine(x);
        }
        public void ReferenceType(ref int y)
        {
            Console.WriteLine(y);
            Console.WriteLine("Value is passed");
            y = 100;
            Console.WriteLine(y);
        }
        public static void Main(String[] args)
        {
            int a = 10;
            //call by value
            ParametersTypes pt = new ParametersTypes();
            // pt.ValueType(a);
            // Console.WriteLine("Original value of Variable a" + " " + a);

            //Ref type
            pt.ReferenceType(ref a);
            Console.WriteLine("Original value of Variable a" + " " + a);
            Console.ReadLine();
        }
    }
}
