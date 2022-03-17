using System;

namespace Voodoo.Notification
{
	public class DummyNotificationSender : INotificationSender
	{
		public void Init()
		{
		}

		public bool AppWasOpenedViaNotification()
		{
			return false;
		}

		public void SendPowerUpNotification(string title, string description, TimeSpan sendIn)
		{
		}
	}
}
