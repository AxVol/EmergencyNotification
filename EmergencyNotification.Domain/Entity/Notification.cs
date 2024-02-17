using EmergencyNotification.Domain.Interfaces;

namespace EmergencyNotification.Domain.Entity;

public class Notification : IEntityId<long>
{
    public long Id { get; set; }
    public string Rate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<User> ForUsers { get; set; }
    public DateTime CreatedAt { get; set; }
    public User Creator { get; set; }
    public long UserId { get; set; }
}