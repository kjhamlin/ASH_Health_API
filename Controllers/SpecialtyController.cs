using Microsoft.AspNetCore.Mvc;

namespace ASH_HEALTH_API.Controllers;

[ApiController]
[Route("[controller]")]
public class SpecialtyController : ControllerBase
{
    private readonly ILogger<SpecialtyController> _logger;
    private readonly ISpecialtyService _specialtyService;

    public SpecialtyController(ILogger<SpecialtyController> logger, ISpecialtyService specialtyService)
    {
        _logger = logger;
        _specialtyService = specialtyService;
    }

    [HttpGet(Name = "GetSpecialtyById")]
    public Specialty GetSpecialtyById(int specialtyID)
    {
        return _specialtyService.GetSpecialtyById(specialtyID);
    }
}
