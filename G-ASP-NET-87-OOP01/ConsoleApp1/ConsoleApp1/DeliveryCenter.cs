using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    public struct DeliveryCenter
    {
        private Shipment[]? Shipments;
        public DeliveryCenter()
        {
            Shipments = new Shipment[10];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < Shipments?.Length)
                {
                    return Shipments[index];
                }
                return default(Shipment);

            }
            set
            {
                if (index >= 0 && index < Shipments?.Length)
                {
                    Shipments[index] = value;
                }
                else
                    return;
            }

        }
        public Shipment this[string name]
        {
            get
            {
                if (Shipments !=null)
                {
                    for (int i = 0; i < Shipments.Length; i++)
                    {
                        if (Shipments[i]._TrackingCode == name)
                        {
                            return Shipments[i];
                        }

                    }
                }
                    return default;
            }

        }
        
        public bool AddShipment(Shipment shipment)
        {
            if (Shipments == null)
            {
                return false;
            }
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(Shipments[i]._TrackingCode))
                {
                    Shipments[i] = shipment; 
                    return true;              
                }
            }

            return false;


        }

    }
}

