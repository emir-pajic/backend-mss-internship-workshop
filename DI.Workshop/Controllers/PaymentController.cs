using DI.Workshop.Model;
using DI.Workshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI.Workshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService paymentService = new PaymentService("Paypal");

        private readonly ShippingService shippingService = new ShippingService("Fedex");

        [HttpGet]
        public string Get()
        {
            return ("Application working...");
        }
       
        [HttpPost]
        public string Post([FromBody] RequestData data)
        {
           if( paymentService.Charge(data.Amount, data.CardNumber))
           {
                shippingService.Ship(data.Address, data.City, data.Country);
           }
           return ("Ok");
        }       
    }
}
