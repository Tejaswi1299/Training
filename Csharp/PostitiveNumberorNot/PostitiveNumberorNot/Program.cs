using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostitiveNumberorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 14;
            if (Num > 0)
            {
                Console.WriteLine(Num + " is a positive number");
                Console.ReadKey();
            }
            else
                Console.WriteLine(Num + " Is a Negative Number");
            Console.ReadKey();
        }
    }
}
