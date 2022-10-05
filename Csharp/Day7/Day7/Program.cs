using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        public static void swaping(int num1,int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("swapping of numbers num1 :" + num1 + " num2 :" + num2);
                }
        public static void swaping(char a1,char a2)
        {
            char temp = ' ';
            temp = a1;
            a1 = a2;
            a2 = temp;
            Console.WriteLine("swapping of characters a1 :" + a1 + " a2: " + a2);
        }
        static void Main(string[] args)
        {
            // swaping(); throws eror because of overloading
            swaping(4, 5);
            swaping('a', 'b');
            Console.Read();

        }
    }
}
