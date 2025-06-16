using FactoryDesignPattern.NotificationAPI.Enums;

namespace FactoryDesignPattern.NotificationAPI.Models;

public class NotificationRequest
{
	public string To { get; set; } = string.Empty;
	public string Message { get; set; } = string.Empty;
	public NotificationType NotificationType { get; set; }
}
