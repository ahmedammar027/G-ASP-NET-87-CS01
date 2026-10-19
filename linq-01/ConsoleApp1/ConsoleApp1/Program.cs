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
            //var result = products.Select(e => new { e.Name, e.Price });


            //Q2
            //var result = products.Select(e => new { e.Name});



            //Q3
            //var result=products.Select(e => new { e.Name, e.Price })
            //    .OrderBy (e=>e.Price) ;


            //Q4
            //var result= products.Select(e => new { e.Name, e.Price })
            //   .Where (e=>e.Price>10 && e.Price<30) ;


            //Q5
            //var result = products.Where(e => e.UnitsInStock > 0 && e.Category == "Accessories");



            //Q6
            //var result = products.Select(e => new { e.Name, e.Price , e.Category, e.StockStatus });


            //Q7
            //var result = products.Select((p, index) => $"{index + 1}. {p.Name}");


            //Q8
            //var result=products.OrderBy(p => p.Category)
            //    .OrderByDescending(e=>e.Price);


            //Q9
            //var result = products.Where(e => e.Category == "Electronics")
            //    .OrderByDescending(e => e.UnitsInStock);

            //Q11
            //var result = products.Select((p, index) => $"{index + 1}. {p.Name}");


            //Q12
            String[] Arr = { "aPPLE", "AiAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            List<string> strings = Arr.ToList();
            //var result = strings.OrderBy(s => s.Length)
            //    .ThenBy(s => s, StringComparer.OrdinalIgnoreCase);


            //Q13
            var result = strings.Where(d => d[1] == 'i')
                .Reverse();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
