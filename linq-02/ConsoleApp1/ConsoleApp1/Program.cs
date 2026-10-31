using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
{
    new Product { Id = 1,  Name = "Laptop",       Price = 1200.00m, UnitsInStock = 15,  Category = "Electronics"},
    new Product { Id = 2,  Name = "Mouse",        Price = 25.50m,   UnitsInStock = 50,  Category = "Accessories"},
    new Product { Id = 3,  Name = "Keyboard",     Price = 45.00m,   UnitsInStock = 30,  Category = "Accessories"},
    new Product { Id = 4,  Name = "Monitor",      Price = 300.00m,  UnitsInStock = 0,  Category = "Electronics"},
    new Product { Id = 5,  Name = "Headphones",   Price = 85.99m,   UnitsInStock = 25,  Category = "Accessories"},
    new Product { Id = 6,  Name = "Webcam",       Price = 60.00m,   UnitsInStock = 18,  Category = "Electronics"},
    new Product { Id = 7,  Name = "Desk Chair",   Price = 150.00m,  UnitsInStock = 8,   Category = "Furniture"},
    new Product { Id = 8,  Name = "USB Drive",    Price = 15.00m,   UnitsInStock = 100, Category = "Storage" },
    new Product { Id = 9,  Name = "External Hard",Price = 90.00m,   UnitsInStock = 0,  Category = "Storage"},
    new Product { Id = 10, Name = "Microphone",   Price = 110.00m,  UnitsInStock = 12,  Category = "Electronics"},
    new Product { Id = 11, Name = "Smartphone",   Price = 800.00m,  UnitsInStock = 25,  Category = "Electronics"},
    new Product { Id = 12, Name = "Tablet",       Price = 450.00m,  UnitsInStock = 14,  Category = "Electronics"},
    new Product { Id = 13, Name = "Smartwatch",   Price = 200.00m,  UnitsInStock = 35,  Category = "Electronics"},
    new Product { Id = 14, Name = "Printer",      Price = 180.00m,  UnitsInStock = 0,   Category = "Office"}, 
    new Product { Id = 15, Name = "Speaker",      Price = 75.50m,   UnitsInStock = 22,  Category = "Accessories"},
    new Product { Id = 16, Name = "Power Bank",   Price = 35.00m,   UnitsInStock = 40,  Category = "Accessories"},
    new Product { Id = 17, Name = "Router",       Price = 95.00m,   UnitsInStock = 15,  Category = "Networking" },
    new Product { Id = 20, Name = "Graphics Card",Price = 650.00m,  UnitsInStock = 9,   Category = "Electronics"},
                new Product { Id = 18, Name = "Gaming Pad",   Price = 50.00m,   UnitsInStock = 60,  Category = "Accessories"},
    new Product { Id = 19, Name = "VR Headset",   Price = 400.00m,  UnitsInStock = 0,   Category = "Electronics" },
};


            //Q1
            //var result = products.OrderByDescending(n => n.Price).Take(3);


            //Q2 2. show page 2 of products, with page size = 5
            //var result = products.OrderBy(n => n.Name).Skip((2 - 1) * 5).Take(5);

            //Q3 3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = products.OrderBy(n => n.Price).Where(n => n.Price < 25.00m);


            //Q4
            //       var allInStock = products
            //.Where(p => p.Category == "Accessories")
            //.All(p => p.UnitsInStock > 0);

            //       Console.WriteLine(allInStock);



            //Q5

            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);


            //Q6
            //            6.Group all products by Category and print each group with its
            //product count.

            //var groups = products.GroupBy(a => a.Category);
            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1.Name);
            //    }
            //    Console.WriteLine(item.Count());
            //}


            //Q8. Find all categories that have MORE THAN 3 products
            //var groups = products.GroupBy(a => a.Category);
            //var result = groups.Where(o => o.Count() > 3);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key} (Total Products: {group.Count()})");

            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   - {product.Name}"); 
            //    }
            //}


            //Q9
            //var result = from p in products
            //             group p by p.Category into g
            //             select new
            //             {
            //                 Category = g.Key,       
            //                 Products = g.ToList()
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category},{item.Products.Count()}");
            //}


            //Q10
            //var result = products.Sum(p => p.UnitsInStock);

            //Console.WriteLine(result);


            //Q11
            //var result = products.MaxBy(p => p.Price);
            //Console.WriteLine(result);
            // result = products.MinBy(p => p.Price);
            //Console.WriteLine(result);


            //Q12
            //var result = products.Select(p => p.Category).Distinct().ToList();

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}



            //Q13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result=setA.Except(setB);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Q15
            //Dictionary<int, Product> productDict = products.ToDictionary(p => p.Id);

            //if (productDict.TryGetValue(18, out Product product))
            //{
            //    Console.WriteLine($"Found: {product.Name} - Price: {product.Price}");
            //}
            //else
            //{
            //    Console.WriteLine("Product with ID 18 not found.");
            //}


            //Q16
            //var result = products.FirstOrDefault(o => o.Price > 50.00m);
            //Console.WriteLine(result);


            //Q17
            //var result = products.FirstOrDefault(o => o.Price > 50000.00m);
            //Console.WriteLine(result);

            //Q18
            int number = 7;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }



        }
    }
}
