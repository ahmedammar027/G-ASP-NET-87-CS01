using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ShipmentTyeps
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress Destination)
            : base(trackingCode, description, weight, deliveryFee, Destination)
        {

        }
        public override decimal EstimatedCost => base.EstimatedCost;
        public override void PrintShipment()
        {

            Console.WriteLine("========================================");
            Console.WriteLine("           SHIPMENT DETAILS             ");
            Console.WriteLine("========================================");
            Console.WriteLine($"order type is : {this.GetType().Name}");

            Console.WriteLine($"Tracking Code : {_TrackingCode}");
            Console.WriteLine($"Description   : {_Description}");
            Console.WriteLine($"Weight        : {_Weight} kg");
            Console.WriteLine($"Delivery Fee  : {_DeliveryFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
            Console.WriteLine("========================================");

        }
    }
}
