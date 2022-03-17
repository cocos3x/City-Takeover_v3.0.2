using System;

namespace Voodoo.Notification
{
	public interface INotificationSender
	{
		void Init();

		bool AppWasOpenedViaNotification();

		void SendPowerUpNotification(string title, string description, TimeSpan sendIn);
	}
}
