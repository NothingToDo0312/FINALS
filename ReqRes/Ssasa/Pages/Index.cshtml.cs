using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReqresIntegratedApplication.Integration.Entities;

namespace Ssasa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:7287/api/User";

        public List<UserData> Users { get; set; } = new List<UserData>();

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task OnGetAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<User>(_baseUrl);
            Users = response?.Data ?? new List<UserData>();
        }
    }
}
