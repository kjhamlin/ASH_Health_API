using Microsoft.AspNetCore.Mvc;

namespace ASH_HEALTH_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientController : ControllerBase
{
    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };

    private readonly ILogger<PatientController> _logger;

    public PatientController(ILogger<PatientController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "")]
    public IEnumerable<Patient> GetPatient()
    {
        throw new NotImplementedException();
    }
}
