using FactoryDesignPattern.NotificationAPI.Factories;
using FactoryDesignPattern.NotificationAPI.Models;
using FactoryDesignPattern.NotificationAPI.Services.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPattern.NotificationAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
	private readonly INotificationFactory _notificationFactory;
	
	public NotificationController(INotificationFactory notificationFactory)
	{
		_notificationFactory = notificationFactory;
	}

	[HttpPost]
	public IActionResult SendNotification(NotificationRequest notificationRequest)
	{
		INotificationService notificationService = _notificationFactory.Create(notificationRequest.NotificationType);

		var result = notificationService.Send(to: notificationRequest.To,
								message: notificationRequest.Message);

		return Ok(result);
	}

}
