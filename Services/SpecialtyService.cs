namespace ASH_HEALTH_API;

public class SpecialtyService : ISpecialtyService
{
    private readonly ISpecialtyRepository _specialtyRepository;
    public SpecialtyService(ISpecialtyRepository specialtyRepository)
    {
        _specialtyRepository = specialtyRepository;
    }

    public Specialty GetSpecialtyById(int specialtyID)
    {
        return _specialtyRepository.GetSpecialtyById(specialtyID);
    }
}