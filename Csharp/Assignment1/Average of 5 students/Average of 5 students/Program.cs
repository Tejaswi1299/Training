using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_5_students
{
    class Program
    {
        static void Main(string[] args)
        {
            int Stu1 = 10;
            int stu2 = 15;
            int stu3 = 15;
            int stu4 = 10;
            int stu5 = 15;

            int Result = Stu1 + stu2 + stu3 + stu4 + stu5 / 5;
            if (Result<50)
            {
                Console.WriteLine("failed");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Passed");
            Console.ReadKey();

        }
    }
}
