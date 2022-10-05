using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptTwoStrings
{
    class CountLetterOccurances
    {
        public static void Main(string[] args)
           {
            Console.WriteLine("Enter String value : "); //OOPS
            string s = Console.ReadLine();
            int Count = 0;
            for (int i = 0; i <s.Length; i++)
            {      
                    if (s[i] == 'O')
                    {
                    Count++;    
                    }
               
            }
            Console.WriteLine("No Of Occurance of O is : " + Count);
            Console.Read();
        }
}
}

