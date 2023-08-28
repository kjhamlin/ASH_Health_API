namespace ASH_HEALTH_API;

public class PatientService : IPatientService
{
    private readonly IPatientRepository patientRepository;
    public PatientService(IPatientRepository _patientRepository)
    {
        patientRepository = _patientRepository;
    }
}