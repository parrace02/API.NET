using Microsoft.AspNetCore.Mvc;  

namespace webapi.Controllers;  

[ApiController]  
[Route("api/[controller]")]  
public class HelloworkldController : ControllerBase  
{  
    private readonly ILogger<HelloworkldController> _logger;
    
    private readonly IHelloworklService helloworklService; 
    // Combina ambos constructores en uno solo
    public HelloworkldController(ILogger<HelloworkldController> logger, IHelloworklService helloWorld)
    {
        _logger=logger;
        helloworklService = helloWorld; 
    } 
    
    [HttpGet] // Agrega este atributo  
    public IActionResult Get()
     
    {  
        _logger.LogInformation("Get Method Called");
        return Ok(helloworklService.GetHelloWorld());  
    }  
} 