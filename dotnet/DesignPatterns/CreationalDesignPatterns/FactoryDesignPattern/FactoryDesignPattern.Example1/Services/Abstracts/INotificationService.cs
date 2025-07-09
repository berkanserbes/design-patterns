using FactoryDesignPattern.NotificationAPI.Models;

namespace FactoryDesignPattern.NotificationAPI.Services.Abstracts;

public interface INotificationService
{
	public string Send(string to, string message);
}
