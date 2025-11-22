using Microsoft.AspNetCore.Mvc.RazorPages;
using ReqresIntegratedApplication.Integration.Entities;
using System.Net.Http;
using System.Net.Http.Json;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:7287/api/users";

        public List<ResourceData> resource { get; set; } = new List<ResourceData>();


        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task OnGetAsync()
        {
            // Get the paged response
            var response = await _httpClient.GetFromJsonAsync<Resource>(_baseUrl);

            // Flatten data
            resource = response?.Data ?? new List<ResourceData>();
        }
    }
}
