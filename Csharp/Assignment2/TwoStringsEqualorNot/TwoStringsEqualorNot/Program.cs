using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStringsEqualorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value :");
            string str = Console.ReadLine();
            Console.WriteLine("Enter second value :");
            string str1 = Console.ReadLine();

            if(str==str1)
            {
                Console.WriteLine("Both are equal");
            }
            else
                Console.WriteLine("Both are not equal");
            Console.ReadLine();
        }
    }
}
