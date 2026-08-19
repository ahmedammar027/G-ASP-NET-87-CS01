using ConsoleApp1.ShipmentTyeps;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*overloading is method do same function with diffrent params
            *overriding is same method do more function 
             */
            #endregion
            #region Q2
            /*static binding use method in ref type(parent) and use hiding method (new) and overloading (new) run in compile time and fast
            *dynamic binding use method in obj type(child) and use override method  run in run time and slow
            */
            #endregion

            StandardShipment s1 = new StandardShipment
                ("001", "laptop", 15, 16, new DeliveryAddress("cairo", "maddi", 12));
            ExpressShipment s2 = new ExpressShipment
                (119, "002", "mobile", 15, 16, new DeliveryAddress("alex", "wardian", 13));
            InternationalShipment s3 = new InternationalShipment
                (15, "matrooh", "003", "tablet", 13, 55, new DeliveryAddress("cairo", "maddi", 12));

            Shipment[] sh = new Shipment[] { s1, s2, s3 };

        DeliveryCenter delivery = new DeliveryCenter(" Ahmed Mohamed",sh);


            delivery.PrintAllShipments();
        
        
        
        
        }
    }
    }
