using ConsoleApp1.ShipmentTypes;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class DeliveryReport
    {
      public string PrintShipment(ITrackable shipment)
        {
          return  shipment.GetTrackingStatus();
        }
public decimal PrintInsurance(IInsurable shipment)
        {
            return shipment.CalculateInsurance();

        }





    }
}
