using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Shipment_Types
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
    }
}
