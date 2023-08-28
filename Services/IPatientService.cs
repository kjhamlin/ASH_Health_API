namespace ASH_HEALTH_API;

public interface IPatientService
{
    public Patient GetPatientById(Guid patientId);
    public void AddPatient(Patient patient);
}