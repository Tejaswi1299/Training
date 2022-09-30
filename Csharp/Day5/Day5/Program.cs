using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Access Modifiers
namespace Day5
{
    class A

    {
        public string name;
        protected DateTime DOJ;
        internal float salary;
        private int num;
        internal protected char x;

        public void Function()
        {
            DOJ = Convert.ToDateTime("22/10/2021");
            name = "Tejaswi";
            num = 7732073;
            x = 'A';
            salary = 5000;

        }

    }
    class B : A //class B inherits Class A (Child class)
    {
        static void Main(string[] args)
        {
            A a1 = new A(); //public,internal,internal protected can be accessed by creating object of class A
            a1.name = "Teja"; //public
            a1.salary = 50000;//internal 
            a1.x = 'A';//internal protected


            B B1 = new B();//By creating object of class B
            B1.name = "Teja";//public
            B1.salary = 40000;//internal
            B1.x = 'C';//internal protected
            B1.DOJ = Convert.ToDateTime("22/10/2021");//protected


        }
    }
   /* class B //seperate class
    {
        static void Main(string[] args)
        {
            A a1 = new A();//public,internal,internal protected can be accessed by creating object in class A
            a1.name = "Teja";//public
            a1.salary = 50000;//internal
            a1.x = 'A';//internal protected

            B b1 = new B();// we cann't access any members of A class
            //b1.(//we can't access)
        }
    }*/
}
