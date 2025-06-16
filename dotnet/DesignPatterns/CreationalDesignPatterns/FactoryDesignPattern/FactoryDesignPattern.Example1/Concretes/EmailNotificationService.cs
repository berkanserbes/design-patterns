using FactoryDesignPattern.NotificationAPI.Abstracts;
using FactoryDesignPattern.NotificationAPI.Models;

namespace FactoryDesignPattern.NotificationAPI.Concretes;

public class EmailNotificationService : INotificationService
{
	public string Send(string to, string message)
	{
		string result = $"Sending Email to {to} with message: {message}";
		Console.WriteLine(result);

		return result;
	}
}
