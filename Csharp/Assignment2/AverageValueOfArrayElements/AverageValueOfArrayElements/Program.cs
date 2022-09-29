using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageValueOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 13, 7, 22, 12 };
            int sum = 0;
            for(int i=0; i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }

            float avg = sum / arr.Length;
            Console.WriteLine("Average of an array:"+avg);
            Console.ReadLine();
        }
    }
}
