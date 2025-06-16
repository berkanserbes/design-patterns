using FactoryDesignPattern.NotificationAPI.Models;

namespace FactoryDesignPattern.NotificationAPI.Abstracts;

public interface INotificationService
{
	public string Send(string to, string message);
}
