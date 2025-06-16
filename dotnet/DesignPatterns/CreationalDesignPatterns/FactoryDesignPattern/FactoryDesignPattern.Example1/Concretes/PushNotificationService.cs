using FactoryDesignPattern.NotificationAPI.Abstracts;
using FactoryDesignPattern.NotificationAPI.Models;

namespace FactoryDesignPattern.NotificationAPI.Concretes;

public class PushNotificationService : INotificationService
{
	public string Send(string to, string message)
	{
		string result = $"Sending Push Notification to {to} with message: {message}";
		Console.WriteLine(result);

		return result;
	}
}
