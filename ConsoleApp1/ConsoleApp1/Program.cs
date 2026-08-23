using ConsoleApp1.ShipmentTypes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StandardShipment s1 = new StandardShipment
                ("001", "laptop", 15, 16, new DeliveryAddress("cairo", "maddi", 12));
            ExpressShipment s2 = new ExpressShipment
                ("002", "mobile", 15, 16, new DeliveryAddress("cairo", "maddi", 12)); 
            InternationalShipment s3 = new InternationalShipment
                ("003", "tablet", 15, 16, new DeliveryAddress("cairo", "maddi", 12));

            Shipment[] sh ={ s1, s2, s3 };

            DeliveryCenter center = new DeliveryCenter("ahmed", sh);
            center.PrintTrackingStatuses();
            center.PrintCalculateInsurance();


            ITrackable[] trackableShipments = 
{
s1, s2, s3
};

            foreach (ITrackable item in trackableShipments)
            {
                Console.WriteLine(item.GetTrackingStatus());
            }

            IInsurable[] insurableShipments =
{
s1, s2, s3
};

            foreach (IInsurable item in insurableShipments)
            {
                Console.WriteLine(item.CalculateInsurance());
            }
        }
    }
}
