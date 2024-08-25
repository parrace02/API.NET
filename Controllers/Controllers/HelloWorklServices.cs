using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloworkldController : ControllerBase
{
    IHelloworklService helloworklService;
    public HelloworkldController(IHelloworklService helloWorld)
    {
         helloworklService = helloWorld;
    }
    public IActionResult Get()
    {
        return Ok(helloworklService.GetHelloWorld());
    }
}