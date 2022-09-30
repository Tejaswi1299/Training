using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string stringInput = Console.ReadLine();
            string str = stringInput;
            char[] charArray = stringInput.ToCharArray();
            Array.Reverse(charArray);
            //Console.WriteLine(new string (charArray));
            string rev = new string(charArray);
           
            if (str == rev)
            {
                Console.WriteLine(rev + " is palindrome");
            }
            else
                Console.WriteLine("not a palindrome string");
            Console.ReadLine();
        }
    }
}
