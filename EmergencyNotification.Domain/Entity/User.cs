using EmergencyNotification.Domain.Interfaces;

namespace EmergencyNotification.Domain.Entity;

public class User : IEntityId<long>
{
    public long Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public IDevice Device { get; set; }
}