namespace ASH_HEALTH_API;

public class Patient
{
    public Guid PatientId { get; set; }
    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public int PrimaryCareID { get; set; }
}
