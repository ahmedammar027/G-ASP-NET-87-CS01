using System;
using System.Collections.Generic;

using System.Text;
namespace ConsoleApp1
{
    public class Shipment
    {

        private string TrackingCode;
        private string Description;
        private int Weight;
        private int DeliveryFee;
        public static int TotalShipmentsCreated=0;
        public DeliveryAddress Destination { get; set; }


        public Shipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress Destination)
        {
            TotalShipmentsCreated++;
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            this.Destination = Destination;
        }

        //public Shipment(string trackingCode)
        // : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress())
        //{
        //}
        public Shipment()
        {
            TotalShipmentsCreated++;

        }

        static Shipment()
        {
            Console.WriteLine("initialization has happened.");
        }




        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }
        public string _TrackingCode
        {
            get
            {
                return TrackingCode;
            }
            set
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
        public void PrintShipment()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("           SHIPMENT DETAILS             ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} kg");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee:C}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
            Console.WriteLine("========================================");
        }
       public Shipment CopyShipment(Shipment s1)
        {
            return s1;
        }

        public Shipment ShallowShipment()
        {
            return (Shipment) MemberwiseClone();
        }
        public Shipment DeepShipment()
        {
            Shipment copy=(Shipment) MemberwiseClone();
            copy.Destination=new DeliveryAddress(Destination.city,Destination.street,Destination.BuildingNumber);
            return copy;
        }

       public static int GetTotalShipmentsCreated()
        {
            return (TotalShipmentsCreated);
        }

    }
}
