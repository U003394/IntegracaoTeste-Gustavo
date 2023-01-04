using Microsoft.AspNetCore.Mvc;

namespace IntegracaoTeste_Gustavo2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("multiplicar")]
    public double multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }
    [HttpGet]
    [Route("divisao")]
    public double divisao(double n1, double n2)
    {
        return n1 / n2;
    }
}
