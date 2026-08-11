namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            #region a
            /*  class=>ref type,store ref in heap,support inheritance,provide defult constractor
             *  struct=> value type,store value in stack,dont support inheritance,always exist parameterless constractor
             */
            #endregion
            #region b
            /*  because it support inheritance , complex data with behavior , shared state
             *  but struct good at small data,good performance
             */
            #endregion
            #endregion
            #region Q2
            #region a
            /*  parent is shipment
             */
            #endregion
            #region b
            /*  child is expressshimpment
             */
            #endregion
            #region c
            /*  one=>traking code
             */
            #endregion
            #region d
            /*  because it Easier Maintenance & Bug Fixing
             *  Don't Repeat vode
             *  High Extensibility & Scalability
             *  Enables Polymorphism
             */
            #endregion
            DeliveryAddress deliveryAddress = new DeliveryAddress("cairo","tessin",15);
            Shipment s1=new Shipment("a101","phone",1,15,deliveryAddress);
            Shipment s2=new Shipment("a102","laptop",3,50,deliveryAddress);
            Shipment s3=new Shipment("a103","tv",4,15,deliveryAddress);
            Shipment s4=new Shipment("a104","airfraier",1,15,deliveryAddress);


            DeliveryCenter deliveryCenter=new DeliveryCenter("cairo",new Shipment[]{ s1,s2,s3,s4});

            deliveryCenter[1].PrintShipment();


            #endregion
        }
    }
    }
