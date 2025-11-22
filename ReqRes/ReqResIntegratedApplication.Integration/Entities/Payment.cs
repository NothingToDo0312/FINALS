using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ReqResIntegratedApplication.Integration.Entities
{
    public class Payment
    {
        [JsonPropertyName("hasPaid")]
        public bool HasPaid { get; set; } = true;

        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; } = "VISA";

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; } = true;
    }
}
