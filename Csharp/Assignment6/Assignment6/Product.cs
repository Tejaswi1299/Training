using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.Create a Class called Products with Productid, Product Name, Price.
    Accept 10 Products, sort them based on the price, and display the sorted Products*/
namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = getProductList();
            var res = productList.OrderBy(c => c.ProductPrice).ThenBy(c => c);
            foreach (Product prod in res)
            {
               Console.WriteLine(string.Format("ItemName: {0},  Price: {1}, ProductId: {2}", prod.ProductName, prod.ProductPrice, prod.ProductId));
            }
            Console.ReadLine();
        }

        private static List<Product> getProductList()
        {
            List<Product> lstProducts = new List<Product>();

            lstProducts.Add(new Product("Books", 1400, 1));
            lstProducts.Add(new Product("Music CD", 200, 2));
            lstProducts.Add(new Product("Chocolate Bar", 120, 3));
            lstProducts.Add(new Product("Biscuits", 400, 4));
            lstProducts.Add(new Product("Veggies", 300, 5));
            lstProducts.Add(new Product("Nuggets", 160, 6));
            lstProducts.Add(new Product("Clothes", 15000, 7));
            lstProducts.Add(new Product("Maggie", 500, 8));
            lstProducts.Add(new Product("Shoes", 900, 9));
            lstProducts.Add(new Product("Coke Tins", 450, 10));

            return lstProducts;
        }
    }

    class Product
    {
        private int _productid;
        private string _productName = string.Empty;
        private double _productPrice;

        public int ProductId { get { return _productid; } }
        public string ProductName { get { return _productName; } }
        public double ProductPrice { get { return _productPrice; } }

        public Product(string productName, double productPrice, int productId)
        {
            _productName = productName;
            _productPrice = productPrice;
            _productid = productId;
        }


    }
}