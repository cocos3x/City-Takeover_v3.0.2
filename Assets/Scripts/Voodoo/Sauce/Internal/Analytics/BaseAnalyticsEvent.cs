using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal abstract class BaseAnalyticsEvent
	{
		private string _003CEventName_003Ek__BackingField;

		private readonly string _003CEventId_003Ek__BackingField;

		private Dictionary<string, object> _003CEventData_003Ek__BackingField;

		protected string EventName
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		protected string EventId => "";

		protected Dictionary<string, object> EventData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected abstract void PerformTrackEvent();

		protected abstract string GetAnalyticsProviderName();

		protected BaseAnalyticsEvent(string eventName, [Optional] Dictionary<string, object> eventData)
		{
		}

		internal void Track()
		{
		}

		private void LogEventInDebugger()
		{
		}
	}
}
