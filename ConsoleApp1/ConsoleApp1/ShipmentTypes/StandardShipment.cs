using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ShipmentTypes
{
    internal class StandardShipment : Shipment,ITrackable,IInsurable
    {
        public StandardShipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress Destination)
            : base(trackingCode, description, weight, deliveryFee, Destination)
        {
        }

        public override decimal EstimatedCost
        {
            get
            {
                 return _DeliveryFee + (_Weight * 5); 
                
            }
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
        public string GetTrackingStatus()
        {
            return ($"Shipment {_TrackingCode} is has been Delivered.");
        }

        public decimal CalculateInsurance()
        {
            return (EstimatedCost * 0.05m);
        }
    }
}
