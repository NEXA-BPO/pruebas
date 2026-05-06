using Microsoft.AspNetCore.Mvc;
using OrderService.Api.Models;

namespace OrderService.Api.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    public OrdersController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        var order = new Order
        {
            Id = id,
            Product = "Laptop",
            UserId = 1
        };

        var client = _httpClientFactory.CreateClient("UserApi");

        try
        {
            var response = await client.GetAsync($"api/users/{order.UserId}");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, new
                {
                    message = "Error consultando UserService"
                });
            }

            var userJson = await response.Content.ReadAsStringAsync();

            return Ok(new
            {
                orderId = order.Id,
                product = order.Product,
                user = userJson
            });
        }
        catch (HttpRequestException)
        {
            return StatusCode(503, new
            {
                message = "UserService no está disponible"
            });
        }
        catch (TaskCanceledException)
        {
            return StatusCode(504, new
            {
                message = "Tiempo de espera agotado al consultar UserService"
            });
        }
    }
}