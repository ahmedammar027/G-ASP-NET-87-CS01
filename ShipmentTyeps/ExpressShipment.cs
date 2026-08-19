using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ShipmentTyeps
{

    public class ExpressShipment : Shipment
    {
        private decimal _extraFee;

        public virtual decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "wrong");
                }
                _extraFee = value;
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
            Console.WriteLine($"extra fees  : {_extraFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
            Console.WriteLine("========================================");
        
        }

        public ExpressShipment(decimal extraFee, string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }
        
    }

}
