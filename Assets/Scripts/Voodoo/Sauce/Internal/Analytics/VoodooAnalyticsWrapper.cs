using System.Collections.Generic;
using System.Runtime.InteropServices;
using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class VoodooAnalyticsWrapper
	{
		public static void TrackEvent(EventName eventName, Dictionary<string, object> data, [Optional] string eventType, [Optional] Dictionary<string, object> customVariables)
		{
		}

		public static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, [Optional] string eventType)
		{
		}

		public static void TrackEvent(EventName eventName, [Optional] string data, [Optional] string eventType, [Optional] Dictionary<string, object> customVariables)
		{
		}

		public static void Instantiate(AnalyticsConfig analyticsConfig, bool useVoodooTune, string mediation, string proxyServer, string editorIdfa)
		{
		}

		public static void AddSessionParameter(AnalyticParameters sessionParameter, object value)
		{
		}
	}
}
