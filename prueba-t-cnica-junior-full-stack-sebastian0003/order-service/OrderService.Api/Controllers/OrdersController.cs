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
            
        var user = await _httpClient.GetFromJsonAsync<UserDto>(
                $"/api/users/{order.UserId}"
        );

        if (user == null)
        {
            return StatusCode(500, "Usuario no encontrado");
        }

            
        return Ok(new
        {
            orderId = order.Id,
            product = order.Product,
            user = new
            {
                id = user.Id,
                nombre = user.Nombre,
                email = user.Email
            }
        });
    }
}
