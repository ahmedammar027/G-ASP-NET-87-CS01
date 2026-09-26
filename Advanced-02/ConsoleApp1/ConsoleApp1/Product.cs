using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace ConsoleApp1
{
    public class Product
    {
        public Product(int id, string name, string category, double price, int instock)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Stock = instock;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public delegate bool FilterDelegate(Product product);

       public static bool LowStock(Product p)
        {
            if (p.Stock < 20)
            {string result = $" [LOW STOCK] Name: {p.Name} only {p.Stock} left";
                Console.WriteLine(result);
                return true;
            }
            return false;
        }
        public static Predicate<Product> low = LowStock;

        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> filter)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (filter.Invoke(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }


        public static string Summary_List(Product p)
        {
            string result = $"{p.Name}=>{p.Price}";
            return result;
        }
        public static string Price_Label(Product p)
        {
            string result = p.Price>100? "Expensive!": "Affordable";
            return p.Name +"=> "+ result;
        }
        public static Func<Product,string> Summary = Summary_List;

        public static Func<Product,string> Price_l = Price_Label;

        public static void TransformProducts(List<Product> products, Func<Product,string> filter)
        {
            List<string> result = new List<string>();

            foreach (Product product in products)
            {
                string value = filter.Invoke(product); // أو transform(product)
                result.Add(value);
                Console.WriteLine(value);
            }

        }

        public static void Short_Report(Product product)
            {
                Console.WriteLine($"Name ::{product.Name} ::Price:{product.Price}");
            }
        public static void Detailed_Report(Product p)
        {
            Console.WriteLine($"[{p.Category}] Name {p.Name} | Price: ${p.Price} | Stock: {p.Stock}");
        }

        public static Action<Product> Short = Short_Report;
        public static Action<Product> Detailed = Detailed_Report;

        public static void PrintReport(List<Product> products, Action<Product> filter)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                filter.Invoke(product);
               
            }
        }

        public  static FilterDelegate filter(string type)
        {
            return p => p.Category.Equals(type, StringComparison.OrdinalIgnoreCase);
        }

        public  static FilterDelegate filter(int pricee)
        {
            return p => p.Price < pricee;
        }
        public static FilterDelegate instock()
        {
            return p => p.Stock > 0;
        }
        public static FilterDelegate typeandprice(string type,int value)
        {
            return p => p.Category==type&& p.Price<value;
        }

        public static List<Product> Filter (List<Product> products, FilterDelegate filter) {
        List<Product> result = new List<Product>();
            foreach (Product product in products) {
                if (filter.Invoke(product))
                {
                    result.Add(product);
                }
            }
            return result;}
        public override string ToString()
        {
            return $" id is{Id}:: name is {Name}::category is {Category}:: price is {Price} :: in stock {Stock}";
        }

    }
}
