namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Shipment s1 = new Shipment("001", "phone", 2, 3, new DeliveryAddress("cairo", "jsc", 15));
            //Shipment s2 = new Shipment();
            //s2 = s2.CopyShipment(s1);

            //Console.WriteLine(s1._TrackingCode);
            //Console.WriteLine(s2._TrackingCode); 
            //Console.WriteLine(s1.Destination);
            //Console.WriteLine(s2.Destination);

            //s1._TrackingCode = "10336";
            //s1.Destination =new DeliveryAddress("giza","nlknlkn",19);


            //Console.WriteLine(s1._TrackingCode);
            //Console.WriteLine(s2._TrackingCode);
            //Console.WriteLine(s1.Destination);
            //Console.WriteLine(s2.Destination);
            #endregion
            #region Q2

            //Shipment s1 = new Shipment("001", "phone", 2, 3, new DeliveryAddress("cairo", "jsc", 15));
            //Shipment s2 = new Shipment();
            //s2 = s1.ShallowShipment();

            //Console.WriteLine(s1._TrackingCode);
            //Console.WriteLine(s2._TrackingCode);
            //Console.WriteLine(s1.Destination);
            //Console.WriteLine(s2.Destination);

            //s1._TrackingCode = "10336";
            //s1.Destination.city = "giza";


            //Console.WriteLine(s1._TrackingCode);
            //Console.WriteLine(s2._TrackingCode);
            //Console.WriteLine(s1.Destination);
            //Console.WriteLine(s2.Destination);
            #endregion
            #region Q3
            //Shipment s1 = new Shipment("001", "phone", 2, 3, new DeliveryAddress("cairo", "jsc", 15));
            //Shipment s2 = new Shipment();
            //s2 = s1.DeepShipment();

            //Console.WriteLine(s1._TrackingCode);
            //Console.WriteLine(s2._TrackingCode);
            //Console.WriteLine(s1.Destination);
            //Console.WriteLine(s2.Destination);

            //s1._TrackingCode = "10336";
            //s1.Destination.city = "sharqia";
            //s1.Destination.street = "oroba";
            //s1.Destination.BuildingNumber = 155;


            //Console.WriteLine(s1._TrackingCode);
            //Console.WriteLine(s2._TrackingCode);
            //Console.WriteLine(s1.Destination);
            //Console.WriteLine(s2.Destination);
            #endregion
            Console.WriteLine(Shipment.TotalShipmentsCreated);
            Console.WriteLine(Shipment.GetTotalShipmentsCreated());

            Shipment s1 = new Shipment("001", "phone", 2, 3, new DeliveryAddress("cairo", "jsc", 15));
            DeliveryUtilities.PrintSystemTitle();

            Shipment s2 = new Shipment("002", "labtop", 2, 3, new DeliveryAddress("cairo", "jsc", 15));
            DeliveryUtilities.PrintSystemTitle();
        }
    }
}
