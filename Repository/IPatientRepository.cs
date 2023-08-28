namespace ASH_HEALTH_API;

public interface IPatientRepository
{
    public Patient GetPatient(Guid patientId);
}