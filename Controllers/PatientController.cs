using Microsoft.AspNetCore.Mvc;

namespace ASH_HEALTH_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientController : ControllerBase
{
    private readonly ILogger<PatientController> _logger;
    private readonly IPatientService _patientService;

    public PatientController(ILogger<PatientController> logger, IPatientService patientService)
    {
        _logger = logger;
        _patientService = patientService;
    }

    [HttpGet(Name = "GetPatient")]
    public Patient GetPatient(Guid patientId)
    {
        return _patientService.GetPatientById(patientId);
    }
}
