namespace ASH_HEALTH_API;

public interface IDoctorService
{
    public Doctor GetDoctorById(Guid doctorId);
    public IEnumerable<Doctor> GetDoctorsBySpecialty(int SpecialtyID);
}