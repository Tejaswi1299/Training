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
        DateTime dateofsale;
        int Qty;
        int TotalAmount;
        static void Main(string[] args)
        {
            details D = new details(123, 12);
            D.Sales();
            D.showDetails();
            Console.Read();
        }
        public void Sales()
        {
            Qty = 1;
            Price = 1000;
            TotalAmount = (Qty * Price);    
        }
         public details ( int Productno, int Salesno,DateTime dateofsale)
        {
           this.Productno= 123;
            this.Salesno = 12;
          
        }
        public void showDetails()
        {
            Console.WriteLine(Qty + '\n' + Price + '\n' + TotalAmount + '\n' + Productno + '\n' + Salesno);
            
        }


    }
    
}
