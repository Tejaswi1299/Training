using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinandMaxValueofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 16, 15, 1, 25, 13 };
            int max = arr[0];
            int min = arr[4];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                }
            }
            Console.WriteLine("max value of an array: "+max);
            Console.WriteLine("min value of an array: "+min);
            Console.ReadLine();
        }
    }
}
