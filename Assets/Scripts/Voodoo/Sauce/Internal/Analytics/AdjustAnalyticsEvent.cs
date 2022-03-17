using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AdjustAnalyticsEvent : BaseAnalyticsEvent
	{
		private Dictionary<string, object> _parameter;

		protected override string GetAnalyticsProviderName()
		{
			return "";
		}

		public AdjustAnalyticsEvent(string eventName, Dictionary<string, object> parameter)
		{
		}

		protected override void PerformTrackEvent()
		{
		}
	}
}
