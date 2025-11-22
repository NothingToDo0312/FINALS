using ReqResIntegratedApplication.Integration.Entities;
using ReqResIntegratedApplication.Integration.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ReqResIntegratedApplication.Integration.Services
{
    public class PaymentService
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;

        public PaymentService(HttpClient httpClient, string baseUrl)
        {
            _httpClient = httpClient;
            _baseUrl = baseUrl;
        }

       public async Task<Payment?> Get()
        {
            return await _httpClient.GetFromJsonAsync<Payment>(_baseUrl);
        }
    }
}
