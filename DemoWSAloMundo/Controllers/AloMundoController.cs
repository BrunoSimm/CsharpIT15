using Microsoft.AspNetCore.Mvc;

namespace DemoWSAloMundo.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class AloMundoController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<AloMundoController> _logger;

    public AloMundoController(ILogger<AloMundoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "Alo Mundo!";
    }

    [HttpGet("{nome}")] // /api/v1/alomundo/{nome}
    public string GetByNome(string nome) // pega pelo path variable
    {
        return $"Olá, {nome}!";
    }

    [HttpGet("query")] // /api/v1/alomundo/query?nome={nome}
    public string GetByNomeQuery([FromQuery] string nome) //Pega pega query string
    {
        return $"Olá, {nome}!";
    }

    [HttpPost]
    public string Post([FromBody] string nome)
    {
        return $"Olá, {nome}!";
    }
}
