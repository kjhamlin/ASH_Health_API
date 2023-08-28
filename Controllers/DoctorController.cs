using Microsoft.AspNetCore.Mvc;

namespace ASH_HEALTH_API.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private readonly ILogger<DoctorController> _logger;
    private readonly IDoctorService _doctorService;

    public DoctorController(ILogger<DoctorController> logger, IDoctorService doctorService)
    {
        _logger = logger;
        _doctorService = doctorService;
    }

    [HttpGet(Name = "GetDoctor")]
    public Doctor GetDoctor(Guid doctorId)
    {
        return _doctorService.GetDoctorById(doctorId);
    }
}
