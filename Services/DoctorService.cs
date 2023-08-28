namespace ASH_HEALTH_API;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    public DoctorService(DoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public Doctor GetDoctorById(Guid doctorId)
    {
        return _doctorRepository.GetDoctorById(doctorId);
    }

    public IEnumerable<Doctor> GetDoctorsBySpecialty(int SpecialtyID)
    {
        return _doctorRepository.GetDoctorsBySpecialty(SpecialtyID);
    }
}