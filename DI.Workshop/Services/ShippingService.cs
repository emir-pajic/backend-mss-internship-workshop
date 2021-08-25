using System;

namespace DI.Workshop.Services
{
    public class ShippingService
    {
        public string ServiceType { get; set; }

        public ShippingService(string serviceType)
        {
            ServiceType = serviceType;
        }

        public void Ship(string addres, string city, string country)
        {
            Console.WriteLine("Shipment to the:" + addres + " " + city + " " + country + " has been ordered via" + ServiceType);
        }
    }
}
