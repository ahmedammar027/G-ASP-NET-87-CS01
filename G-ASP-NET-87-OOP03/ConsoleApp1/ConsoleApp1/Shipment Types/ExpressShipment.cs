using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Shipment_Types
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace ConsoleApp1.Shipment_Types
    {
        public class ExpressShipment : Shipment
        {
            private decimal _extraFee;

            public decimal ExtraFee
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
}
