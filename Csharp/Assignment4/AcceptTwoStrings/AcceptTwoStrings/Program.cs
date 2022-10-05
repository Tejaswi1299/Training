using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptTwoStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Program.Display();
        }
        static void Display()
        {
            Console.WriteLine("Enter first Name :");
            string str = Console.ReadLine();
            string s = str.ToUpper();
            Console.WriteLine("Enter second Name :");
            string str1 = Console.ReadLine();
            string s1 = str1.ToUpper();

            Console.WriteLine(s + '\n' + s1);
            Console.Read();
        }
    }
}
