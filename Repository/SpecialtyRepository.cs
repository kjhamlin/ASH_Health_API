using Microsoft.EntityFrameworkCore;

namespace ASH_HEALTH_API;
public class SpecialtyRepository : ISpecialtyRepository
{
    private readonly DbContext _dbContext;
    public SpecialtyRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Specialty GetSpecialtyById(int specialtyID)
    {
        var result = _dbContext.Specialties.Where(row => row.specialtyID == specialtyID).First();
        return result;
    }
}