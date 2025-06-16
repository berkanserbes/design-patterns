using FactoryDesignPattern.NotificationAPI.Abstracts;
using FactoryDesignPattern.NotificationAPI.Concretes;
using FactoryDesignPattern.NotificationAPI.Enums;

namespace FactoryDesignPattern.NotificationAPI.Factories;

public class NotificationFactory : INotificationFactory
{
	private readonly IServiceProvider _serviceProvider;

	public NotificationFactory(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
	}
	public INotificationService Create(NotificationType notificationType)
	{
		//return notificationType switch
		//{
		//	NotificationType.Email => new EmailNotificationService(),
		//	NotificationType.Sms => new SmsNotificationService(),
		//	NotificationType.PushNotification => new PushNotificationService(),
		//	_ => throw new ArgumentException("Invalid notification type", nameof(notificationType))
		//};

		return notificationType switch
		{
			NotificationType.Email => _serviceProvider.GetRequiredService<EmailNotificationService>(),
			NotificationType.Sms => _serviceProvider.GetRequiredService<SmsNotificationService>(),
			NotificationType.PushNotification => _serviceProvider.GetRequiredService<PushNotificationService>(),
			_ => throw new ArgumentException("Invalid notification type", nameof(notificationType))
		};
	}
}
