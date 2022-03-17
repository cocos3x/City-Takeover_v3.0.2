using System.Collections.Generic;
using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class VoodooAnalyticsLoggerEvent : BaseAnalyticsEvent
	{
		private EventName? _eventNameEnum;

		private readonly Dictionary<string, object> _data;

		private readonly string _dataAsString;

		private readonly string _eventType;

		private readonly Dictionary<string, object> _customVariables;

		protected override string GetAnalyticsProviderName()
		{
			return "";
		}

		public VoodooAnalyticsLoggerEvent(EventName eventNameEnum, Dictionary<string, object> data, string eventType, Dictionary<string, object> customVariables)
		{
		}

		public VoodooAnalyticsLoggerEvent(string eventName, Dictionary<string, object> data, string eventType)
		{
		}

		public VoodooAnalyticsLoggerEvent(EventName eventNameEnum, string dataAsString, string eventType, Dictionary<string, object> customVariables)
		{
		}

		protected override void PerformTrackEvent()
		{
		}
	}
}
