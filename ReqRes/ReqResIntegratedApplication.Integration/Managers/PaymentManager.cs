using ReqresIntegratedApplication.Integration.Entities;
using ReqresIntegratedApplication.Integration.Managers;
using ReqResIntegratedApplication.Integration.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReqResIntegratedApplication.Integration.Managers
{
    public class PaymentManager : GenericManager<Payment>
    {
        public PaymentManager(HttpClient httpClient, string url, Payment requestBody) :
           base(httpClient, url, requestBody)
        {
            _httpClient.DefaultRequestHeaders.Add("x-api-key", "reqres-free-v1");
        }
    }
}
