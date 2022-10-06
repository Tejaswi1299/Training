using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptTwoStrings
{
    /*Create a Program to count the no.of occurrences of a letter in a given string (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
Hint : Accept a string and also the letter to be counted*/
    class CountLetterOccurances
    {
        public static void Main(string[] args)
           {
            Console.WriteLine("Enter String value : "); //OOPS
            string s = Console.ReadLine();
            int Count = 0;
            Console.WriteLine("Enter input character");
            char input=Convert.ToChar(Console.ReadLine());
            for (int i = 0; i <s.Length; i++)
            {      
                    if (s[i] == input)
                    {
                    Count++;    
                    }
               
            }
            Console.WriteLine("No Of Occurance of O is : " + Count);
            Console.Read();
        }
}
}

