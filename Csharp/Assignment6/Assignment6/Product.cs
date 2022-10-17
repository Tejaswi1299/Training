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
            try
            {
                double totalBill = 0, salesTax = 0;
                List<Product> productList = getProductList();
                foreach (Product prod in productList)
                {
                    double tax = prod.ComputeSalesTax();
                    salesTax += tax;
                    totalBill += tax + (prod.Quantity * prod.ProductPrice);
                    Console.WriteLine(string.Format("Item = {0} : Quantity = {1} : Price = {2} : Tax = {3}", prod.ProductName, prod.Quantity, prod.ProductPrice + tax, tax));
                }
                Console.WriteLine("Total Tax : " + salesTax);
                Console.WriteLine("Total Bill : " + totalBill);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }



        private static List<Product> getProductList()
        {
            List<Product> lstProducts = new List<Product>();
            //input 1
            lstProducts.Add(new Product("Book", 12.49, 1, ProductType.ExemptedProduct, false));
            lstProducts.Add(new Product("Music CD", 14.99, 1, ProductType.TaxPaidProduct, false));
            lstProducts.Add(new Product("Chocolate Bar", .85, 1, ProductType.ExemptedProduct, false));
            //input 2
            //lstProducts.Add(new Product("Imported Chocolate", 10, 1, ProductType.ExemptedProduct,true));
            //lstProducts.Add(new Product("Imported Perfume", 47.50, 1, ProductType.TaxPaidProduct,true));

            //input 3
            //lstProducts.Add(new Product("Imported Perfume", 27.99, 1, ProductType.TaxPaidProduct,true));
            //lstProducts.Add(new Product("Perfume", 18.99, 1, ProductType.TaxPaidProduct,false));
            //lstProducts.Add(new Product("Headache Pills", 9.75, 1, ProductType.ExemptedProduct,false));
            //lstProducts.Add(new Product("Imported Chocolate", 11.25, 1, ProductType.ExemptedProduct,true));
            return lstProducts;
        }
    }



    public enum ProductType
    {
        ExemptedProduct = 1,
        TaxPaidProduct = 2,
        //ImportedProduct=3
    }



    class Product
    {
        private ProductType _typeOfProduct = ProductType.TaxPaidProduct;
        private string _productName = string.Empty;
        private double _productPrice;
        private int _quantity;
        private bool _isImportedProduct = false;



        public string ProductName { get { return _productName; } }
        public double ProductPrice { get { return _productPrice; } }
        public int Quantity { get { return _quantity; } }



        public Product(string productName, double productPrice, int quantity, ProductType type, bool isImportedProduct)
        {
            _productName = productName;
            _productPrice = productPrice;
            _quantity = quantity;
            _typeOfProduct = type;
            _isImportedProduct = isImportedProduct;
        }

        public double ComputeSalesTax()
        {
            double tax = 0;
            if (_isImportedProduct) //charge 5% tax directly
                tax += _productPrice * .05;
            switch (_typeOfProduct)
            {
                case ProductType.ExemptedProduct: break;
                case ProductType.TaxPaidProduct:
                    tax += _productPrice * .10;
                    break;
            }
            return Math.Round(tax, 2);
            //round result before returning
        }
    }
}