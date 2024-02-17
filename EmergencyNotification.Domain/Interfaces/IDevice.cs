using EmergencyNotification.Domain.Entity;

namespace EmergencyNotification.Domain.Interfaces;

public interface IDevice
{
    public void SendNotification(Notification notifcation);
}