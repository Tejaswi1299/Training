using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Sales()
        {
            Qty = 2;
            Price = 1000;
            TotalAmount = (Qty * Price);   
            
        }
         Program ( int productno, int salesno,string Dateofsale)
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
            P.Sales();
            P.showDetails();
            Console.Read();
        }


    }
    
}
