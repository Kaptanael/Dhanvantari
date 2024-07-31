namespace Patient.Api.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Home")]
    public IActionResult Home()
    {
        return Ok("Home");
    }
}
