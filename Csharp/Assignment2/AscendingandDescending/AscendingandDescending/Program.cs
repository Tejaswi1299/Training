using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingandDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 31, 22, 43, 41, 15, 63, 7, 18, 9, 16};
            int sum = 0;
            int max = arr[0];
            int min = arr[9];

            System.Array.Sort(arr);
            Console.WriteLine("Ascending order: ");
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }
          
            foreach (int Value in arr)
            {
                Console.WriteLine(Value);
            }
            System.Array.Reverse(arr);
            Console.WriteLine("\n\ndesc");
            foreach(int Value in arr)
            {
                Console.WriteLine(Value);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            float avg = sum / arr.Length;
            Console.WriteLine("Average of an array:" + avg);
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
            Console.WriteLine("max value of an array: " + max);
            Console.WriteLine("min value of an array: " + min);
            Console.ReadLine();
        }
    }
}
