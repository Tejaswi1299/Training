using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.Create a structure
struct Books ,private string title;private string author;private string subject;private int book_id;
Include 2 methods called GetValues() and ShowValues() to accept and display details.*/

namespace Assignment6
{
    struct Book
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };

    public class testStructure
    {
        public static void Main(string[] args)
        {

            Book Book1; 
            Book Book2; 
            
         Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

      
          Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

      
     Console.WriteLine("Book 1 title: {0}", Book1.title);
            Console.WriteLine("Book 1 author: {0}", Book1.author);
            Console.WriteLine("Book 1 subject: {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id: {0}", Book1.book_id);

    
     Console.WriteLine("Book 2 title: {0}", Book2.title);
            Console.WriteLine("Book 2 author: {0}", Book2.author);
            Console.WriteLine("Book 2 subject: {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id: {0}", Book2.book_id); Console.ReadKey();

        }
    } }
