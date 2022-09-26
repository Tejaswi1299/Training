using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello All");
            Program program = new Program();
            //int Result = program.Add2nos(5, 10);
            //Console.WriteLine(Result);
            Console.WriteLine(Add2nos(10, 10));
            TestClass TC = new TestClass();
            Console.ReadKey();

        }

        static int Add2nos(int X,int Y)
        {
            return X + Y;
        }
    }

    class TestClass
    {
        int age;
        string name;
        static string companyname = "infinite";

        public void show()
        {
            Console.WriteLine(age + " ", name);
        }
        static void accept()
        {
            Console.WriteLine("Enter age and name")
        }
    }

}
