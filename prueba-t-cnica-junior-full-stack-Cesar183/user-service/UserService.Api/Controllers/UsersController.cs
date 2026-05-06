using Microsoft.AspNetCore.Mvc;
using UserService.Api.Models;

namespace UserService.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        var user = new User
        {
            Id = id,
            Nombre = "Juan",
            Email = "juan@mail.com"
        };

        return Ok(user);
    }
}