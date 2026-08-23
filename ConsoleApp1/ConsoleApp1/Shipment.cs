using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shipment
    {

        private string TrackingCode;
        private string Description;
        private int Weight;
        private int DeliveryFee;

        public DeliveryAddress Destination { get; set; }


        public Shipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress Destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            this.Destination = Destination;
        }

        public Shipment(string trackingCode)
         : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress())
        {
        }






        public abstract decimal EstimatedCost { get; }
        public string _TrackingCode
        {
            get
            {
                return TrackingCode;
            }
            private set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tracking code cannot be empty.");
                }
                TrackingCode = value;
            }

        }


        public string _Description
        {
            get
            {
                return Description;
            }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description cannot be empty.");
                }
                Description = value;
            }

        }


        public int _Weight
        {
            get
            {
                return Weight;
            }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be greater than 0.");
                }
                Weight = value;
            }

        }

        public int _DeliveryFee
        {
            get
            {
                return DeliveryFee;
            }
            private set
            {

                if (0 > value)
                {
                    throw new ArgumentException("DeliveryFee must be greater than 0.");
                }
                DeliveryFee = value;
            }

        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = (int)newFee;
            }
        }
        public void WeightUpdate(int weight)
        {
            Weight = weight;
        }

        public void WeightUpdate(int weight, int extraPackingWeight)
        {
            Weight = weight + extraPackingWeight;
        }
        public abstract void PrintShipment();
    }
}
