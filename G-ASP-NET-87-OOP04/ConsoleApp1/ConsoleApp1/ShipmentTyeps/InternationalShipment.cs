using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ShipmentTyeps
{
    public class InternationalShipment : Shipment
    {

        private string _destinationCountry;
        private decimal _customsFee;

        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("wrong country name", nameof(value));
                }
                _destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "wrong");
                }
                _customsFee = value;
            }
        }

        public InternationalShipment(decimal customsFee, string destinationCountry, string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomsFee = customsFee;
            DestinationCountry = destinationCountry;
        }
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFee;
            }
        }
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
            Console.WriteLine($"DestinationCountry  : {DestinationCountry:C}");
            Console.WriteLine($"CustomsFee  : {CustomsFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
            Console.WriteLine("========================================");

        }
    }
}
