using FactoryDesignPattern.NotificationAPI.Models;
using FactoryDesignPattern.NotificationAPI.Services.Abstracts;

namespace FactoryDesignPattern.NotificationAPI.Services.Concretes;

public class EmailNotificationService : INotificationService
{
	public string Send(string to, string message)
	{
		string result = $"Sending Email to {to} with message: {message}";
		Console.WriteLine(result);

		return result;
	}
}
