using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Create a class called Saledetails which has data members like Salesno, Productno, Price, dateofsale, Qty, TotalAmount
//Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty *Price
//Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
//call the show data method to display the values.
//Hint : Use This pointer
namespace SaleDetails
{
    class Program
    {
        int Salesno;
        int Productno;
        int Price;
        String dateofsale;
        int Qty;
        int TotalAmount;
        public int Sales(int Price, int Qty)
        {
          
         return TotalAmount = (Qty * Price);   
          
        }
        public Program ( int productno, int salesno,string Dateofsale)
        {
            Productno = productno;
            Salesno= salesno;
            dateofsale=Dateofsale ;
            
        }
        public void showDetails()
        {
            
            Console.WriteLine("Quantity id: "+Qty + "\n" +"Price is :" +Price + "\n" + "Total Amount is :"+TotalAmount );
            Console.WriteLine("Productno: " + Productno);
            Console.WriteLine("salesno : " + Salesno);
            Console.WriteLine("Dateofsale : " + dateofsale);
        }
        static void Main(string[] args)
        {
            Program P = new Program(123, 12, "10 / 06 /2022");
            //Console.WriteLine("Productno: " + P.Productno);
            //Console.WriteLine("salesno : " +P.Salesno );
            //Console.WriteLine("Dateofsale : " + P.dateofsale);
           
            P.Price = 2000;
            Console.Write("Enter Quantity : ");
            P.Qty = Convert.ToInt32(Console.ReadLine());
            P.TotalAmount=P.Sales(P.Price,P.Qty);
            P.showDetails();
            Console.Read();
        }


    }
    
}
