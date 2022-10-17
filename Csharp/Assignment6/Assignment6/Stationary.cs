using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.Create a simple Stationery application to add items and display added items using Generic List collections
namespace Assignment6
{
    public class Author
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public double Price { get; set; }
        public string AuthorDetails()
        {
            return string.Format("{0} is an author of {1}. Price: ${2}", Name, Book, Price);
        }
    }
    class Stationery
    {
        public static void Display()
        {
            List<int> numbers = new List<int>(5) { 5, 10, 15, 20, 25 };
            // Add more items to List
            numbers.Add(30);
            numbers.Add(35);
            numbers.Add(40);

            foreach (int num in numbers)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine();
            List<string> names = new List<string>() { "Mahesh Chand", "Neel Beniwal", "Chris Love" };

            // Add more items to the list
            names.Add("Author One");
            names.Add("Author Two");

            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }
            Console.WriteLine();

            // Create a List of objects
            List<Author> authors = new List<Author>
            {
            new Author { Name = "Mahesh Chand", Book = "ADO.NET Programming", Price = 490},
            new Author { Name = "Neel Beniwal", Book = "Jump Ball", Price = 190 },
            };
            // Add more items to the list
            authors.Add(new Author { Name = "Mahesh Chand", Book = "Graphics with GDI+", Price = 500 });
            authors.Add(new Author { Name = "Mahesh Chand", Book = "Mastering C#", Price = 540 });
            foreach (Author author in authors)
            {
                Console.WriteLine($"Author: {author.Name}: book:{author.Book}: Price: {author.Price}");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello List!");
            Display();
        }

    }
}
