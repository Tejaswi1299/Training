using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.Create a class called Customer with Customerid, Name, Age, Phone, City. Write a constructor with no arguments 
 and another constructorwith all information.  Write a method called DisplayCustomer(), 
    which is called directly without any object. Also  include destructor*/
namespace AcceptTwoStrings
{
    class Customer
    {
        int customerid;
        string name;
        int age;
        int phnno;
       string city;


        public Customer()
        {

        }
        public void DisplayCustomer()
        {
            Console.WriteLine("Customer id: "+customerid+'\n'+"Name: " + name + '\n' + "Age : " + age + '\n' + "Phoneno: " + phnno + '\n' + "city: " + city);
            Console.Read();
        }
        Customer (int Customerid, string Name, int Age, int Phnno, string City)
        {
            customerid = Customerid;
            name = Name;
            age = Age;
            phnno = Phnno;
            city = City;
            
        }
       
        public static void Main(string[] args)
        {
            Customer c = new Customer(123, "Teja", 22, 123456789, "Hyderabad");
            c.DisplayCustomer();

        }
        ~Customer()
        {
            Console.Write("Destructor Called");
        }
    }
}
