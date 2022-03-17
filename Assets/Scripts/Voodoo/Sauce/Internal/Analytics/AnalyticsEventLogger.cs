using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AnalyticsEventLogger
	{
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public string wrapperNameFilter;

			internal bool _003CGetLocalAnalyticsLog_003Eb__0(DebugAnalyticsLog nameInList)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public DebugAnalyticsLog localAnalyticsLog;

			internal bool _003CLogEventLocally_003Eb__0(DebugAnalyticsLog logItem)
			{
				return false;
			}
		}

		private const string TAG = "AnalyticsEventLogger";

		private const string VOODOO_ANALYTICS_WRAPPER_NAME = "VoodooAnalytics";

		private static AnalyticsEventLogger _instance;

		private readonly List<DebugAnalyticsLog> _logsList;

		private readonly HashSet<string> _logsIdList;

		private static bool _isAnalyticsDebuggingEnabled;

		private static bool _isAnalyticsLoggingEnabled;

		internal static event Action<DebugAnalyticsLog, bool> OnAnalyticsEventStateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal List<DebugAnalyticsLog> GetLocalAnalyticsLog([Optional] string wrapperNameFilter)
		{
			return null;
		}

		internal static AnalyticsEventLogger GetInstance()
		{
			return null;
		}

		private void LogEventLocally(string wrapperName, string eventName, DebugAnalyticsStateEnum state, string eventId, [Optional] string param)
		{
		}

		internal void LogEventSentTo3rdParty(string wrapperName, string eventName, string eventId, [Optional] Dictionary<string, object> param)
		{
		}

		internal void LogEventsSentSuccessfully(List<string> eventJsons)
		{
		}

		internal void LogEventsSentError(List<string> eventJsons)
		{
		}

		private void LogAnalyticsSentOrErrorEvent(string wrapperName, List<string> eventJsons, DebugAnalyticsStateEnum stateEnum)
		{
		}

		private static string GetEventNameFromJson(string json)
		{
			return "";
		}

		private static string GetEventIdFromJson(string json)
		{
			return "";
		}

		private static string GetValueFromJsonWithRegex(string json, string regex)
		{
			return "";
		}

		internal void SetAnalyticsDebugging(bool enabled)
		{
		}

		internal void SetAnalyticsLogging(bool enabled)
		{
		}

		internal void FlushAnalyticsLogs()
		{
		}

		private string DictionaryToString(Dictionary<string, object> dictionary)
		{
			return "";
		}
	}
}
