namespace ASH_HEALTH_API;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;
    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public void AddPatient(Patient patient)
    {
        _patientRepository.AddPatient(patient);
    }

    public Patient GetPatientById(Guid patientId)
    {
        return _patientRepository.GetPatient(patientId);
    }
}