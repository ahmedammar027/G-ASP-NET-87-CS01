namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //a
            //copy have a modefied data but original variable don't change because struct is value type and store value in stack only 
            //b
            //copy have a modefied data and original variable will change to new data because class is refrence type hava address in satck and refrence in heap so 2 variables have same refrence 
            #endregion
            #region Q2
            //a
            //variabels are public so it can access by any one and give it any value
            //b
            //we can create public method set to asign value the private member and make get to get value  
            #endregion
            #region part 2
            DeliveryAddress d1 = new DeliveryAddress("cairo","tes3in",13);
            DeliveryAddress d2 = new DeliveryAddress();
            d2 = d1;
            d2.city = "maadi";
            //d1.GetFullAddress();
            //d2.GetFullAddress();
            #endregion
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            DeliveryAddress address = new DeliveryAddress("cairo","maadi",19);
            Shipment sh1=new Shipment("sh101", "laptop", 3, 50,address);
            Shipment sh2=new Shipment("sh102", "mobile", 1, 20, address);
            Shipment sh3=new Shipment("sh103", "tv", 10, 200, address);

            deliveryCenter.AddShipment(sh1);
            deliveryCenter.AddShipment(sh2);
            deliveryCenter.AddShipment(sh3);
            deliveryCenter[0].PrintShipment();
            // البحث عن شحنة الموبايل بكودها وطباعتها
            Shipment searched = deliveryCenter["sh102"];
            searched.PrintShipment();
            Console.WriteLine("*************************************************");
            var x = deliveryCenter[0];
            Console.WriteLine(x._TrackingCode);
            Console.WriteLine(x._Description);
        }
    }
    }
