using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controllers;

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

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return "Falle";
    }

    [HttpPost(Name = "GetWeatherForecast")]
    public string Post(string nome)
    {
        if(nome == "Fall")
        {
            return "ok";
        }
        else if (nome == "le")
        {
            return "testado";
        }
        return "Nome inválido";

    }
}
