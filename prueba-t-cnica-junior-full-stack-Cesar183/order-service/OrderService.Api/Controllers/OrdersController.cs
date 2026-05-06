using Microsoft.AspNetCore.Mvc;
using OrderService.Api.Models;
using System.Net.Http.Json;

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

        var client = _httpClientFactory.CreateClient("UserService");
        var response = await client.GetAsync($"api/users/{order.UserId}");

        if (!response.IsSuccessStatusCode)
        {
            return StatusCode(500);
        }

        var user = await response.Content.ReadFromJsonAsync<UserDto>();

        return Ok(new
        {
            orderId = order.Id,
            product = order.Product,
            user
        });
    }
}
