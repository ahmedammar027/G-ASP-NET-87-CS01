using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //     #region Q1
            //Book b1= new Book();
            //     b1.Title = "Design pattern interview";
            //     b1.Pages = 50;
            //     Console.WriteLine(b1);
            //     #endregion
            //     #region Q2
            //     Console.WriteLine(b1.ToString());
            //     Console.WriteLine(b1.Equals(b1));
            //     Console.WriteLine(b1.GetHashCode());
            //     Console.WriteLine(b1.GetType());

            //     #endregion
            //     #region Q3
            //     //  int pages = "464"; compile-time error
            //     string pages = "464";
            //     int x = Convert.ToInt32(pages);
            //     Console.WriteLine(x);
            //     #endregion
            //     #region Q4
            //    int y = 10;
            //    int z = 0;
            //     try {
            //         Console.WriteLine(y / z);

            //     }
            //     catch {
            //         Console.WriteLine("Cannot divide by zero");
            //     }
            //     finally { Console.WriteLine("Done"); }
            //     #endregion
            //     #region Q5 
            //     int pagees = 300;
            //     double p= Convert.ToDouble(pagees);
            //     Console.WriteLine(p);
            //     #endregion
            //     #region Q6
            //     double price = 49.99;
            //     int k = (int)price;
            //     Console.WriteLine(k);
            //     #endregion
            //     #region Q7
            //     string pagesText = "464";
            //     int s=Convert.ToInt32(pagesText);
            //     Console.WriteLine(s);
            //     #endregion
            //     #region Q8
            //     string yearText = "2023";
            //   int r= int.Parse(yearText);
            //     Console.WriteLine(r.GetType());
            //   string badText = "abc";
            //     checked
            //     {
            //         int.TryParse(badText, out int se);
            //     }
            //     unchecked
            //     {
            //         Console.WriteLine("faild to convert");
            //     }
            //     #endregion
            //     #region Q9 
            //     int pagaes = 464;
            //     string pp=pagaes.ToString();
            //     Console.WriteLine(pp);
            //     Console.WriteLine(pp.GetType());
            //     #endregion
            //     #region Q10

            //     int copies = 100;
            //     object obj=(object)copies;
            //     Console.WriteLine(obj);
            //     Console.WriteLine(obj.GetType());

            //     int de=(int)obj;
            //     Console.WriteLine(de);
            //     Console.WriteLine(de.GetType());

            //     #endregion
            //     #region Q11
            //     int? year = null;
            //     if (year.HasValue) {
            //         Console.WriteLine($" year is {year}");
            //     }
            //     else
            //     {
            //         year = 2023;
            //         Console.WriteLine($" year is {year}");
            //     }
            //     #endregion
            //     #region Q12
            //     string? reviewer = null;
            //     if (reviewer==null)
            //     {
            //         Console.WriteLine($" reviewer is null");
            //     }
            //     else
            //     {

            //         Console.WriteLine($" reviewer is {reviewer}");
            //     }

            //     #endregion
            //     #region Q13 
            //      Book? book = null;
            //     Console.WriteLine(book?.Title);


            //     #endregion
            //     #region Q14
            //     Console.WriteLine(book?.Title ?? "Untitled");

            //     book = new Book(); 
            //     book.Title = null; 

            //     book.Title ??= "Untitled";

            //     Console.WriteLine(book.Title);
            //     #endregion
            //     #region Q15
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(name);
            //Console.WriteLine(confirmedName);
            //     #endregion
            Console.WriteLine("enter user name , Age , grade1 , grade2 , grade3");
            string name=Console.ReadLine();
            int Age=int.Parse(Console.ReadLine());
            int grade1 = int.Parse(Console.ReadLine());
            int grade2 = int.Parse(Console.ReadLine());
            int grade3 = int.Parse(Console.ReadLine());
            int total = grade1 + grade2 + grade3;
            int Avg = total / 3;
            String type = "minor";
            Console.WriteLine($"student name is: {name}");
            if (Age>18)
            {
                type = "Adult";
            }
            Console.WriteLine($"student Age is :{Age} : {type}");
            Console.WriteLine($"total grades is: {total}");
            Console.WriteLine($"AVG grades is: {Avg}");
            if (Avg >= 50)
            {
          Console.WriteLine($"status is :pass");


            }
            else
            {
            Console.WriteLine($"status is :faild");


            }
        }
    }
}
