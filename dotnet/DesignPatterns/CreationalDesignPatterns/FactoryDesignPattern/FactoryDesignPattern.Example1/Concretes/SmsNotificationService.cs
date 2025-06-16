using FactoryDesignPattern.NotificationAPI.Abstracts;

namespace FactoryDesignPattern.NotificationAPI.Concretes;

public class SmsNotificationService : INotificationService
{
	public string Send(string to, string message)
	{
		var result = $"Sending SMS to {to} with message: {message}";
		Console.WriteLine(result);

		return result;
	}
}
