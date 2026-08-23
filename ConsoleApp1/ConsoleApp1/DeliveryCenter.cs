using ConsoleApp1.ShipmentTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    internal class DeliveryCenter
    {

        public string CenterName { get; set; }
        private Shipment[] Shipments { get; set; }

        public DeliveryCenter(string centerName, Shipment[] shipments)
        {
            CenterName = centerName;
            Shipments = shipments ?? new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < Shipments?.Length)
                {
                    return Shipments[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < Shipments?.Length)
                {
                    Shipments[index] = value;
                }
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (Shipments == null || shipment == null)
            {
                return false;
            }

            for (int i = 0; i < Shipments.Length; i++)
            {

                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            if (Shipments == null || string.IsNullOrWhiteSpace(trackingCode))
                return false;

            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null && Shipments[i]._TrackingCode == trackingCode)
                {
                    Shipments[i] = null;
                    return true;
                }
            }

            return false;
        }
        public void PrintAllShipments()
        {
            foreach (Shipment s in Shipments)
            {
                s.PrintShipment();
            }
        }
        public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in Shipments)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }

        }
        public void PrintCalculateInsurance()
        {
            foreach (IInsurable t in Shipments)
            {
                Console.WriteLine(t.CalculateInsurance());
            }

        }
    }
}
