using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Category { get; set; }
        public string StockStatus => UnitsInStock > 0 ? "Available" : "Out of Stock";
    
        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Price: ${Price} : UnitsInStock {UnitsInStock} : category {Category} : StockStatus {StockStatus}";
        }
    }
}
