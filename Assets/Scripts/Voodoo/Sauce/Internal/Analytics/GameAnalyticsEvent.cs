namespace Voodoo.Sauce.Internal.Analytics
{
	internal abstract class GameAnalyticsEvent : BaseAnalyticsEvent
	{
		protected override string GetAnalyticsProviderName()
		{
			return "";
		}

		protected GameAnalyticsEvent(string eventName)
		{
		}
	}
}
