namespace Voodoo.Analytics
{
	public static class AnalyticsLog
	{
		public enum AnalyticsLogLevel
		{
			DISABLED,
			ERROR,
			WARNING,
			DEBUG
		}

		private static AnalyticsLogLevel _logLevel;

		private const string TAG = "AnalyticsLog";

		public static void SetLogLevel(AnalyticsLogLevel level)
		{
		}

		public static void Log(string tag, string message)
		{
		}

		public static void LogE(string tag, string message)
		{
		}

		public static void LogW(string tag, string message)
		{
		}

		private static string Format(string tag, string message)
		{
			return "";
		}
	}
}
