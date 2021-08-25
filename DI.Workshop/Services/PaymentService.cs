using System;

namespace DI.Workshop.Services
{
    public class PaymentService
    {
        public string PaymentType { get; set; }
        public PaymentService(string paymentType)
        {
            PaymentType = paymentType;
        }

        public bool Charge(int amount, string cardNumber)
        {
            Console.WriteLine("Successfully payed " + amount + "$ from " + cardNumber + " via " + PaymentType);
            return true;
        }
    }
}
