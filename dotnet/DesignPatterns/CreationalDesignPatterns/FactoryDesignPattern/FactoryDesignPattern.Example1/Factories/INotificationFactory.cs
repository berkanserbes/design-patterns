using FactoryDesignPattern.NotificationAPI.Enums;
using FactoryDesignPattern.NotificationAPI.Services.Abstracts;

namespace FactoryDesignPattern.NotificationAPI.Factories;

public interface INotificationFactory
{
	public INotificationService Create(NotificationType notificationType);
}
