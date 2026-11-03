using Azure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class book
    {
        public int id { get; set; }
        public int ISBN { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public int number_of_pages { get; set; }
        public int published_year { get; set; }
        public int stock { get; set; }
    }
}
