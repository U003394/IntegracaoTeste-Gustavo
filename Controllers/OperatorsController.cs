using Microsoft.AspNetCore.Mvc;

namespace IntegracaoTeste_Gustavo2.Controllers;

[ApiController]
[Route("[controller]")]
public class OperatorsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<OperatorsController> _logger;

    public OperatorsController(ILogger<OperatorsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("multiplicar")]
    public double Multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }
    [HttpGet]
    [Route("divisao")]
    public double Divisao(double n1, double n2)
    {
        return n1 / n2;
    }
}
