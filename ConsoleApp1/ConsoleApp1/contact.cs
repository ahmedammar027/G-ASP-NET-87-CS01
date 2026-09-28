using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class contact
    {
        public contact(string name, int phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string name { get; set; }
        public int phone { get; set; }
        public override string ToString()
        {
            return $"name is {name} phone is {phone}";
        }
    }
}
