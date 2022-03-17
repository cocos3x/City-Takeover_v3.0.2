using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal struct DebugAnalyticsLog
	{
		private readonly string _003CEventId_003Ek__BackingField;

		private readonly string _003CWrapperName_003Ek__BackingField;

		private readonly string _003CEventName_003Ek__BackingField;

		private readonly string _003CParameters_003Ek__BackingField;

		private readonly DebugAnalyticsStateEnum _003CStateEnum_003Ek__BackingField;

		private readonly DateTime _003CTimestamp_003Ek__BackingField;

		internal string EventId => "";

		internal string WrapperName => "";

		internal string EventName => "";

		internal string Parameters => "";

		internal DebugAnalyticsStateEnum StateEnum => (DebugAnalyticsStateEnum)null;

		internal DateTime Timestamp => (DateTime)null;

		internal DebugAnalyticsLog(string wrapperName, string eventName, string param, DebugAnalyticsStateEnum stateEnum, string eventId)
		{
		}

		public override string ToString()
		{
			return "";
		}
	}
}
