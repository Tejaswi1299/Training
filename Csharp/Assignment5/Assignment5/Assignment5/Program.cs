using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    abstract class Student
    {
        public string StudentName;
        public int StudentId;
        public float StudentGrade;
        public abstract bool Ispassed(float Grade);// abstract method

        class Undergraduate : Student
        {

            public override bool Ispassed(float StudentGrade)
            {
                if (StudentGrade > 70.0f)
                {
                    Console.WriteLine(" Passed,under graduate");
                    return true;
                }
                else
                {
                    Console.WriteLine(" Failed,undergraduate");
                    return false;
                }
            }
        }

            class graduate : Student
            {

                public override bool Ispassed(float Grade)
                {
                    if (StudentGrade > 80.0f)
                    {
                        Console.WriteLine(" Passed in Graduation");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(" Failed in graduation");
                        return false;
                    }
                }
            }

            static void Main(string[] args)
            {
              Student S1 = new Undergraduate();
              Student S2 = new graduate();
            
               Console.Write("Enter the Name of  Student : ");
                S1.StudentName = Console.ReadLine();
                S2.StudentName = S1.StudentName;
           
               Console.WriteLine("Enter Id of Student : ");
                S1.StudentId = Convert.ToInt32(Console.ReadLine());
                S1.StudentId = S2.StudentId;

               Console.WriteLine("Enter Grade of  Student : ");
                 S1.StudentGrade = Convert.ToSingle(Console.ReadLine());
                 S2.StudentGrade = S1.StudentGrade;

             if(S1.Ispassed(S1.StudentGrade) != null)
              {
                Console.Read();
              }
               else
               {
                S2.Ispassed(S2.StudentGrade);
                Console.Read();
               }
            }
    }
}
