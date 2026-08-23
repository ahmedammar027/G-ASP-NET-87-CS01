using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ShipmentTypes
{
    internal class ExpressShipment : Shipment,ITrackable,IInsurable
    {
        public ExpressShipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress Destination)
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

        public string GetTrackingStatus()
        {
            return ($"Shipment {_TrackingCode} is Ready.");
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
        public decimal CalculateInsurance()
        {
            return (EstimatedCost * 0.08m);
        }
    }
}
