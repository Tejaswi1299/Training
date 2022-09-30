using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temparature_in_Celsius_and_Fahreheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius = 40;

            double Fahrenheit;

            //Console.WriteLine("Celsius:" + Celsius);
            Fahrenheit = ((Celsius * 9) / 5) + 32;
            //Console.WriteLine( "Fahrenheit:" + Fahrenheit);
            
            Console.WriteLine("Celsius :{0} Fahrenheit :{1}", Celsius, Fahrenheit);
            Console.ReadLine();

        }
    }
}
