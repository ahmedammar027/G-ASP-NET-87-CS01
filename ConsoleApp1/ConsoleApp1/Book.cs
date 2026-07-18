using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Book
    {

        
        public string Title { get; set; }
        public int Pages { get; set; }
        public override string ToString()
        {
            return $"Title: {Title} \n, Pages: {Pages}";
        
    }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
}
}
