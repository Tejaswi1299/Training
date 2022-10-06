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
            Console.WriteLine("Enter first Name :");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter second Name :");
            string LastName = Console.ReadLine();
            Program.Display(FirstName, LastName);
        }

       
        static void Display(String FirstName, string LastName)
        {
            

            Console.WriteLine(FirstName.ToUpper() + '\n' + LastName.ToUpper());
            Console.ReadLine();
        }
    }
}
