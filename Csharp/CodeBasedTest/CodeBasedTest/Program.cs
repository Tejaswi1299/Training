using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1.Write a program to find the Sum and the Average points scored by the teams in the IPL.
    Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches)
    that takes no.of matches as input and accepts that many scores from the user.
    The function should then display the Average and Sum of the scores.*/
namespace CodeBasedTest
{
    class Cricket
    {

        Cricket cricket = new Cricket();
        public static List<int> PointsCalculation(int no_of_matches)
        {
            int avg;
            int sum = 0;

            List<int> scores = new List<int>();

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.WriteLine("Enter the score for match {0}: ", i);
                int marks = Convert.ToInt32(Console.ReadLine());
                scores.Add(marks);
            }

            foreach (int s in scores)
            {
                sum = sum + s;
            }

            void Avg_Calculation(int Total, int No_of_matches)
            {
                Console.WriteLine("The Total score of all matches are: " + sum);
                avg = sum / no_of_matches;
                Console.WriteLine("The avg score of all matches is: " + avg);
            }

            Avg_Calculation(sum, no_of_matches);
            return scores.ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricket.PointsCalculation(4);
            Console.ReadKey();
        }
    }
}


        //string[] names = new string[no_of_matches];
        //int[] score = new int[no_of_matches];
        //double avg1 = 0;

        //for (int i = 0; i < no_of_matches; i++)
        //{
        //    Console.Write("Enter a score between 1 - 100.  ");
        //    score[i] = Convert.ToInt32(Console.ReadLine());
        //    while (true)
        //    {
        //        if (!(score[i] >= 1 && score[i] <= 100))
        //        {
        //            Console.WriteLine("Invalid number entered.");
        //            score[i] = Convert.ToInt32(Console.ReadLine());
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    avg1 = avg(score);


    