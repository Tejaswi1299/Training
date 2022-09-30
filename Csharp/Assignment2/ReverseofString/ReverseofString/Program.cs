using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseofString
{
    class ReverseofString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string stringInput = Console.ReadLine();
             char[] charArray = stringInput.ToCharArray();
              Array.Reverse(charArray);
              Console.WriteLine(new string(charArray));
            Console.ReadLine();
        }
    }
}