using Microsoft.AspNetCore.Mvc;
using OrderService.Api.Models;
using System.Net.Http.Json;

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
            return StatusCode((int)response.StatusCode, "Error al obtener usuario");
        }

        var user = await response.Content.ReadFromJsonAsync<User>();

        if (user == null)
        {
            return NotFound("Usuario no encontrado");
        }

        return Ok(new
        {
            orderId = order.Id,
            product = order.Product,
            user = user
        });
    }
}
