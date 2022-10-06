using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a Class called Doctor with RegnNo, Name, Feescharged as Private members. Allow values to be set and also to display the same.
namespace Doctor
{
    class Program
    {
        private int RegNo;
        private string Name;
        private int FeesCharged;

        public string name
        {
            get { return Name;}
            set {Name= value; }
        }
         public int regno
         {
            get { return RegNo; }
            set { RegNo = value; }
         }
        public int feescharged
        {
            get { return FeesCharged; }
            set { FeesCharged = value; }
        }

        public void Display()
        {
            Console.WriteLine("Name :"+Name+'\n'+"Regno: "+RegNo+'\n'+"Fees charchable: "+FeesCharged);
            Console.ReadLine();
        }
        
    }
    class DoctorFees
    {
        static void Main(string[] args)
        {
            Program D = new Program();
            D.name = "Tejaswi";
            D.regno = 23;
            D.feescharged = 300;
            D.Display();

        }
    }
}
