using System.Collections.Generic;

namespace GameAnalyticsSDK.Events
{
	public static class GA_Error
	{
		public static void NewEvent(GAErrorSeverity severity, string message, IDictionary<string, object> fields)
		{
		}

		private static void CreateNewEvent(GAErrorSeverity severity, string message, IDictionary<string, object> fields)
		{
		}
	}
}
