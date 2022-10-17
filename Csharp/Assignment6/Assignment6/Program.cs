using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Create a class called Books with BookName and AuthorName members. Instantiate the class through constructor
    and also write a method Display() to display the details. Create an Indexer of Books Object to store 5 books in a class called BookShelf.
    Using the indexer method assign values to the books and display the same.

(Hint : Use Composition.Books object inside BookShelf class)*/

namespace Assignment6
{
    class Books
    {
        string[] Bookname = new string[5];
        string[] Authorname = new string[5];

        //public Books(string bookname, string authorname)
        //{
        //    BookName = bookname;
        //    AuthorName = authorname;
        //}
        public void Display()
        {
           // Console.WriteLine(B[0] + " " + B[1] + " " + B[2]);
            Console.Read();
        }

        public string this[int flag]
        {
            get { string temp = Bookname[flag]; return temp; }
            set { Bookname[flag] = value; }
        }
        public string this[string Authorname]
        {
            get { return Authorname; }
            set { Authorname = value; }
        }

    } 
    public class BookShelf
    {
        public static void Main(string[] args)
        {
            
            Books B = new Books();
            Console.WriteLine("Book names");
            B[0] = "a";
            B[1] = "b";
            B[2] = "c";
            B[3] = "d";
            B[4] = "e";
            Console.WriteLine(B[0] + " " + B[1] + " " + B[2]);

            Console.WriteLine("Author names");
            B[0] = "aaaa";
            B[1] = "bsss";
            B[2] = "cffg";
            B[3] = "dddd";
            B[4] = "eddfef";
            Console.WriteLine(B[0] + " " + B[1] + " " + B[2]);
            B.Display();
            
            Console.Read();
        }
    }
}

