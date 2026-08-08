using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public struct DeliveryAddress
    {
        public DeliveryAddress(string city, string street, int BuildingNumber)
        {
            this.city = city;
            this.street = street;
           this.BuildingNumber = BuildingNumber;
        }

        public string city { get; set; }
        public string street { get; set; }
        public int BuildingNumber { get; set; }


 
        public string GetFullAddress() {

            return($" city is : {city} street is : {street} BuildingNumber is : {BuildingNumber}");
        }

    }
}
