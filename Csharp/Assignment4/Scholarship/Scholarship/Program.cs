using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        public int m=92;
        public float f=700f;

        public float Merit(int m, float f)
        {
            this.m = 75;
            this.f = 100f;
            return f;
        }
        public static void Main(string[] args)
            {
                //Console.WriteLine("Enter Total Marks");
                //int m = Console.Read();
                //Console.WriteLine("Enter fees");
                //int f = Console.Read();
                Program p = new Program();
                Console.WriteLine(p.m);
                Console.WriteLine(p.f);
                float Scholar;
                if (p.m >= 70 && p.m <= 80)
                {
                    Scholar = (20 *p.f) /100;
                    Console.WriteLine("Scholarship Amount : "+Scholar);

                }
                if (p.m >= 80 && p.m <= 90)
                {
                    Scholar = (30 *p.f) /100;
                    Console.WriteLine("Scholarship Amount : " + Scholar);
                }
                if (p.m > 90)
                {
                    Scholar = (50 * p.f) / 100;
                    Console.WriteLine("Scholarship Amount : " + Scholar);
                }
                Console.Read();
            
        } }
}
