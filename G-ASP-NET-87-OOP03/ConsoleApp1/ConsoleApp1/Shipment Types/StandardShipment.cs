using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Shipment_Types
{
    public class StandardShipment:Shipment
    {
        public StandardShipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress Destination)
            : base(trackingCode, description, weight, deliveryFee, Destination)
        {

        }
       
    }
}
