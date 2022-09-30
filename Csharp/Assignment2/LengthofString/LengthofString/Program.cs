using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthofString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine(len);
            Console.Read();
        }
    }
}
