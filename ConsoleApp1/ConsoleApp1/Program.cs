namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<int> grades = [ 85, 92, 78, 95, 88, 70, 100, 65 ];
            // foreach (int item in grades)
            // {
            // Console.WriteLine(item);

            // }
            // Console.WriteLine(grades.Count);
            // Console.WriteLine(grades.Max());
            // Console.WriteLine(grades.Min());
            // grades.Sort();
            // foreach (int item in grades)
            // {
            //     Console.WriteLine(item);

            // }
            //List<int> above90= grades.FindAll(e => e > 90);
            // Console.WriteLine(string.Join(", ", above90));
            // Console.WriteLine("**");
            // List<int> failing = grades.FindAll(a => a < 75);
            // Console.WriteLine(string.Join(", ", failing));
            // Console.WriteLine("**");
            // grades.RemoveAll(e => e < 75);
            // Console.WriteLine(string.Join(", ", grades));
            // Console.WriteLine(grades.Find(e=>e==100));
            // List<string> strings = grades.Select(e => $"Grade: {e}").ToList();

            // foreach (string gradeText in strings)
            // {
            //     Console.WriteLine(gradeText);
            // }








            //Dictionary<int,string> Leaderboard = new Dictionary<int,string>();
            // Leaderboard [500] = "Ahmed";
            // Leaderboard[200] = "Sara";
            // Leaderboard[800] = "Ali";
            // Leaderboard[350] = "Mona";
            // Leaderboard = Leaderboard.OrderByDescending(e => e.Key)
            // .ToDictionary(e => e.Key, e => e.Value);
            // Console.WriteLine(Leaderboard);
            // foreach (KeyValuePair<int,string> item in Leaderboard)
            // {
            //     Console.WriteLine($"key is{item.Key}:: value is {item.Value}");
            // }
            // Console.WriteLine(Leaderboard.FirstOrDefault().Key);
            // Console.WriteLine(Leaderboard.FirstOrDefault().Value);
            // Console.WriteLine(Leaderboard.FirstOrDefault().Key==900);
            // Console.WriteLine(Leaderboard.ContainsKey(500));
            // Leaderboard.Remove(200);
            // foreach (KeyValuePair<int, string> item in Leaderboard)
            // {
            //     Console.WriteLine($"key is{item.Key}:: value is {item.Value}");
            // }





            // List<contact> contacts = new List<contact>();
            // contacts.Add(new contact ( "ahmed", 01111111));
            // contacts.Add(new contact ( "mohamed", 02222222));
            // contacts.Add(new contact ( "ali", 00100000000));
            // contacts.Add(new contact ( "youseff", 00150000000));

            // var contactToUpdate = contacts.FirstOrDefault(c => c.name == "ahmed");
            // if (contactToUpdate != null)
            // {
            //     contactToUpdate.phone = 0123456789;
            //     Console.WriteLine("Contact updated successfully!");
            // }




            // try {
            //     string namme = "mohamed";
            //     int phonee = 02222222;
            //     if (contacts.Any(e=>e.name==namme))
            //     {
            //         throw new InvalidOperationException("Contact already exists!");

            //     }
            //     contacts.Add(new contact ( namme,phonee));
            // }
            // catch (Exception ex){
            //     Console.WriteLine(ex.Message);
            // }

            // try {
            //var result=contacts.Find(e=>e.name== "ali");
            //     if (result == null)
            //     {
            //         throw new InvalidOperationException("cannot find");

            //     }
            //     Console.WriteLine(result);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine(ex.Message);

            // }

            HashSet<string> case_insensitive = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            case_insensitive.Add("ahmed@test.com");
            case_insensitive.Add("AHMED@test.com");
            case_insensitive.Add("Sara@Test.Com");
            case_insensitive.Add("sara@test.com");
            Console.WriteLine(case_insensitive.Count);

            HashSet<int> SetA =[1, 2, 3, 4, 5 ];
            HashSet<int> SetB = [ 4,5,6,7,8];


            HashSet<int> union = new HashSet<int>(SetA);
            union.UnionWith(SetB);
            Console.WriteLine($"UnionWith: {string.Join(", ", union)}");
         
            HashSet<int> intersect = new HashSet<int>(SetA);
            intersect.IntersectWith(SetB);
            Console.WriteLine($"IntersectWith: {string.Join(", ", intersect)}");
          
            HashSet<int> except = new HashSet<int>(SetA);
            except.ExceptWith(SetB);
            Console.WriteLine($"ExceptWith: {string.Join(", ", except)}");
       
            HashSet<int> subSet = [1, 2];
            HashSet<int> fullSetA = new HashSet<int>(SetA);

            bool isSub = subSet.IsSubsetOf(fullSetA);
            Console.WriteLine($"Is {{1,2}} a subset of Set A? {isSub}");




        }
    }
}
