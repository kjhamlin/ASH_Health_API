namespace ASH_HEALTH_API;

public interface IDoctorRepository
{
    public Doctor GetDoctorById(Guid doctorId);
}