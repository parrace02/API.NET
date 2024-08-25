using Microsoft.AspNetCore.Mvc;  

namespace webapi.Controllers;  

[ApiController]  
[Route("api/[controller]")]  
public class HelloworkldController : ControllerBase  
{  
    private readonly IHelloworklService helloworklService;  

    public HelloworkldController(IHelloworklService helloWorld)  
    {  
        helloworklService = helloWorld;  
    }  

    [HttpGet] // Agrega este atributo  
    public IActionResult Get()  
    {  
        return Ok(helloworklService.GetHelloWorld());  
    }  
} 