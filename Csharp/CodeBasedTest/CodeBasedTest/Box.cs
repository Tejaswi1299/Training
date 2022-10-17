using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.Write a class Box that has Length and breadth as its members. 
    Write a function that adds 2 box objects and stores in the 3rd.
    Create a Test class to execute the above.*/
namespace CodeBasedTest
{
    class Box
    {
        private double length;   
        private double breadth;  
         
        public double getVolume()
        {
            return length * breadth ;
        }

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
       

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
           
            return box;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();   
            Box Box2 = new Box();   
            Box Box3 = new Box();   
            double volume = 0.0;    
            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
           
            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);
            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);
            // Add two object as follows:
            Box3 = Box1 + Box2;

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
        }
    }
}
