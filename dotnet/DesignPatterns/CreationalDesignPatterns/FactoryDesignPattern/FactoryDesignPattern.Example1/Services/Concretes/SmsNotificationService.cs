using FactoryDesignPattern.NotificationAPI.Services.Abstracts;

namespace FactoryDesignPattern.NotificationAPI.Services.Concretes;

public class SmsNotificationService : INotificationService
{
	public string Send(string to, string message)
	{
		var result = $"Sending SMS to {to} with message: {message}";
		Console.WriteLine(result);

		return result;
	}
}
