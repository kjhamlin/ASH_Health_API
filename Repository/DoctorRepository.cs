using System.Data;
using Microsoft.EntityFrameworkCore;

namespace ASH_HEALTH_API;
public class DoctorRepository : IDoctorRepository
{
    private readonly DbContext _dbContext;
    public DoctorRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Doctor GetDoctorById(Guid doctorId)
    {
        var result = _dbContext.Doctors.Where(row => row.Id == doctorId).First();
        return result;
    }

    public IEnumerable<Doctor> GetDoctorsBySpecialty(int SpecialtyID)
    {
        var result = _dbContext.Doctors.Where(RowNotInTableException => row.SpecialtyID == SpecialtyID);
        return result;
    }
}