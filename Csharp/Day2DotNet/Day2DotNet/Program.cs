using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.conversionfunc();
            //program.tryparsefunc();
            //program.Ternaryfunc();
            NullableEg.nullableFunc();
            NullableEg neg = new NullableEg();
            neg.nullcoalescingFunc();
            DecisionMaking dm = new DecisionMaking();
            dm.CheckGrade();
            dm.CheckGradeWithSwitch();
            Loops loops = new Loops();
            Console.WriteLine("-------Do While-------");
            loops.DoWhile();
            Console.WriteLine("---------For Loop ----");
            loops.ForLoop();
            Console.WriteLine("--------While Loop----");
            loops.WhileLoop();
            Console.Read();


            //Conversion
            #region
            /*public void ConversionFun()
             {
                 int x = 10;
                 Console.WriteLine("Minimum Value of an Integer is {0}", int.MinValue);//to print minvalue
                 Console.WriteLine("Maximum Value :{0}", int.MaxValue);// to print max value 
                 float f = x;//implicit conversion
                 Console.WriteLine(f);
                 //f = 12345.45f;
                 f = 1233455633447.899f;
                 x = (int)f; //explicit conversion using typecasting
                 x = Convert.ToInt32(f); //Explicit conversion using conversion function
                 Console.WriteLine(x);
                 Console.ReadLine(); */
        }
        #endregion
        //Tryparse
        #region
        /*public void tryparsefunc()
        {
            //string str = "100";
            Console.WriteLine("Enter a Number :");
            string str = Console.ReadLine();
            //x = int.Parse(str);// throws exception
            int response = 0;
            bool success = int.TryParse(str, out response);

            if (success)
            {
                Console.WriteLine("The paresed/converted data: {0}", response);
            }
            else
            {
                Console.WriteLine("Invalid data, Cann't parse");
            }
            //Console.Read();

        }*/
        #endregion
        //Ternary operator
        #region
        /* public void Ternaryfunc()
         * {
         //Ternary operator
          int number = 5;
          bool b;
          if (number == 5)
          {
              b = true;
          }
          else
              b = false;
          Console.WriteLine(b);
          Console.ReadLine();

        //above code can be reduced by using ternary operator
        //int number = 15;
        //bool b = number == 15 ? true : false;

        //Console.WriteLine(b);
        //Console.ReadLine();
    }*/
        #endregion

    }
}

