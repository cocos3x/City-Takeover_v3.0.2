namespace Voodoo.Sauce.Internal.Analytics
{
	internal abstract class MixpanelEvent : BaseAnalyticsEvent
	{
		protected override string GetAnalyticsProviderName()
		{
			return "";
		}

		protected MixpanelEvent(string eventName)
		{
		}
	}
}
