namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new List<Product>()
{
    new Product ( 1, "Laptop", "Electronics", 12000.0, 0 ),
    new Product (2,"Phone", "Electronics", 800, 25 ),
    new Product ( 3, "T-Shirt","Clothing", 30, 100 ),
    new Product ( 4, "Jeans", "Clothing", 60, 50 ),
    new Product ( 5,"Chocolate", "Food", 5, 200 ),
    new Product ( 6, "Coffee Beans","Food", 15, 80 ),
    new Product ( 7, "C# Book", "Books", 45, 30 ),
    new Product ( 8, "Novel","Books", 20, 60 ),
    new Product ( 9,"Headphones", "Electronics", 150,40 ),
    new Product (10, "Jacket","Clothing", 120, 15 )
};

            List<Product> Result = Product.Filter(catalog, Product.typeandprice("Clothing", 100));
            foreach (Product item in Result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************************");
            Result = Product.Filter(catalog, Product.filter(100));
            foreach (Product item in Result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************************");
            Result = Product.Filter(catalog, Product.filter("Electronics"));
            foreach (Product item in Result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********************************");
            Result = Product.Filter(catalog, Product.instock());
            foreach (Product item in Result)
            {
                Console.WriteLine(item);
            }

            Product.PrintReport(catalog, Product.Short);
            Console.WriteLine("*********************************");

            Product.PrintReport(catalog, Product.Detailed);
            Console.WriteLine("*********************************");

            Product.TransformProducts(catalog, Product.Summary);
            Console.WriteLine("*********************************");

            Product.TransformProducts(catalog, Product.Price_Label);
            Console.WriteLine("*********************************");


            Result = Product.FilterProducts(catalog, Product.low);
           
        }
    }
}
