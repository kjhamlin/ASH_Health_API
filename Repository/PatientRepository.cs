using Microsoft.EntityFrameworkCore;

namespace ASH_HEALTH_API;

public class PatientRepository : IPatientRepository
{
    private readonly DbContext dbContext;
    public PatientRepository(DbContext _dbContext)
    {
        dbContext = _dbContext;
    }
}