using Microsoft.AspNetCore.Mvc;
using OrderService.Api.Models;

namespace OrderService.Api.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public OrdersController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("UserService");
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

        var response = await _httpClient.GetAsync($"api/users/{order.UserId}");

        if (!response.IsSuccessStatusCode)
        {
            return StatusCode(500);
        }

        var userJson = await response.Content.ReadAsStringAsync();

        return Ok(new
        {
            orderId = order.Id,
            product = order.Product,
            user = userJson
        });
    }
}
