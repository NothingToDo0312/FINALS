using ReqresIntegratedApplication.Integration.Managers;
using ReqResIntegratedApplication.Integration.Entities;
using ReqResIntegratedApplication.Integration.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ReqResIntegratedApplication.Integration.Services
{
    public class UserService
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;

        public UserService(HttpClient httpClient, string baseUrl)
        {
            _httpClient = httpClient;
            _baseUrl = baseUrl;
        }

        public async Task<List<UserData>> GetAll()
        {
            UserManager userManager = new UserManager(_httpClient, _baseUrl, null);
            var result = await userManager.Get();
            return result?.Data ?? new List<UserData>();
        }

        public async Task<UserData> GetById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<Dictionary<string, UserData>>($"{_baseUrl}/{id}");
            response.TryGetValue("data", out var user);
            return user;
        }

        public async Task<User> PostUser(User user)
        {
            UserManager userManager = new UserManager(_httpClient, _baseUrl, user);
            return await userManager.Post();
        }

        // PUT a user
        public async Task<User> PutUser(int id, User user)
        {
            UserManager userManager = new UserManager(_httpClient, _baseUrl, user);
            return await userManager.Put(id);
        }

        // PATCH a user
        public async Task<User> PatchUser(int id, User user)
        {
            UserManager userManager = new UserManager(_httpClient, _baseUrl, user);
            return await userManager.Patch(id);
        }
    }
}