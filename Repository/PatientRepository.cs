using Microsoft.EntityFrameworkCore;

namespace ASH_HEALTH_API;
public class PatientRepository : IPatientRepository
{
    private readonly DbContext _dbContext;
    public PatientRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Patient GetPatient(Guid patientId)
    {
        var result = _dbContext.Patients.Where(row => row.PatientId == patientId).First();
        return result;
    }

    public void AddPatient(Patient patient)
    {
        _dbContext.Add(patient);
        _dbContext.SaveChanges();
    }
}