using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReqresIntegratedApplication.Integration.Services;
using ReqResIntegratedApplication.Integration.Services;

namespace ReqResIntegratedApplication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://reqres.in/api/user";

        public PaymentController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            PaymentService paymentService = new PaymentService(_httpClient, _baseUrl);
            var result = await paymentService.Get();
            return Ok(result);
        }
    }
}
