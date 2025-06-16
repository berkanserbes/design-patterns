using FactoryDesignPattern.NotificationAPI.Abstracts;
using FactoryDesignPattern.NotificationAPI.Enums;
using FactoryDesignPattern.NotificationAPI.Models;

namespace FactoryDesignPattern.NotificationAPI.Factories;

public interface INotificationFactory
{
	public INotificationService Create(NotificationType notificationType);
}
