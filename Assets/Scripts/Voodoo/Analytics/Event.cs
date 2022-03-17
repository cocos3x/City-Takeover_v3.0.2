using System;
using System.Collections.Generic;

namespace Voodoo.Analytics
{
	internal class Event
	{
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Dictionary<string, object> eventValues;

			public Action<Event> complete;

			public string name;

			public string dataJson;

			public string customVariablesJson;

			internal void _003CCreate_003Eb__0(string advertisingId, bool limitAdTracking)
			{
			}
		}

		private const string EventTypeImpression = "impression";

		private const string EventTypeApp = "app";

		private const string EventTypeCustom = "custom";

		private Dictionary<string, object> _values;

		private string _name;

		private string _jsonData;

		private string _customVariablesData;

		private static readonly string[] ImpressionEvents;

		internal string GetName()
		{
			return "";
		}

		private Event()
		{
		}

		internal static void Create(string name, Dictionary<AnalyticParameters, object> parameters, string dataJson, string customVariablesJson, string type, string sessionId, int sessionLength, int sessionCount, Action<Event> complete, string eventId)
		{
		}

		private static bool ParameterHasValue(Dictionary<AnalyticParameters, object> parameters, AnalyticParameters parameterKey)
		{
			return false;
		}

		private static string GetType(string name)
		{
			return "";
		}

		internal string ToJson()
		{
			return "";
		}

		public override string ToString()
		{
			return "";
		}
	}
}
