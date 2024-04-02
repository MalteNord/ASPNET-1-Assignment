using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    [HttpGet]

    public IActionResult Get()
    {
        return Ok();
    }
}
