using System;
using System.Text; 

namespace ConsoleApp1
{
    public class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"book is {title}");
        }
        static void AddBonusPages(int pages)
        {
            pages += 50;
            Console.WriteLine($"pages after afterward is {pages}");
        }
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;

            Console.WriteLine($"pages after refrence is {pages}");
        }
        static double ApplyDiscount(double[] prices)
        {
           return prices[0]-5;
        }
       static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title== "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
               {
                price = 0;
                return false; }
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book: {title}, Pages: {pages}");
        }
       static void PrintAllTitles(string[] titles)
        {
            int i = 1;
            foreach (var item in titles)
            {
                Console.WriteLine($"title[{i}] is {item}");
                i++;
            }
        }
        static void Main(string[] args)
        {
            #region sheet 2
            //#region Q1
            //string title = "clean code";
            //string upper_title =title.ToUpper();
            //Console.WriteLine($"title is :{title}");
            //Console.WriteLine($"upper_title is :{upper_title}");
            //#endregion
            //Console.WriteLine("*********************************");
            //#region Q2
            //string f_string = "Clean Code";
            //string l_string = "Clean Code";
            //bool is_same=object.ReferenceEquals( f_string, l_string );
            //Console.WriteLine(is_same);
            //#endregion
            //Console.WriteLine("*********************************");
            //#region Q3
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List ");
            //sb.Append("-Updated");
            //Console.WriteLine(sb);
            //#endregion
            //Console.WriteLine("*********************************");
            //#region Q4
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            //#endregion
            //Console.WriteLine("*********************************");
            //#region Q5
            //string titlle = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + titlle + " ,pages is " + pages;
            //Console.WriteLine(sentence);
            //#endregion
            //Console.WriteLine("*********************************");
            //#region Q6

            //string sentence2 = $"Book: {titlle} ,pages is {pages}";
            //Console.WriteLine(sentence2);
            //#endregion
            //Console.WriteLine("*********************************");
            //#region Q7

            //string sentence3 =string.Format("Book: {0} ,pages is {1}", title, pages);
            //Console.WriteLine(sentence3);
            //#endregion
            #endregion

            Console.WriteLine("*********************************");

            #region Q1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion

            #region Q2
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q3
            PrintWelcomeMessage();
            #endregion

            #region Q4
            PrintBookTitle("clean code");
            #endregion
            #region Q5
            AddBonusPages(400);
            #endregion
            #region Q6
            double[] pricess = { 25.5, 40.0 }; 
          double result=  ApplyDiscount(pricess);
            Console.WriteLine(result);
            #endregion
            #region Q7
            int p = 500;
            Console.WriteLine($"before ref {p}");
            AddBonusPagesByRef(ref p);
            Console.WriteLine($"after ref {p}");
            #endregion
            #region Q8
            double[] salatys = { 13.6, 15.7};
            Console.WriteLine(salatys[0]);
            Console.WriteLine(salatys.Length);
            ReplaceArray(ref salatys);
            Console.WriteLine(salatys[0]);    
            Console.WriteLine(salatys.Length);
            #endregion
            #region Q9
            PrintBookTitle("clean code");
            #endregion
            #region Q10
            if (TryGetPrice("Clean Code", out double bookPrice))
            {
                Console.WriteLine($"book is found and price is : {bookPrice}");
            }
            else
            {
                Console.WriteLine("book not found");
            }
            #endregion
            #region Q11
            PrintBookInfo("Clean Code");
            PrintBookInfo("Design Patterns", 450);
            #endregion
            #region Q12
            PrintBookInfo(pages:550,title: "Design Patterns");
            #endregion
            #region Q13
            string[] titels = { "Clean Code", "Design Patterns","Clean Architecture" };
            PrintAllTitles(titels);
            #endregion

        }
    }
}