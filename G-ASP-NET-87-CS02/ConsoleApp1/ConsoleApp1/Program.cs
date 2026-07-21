using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int pages = 464;
            string result = pages > 464 ? "Long Book" : "Short Book";
            Console.WriteLine(result);

            #endregion
            Console.WriteLine("****************************************");

            #region Q2
            int paages = 464;
            bool isAvailable = true;
            if (paages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            { Console.WriteLine("0"); }
            #endregion
            Console.WriteLine("****************************************");

            #region Q3
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            Console.WriteLine("****************************************");

            #region Q4
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"number {i + 1} is : {books[i]}");
            }

            #endregion
            Console.WriteLine("****************************************");

            #region Q5
            int x = 0;
            while (x< books.Length)
            {
                Console.WriteLine($"number {x + 1} is : {books[x]}");
                x++;

            }
            #endregion
            Console.WriteLine("****************************************");

            #region Q6
            int z = 0;
            do
            {
                Console.WriteLine($"Checking book....");
                z++;
            }
            while (z<3);
            #endregion
            Console.WriteLine("****************************************");

            #region Q7
            foreach (var item in books)
            {
                Console.WriteLine($"book title is : {item}");
            }


            #endregion
            Console.WriteLine("****************************************");

            #region Q8
            foreach (var item in books)
            {
                if (item== "Refactoring")
                {
                    break;
                }
                Console.WriteLine($"book title is : {item}");
            }

            #endregion
            Console.WriteLine("****************************************");
            #region Q9
            foreach (var item in books)
            {
                if (item == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine($"book title is : {item}");

            }

            #endregion




        }
    }
}
