using AspNetCore.GrpcServiceDemo.Protos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCore.GrpcClientDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Order.OrderClient _orderClient;

        public WeatherForecastController(Order.OrderClient orderClient)
        {
            _orderClient = orderClient;
        }

        [HttpGet]
        public async Task<dynamic> Get()
        {
            var result = await _orderClient.CreateOrderAsync(new CreateOrderRequest
            {
                ItemCode = "123",
                ItemName = "名称1"
            });

            return result;
        }
    }
}
