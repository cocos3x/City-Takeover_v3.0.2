using System;

namespace Voodoo.Notification
{
	public class AndroidNotificationSender : INotificationSender
	{
		private const string POWER_UP_CHANNEL_ID = "cto_powerup_channel";

		private int _powerUpsNotificationId;

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
