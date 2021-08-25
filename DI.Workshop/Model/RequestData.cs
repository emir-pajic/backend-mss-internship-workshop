using Newtonsoft.Json;

namespace DI.Workshop.Model
{  
    public partial class RequestData
    {

        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("CardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }
    }
}
