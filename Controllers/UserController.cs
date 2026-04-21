using Microsoft.AspNetCore.Mvc;

namespace minha_primeira_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Gabriel");
    }
}
