using ReqresIntegratedApplication.Integration.Managers;
using ReqResIntegratedApplication.Integration.Entities;
using System.Net.Http;

namespace ReqResIntegratedApplication.Integration.Managers
{
    public class UserManager : GenericManager<User>
    {
        public UserManager(HttpClient httpClient, string url, User requestBody) :
            base(httpClient, url, requestBody)
        {
            // ReqRes free API requires x-api-key
            _httpClient.DefaultRequestHeaders.Add("x-api-key", "reqres-free-v1");
        }
    }
}
