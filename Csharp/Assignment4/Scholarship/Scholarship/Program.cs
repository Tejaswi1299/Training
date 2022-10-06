using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a class called Scholarship which has int Totalmarks and float fees as fields and a function Public float Merit(int m, float f) that takes Totalmarks and fees as an input.
 
If the given marks is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
If the given mark is >90, then calculate scholarship amount as 50% of the fees.
In all the cases return the Scholarship amount*/
namespace Scholarship
{
    class Program
    {
        int marks;
        float fee;
        float Scholar;
        public float Merit(int marks, float fee)
        {
            if (marks >= 70 && marks <= 80)
            {
                return (20 * fee) / 100;  
            }
            else if (marks > 80 && marks <= 90)
            {
                return (30 * fee) / 100;
            }
            else if (marks > 90)
                    {
                return (50 * fee) / 100;   
            }
            return 0;
        }
        static void Main(string[] args)
            {
            Program p = new Program();
            Console.Write("Enter Marks :");
            p.marks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fees:");
            p.fee = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Total marks: " +p.marks);
            Console.WriteLine("Fee Entered: "+p.fee);
            p.Scholar = p.Merit(p.marks,p.fee);
            Console.WriteLine("Scholarship Amount is : "+p.Scholar);
            Console.Read();

        }
    }
}
