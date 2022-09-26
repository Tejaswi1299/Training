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
            TestClass tc = new TestClass();
             tc.show();
            tc.accept();
            tc.show();
            // TestClass tc2 = new TestClass();
            // tc2.Show();
            TestClass.Message();
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
            Console.WriteLine(age + " " + name + " " + companyname); //concatenation
            Console.WriteLine("Name is :{0} Age is :{1} and Company Name is :{2}", name, age, companyname); //place holder
            Console.WriteLine($"Name is {name}, Age is {age},Company name is {companyname}");
        }
        public void accept()
        {
            Console.WriteLine("Enter age, name, company name");
            age = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            companyname = Console.ReadLine();

        }
        public static string Message()  //static method are maintained at class level
        {
            return "Hello";
        }
    }

}
