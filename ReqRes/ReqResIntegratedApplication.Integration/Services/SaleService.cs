using ReqresIntegratedApplication.Integration.Managers;
using ReqResIntegratedApplication.Integration.Entities;
using ReqResIntegratedApplication.Integration.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ReqResIntegratedApplication.Integration.Services
{
    public class SaleService
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;

        public SaleService(HttpClient httpClient, string baseUrl)
        {
            _httpClient = httpClient;
            _baseUrl = baseUrl;
        }

        public async Task<Sale> GetAll()
        {
            SaleManager saleManager = new SaleManager(_httpClient, _baseUrl, null);
            return await saleManager.Get();
        }

        public async Task<Sale> GetById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<Dictionary<string, Sale>>($"{_baseUrl}/{id}");
            response.TryGetValue("data", out var sale);
            return sale;
        }

        public async Task<Sale> PostSale(Sale sale)
        {
            SaleManager saleManager = new SaleManager(_httpClient, _baseUrl, sale);
            return await saleManager.Post();
        }

        public async Task<Sale> PutSale(int id, Sale sale)
        {
            SaleManager saleManager = new SaleManager(_httpClient, _baseUrl, sale);
            return await saleManager.Put(id);
        }

        public async Task<Sale> PatchSale(int id, Sale sale)
        {
            SaleManager saleManager = new SaleManager(_httpClient, _baseUrl, sale);
            return await saleManager.Patch(id);
        }
    }
}
