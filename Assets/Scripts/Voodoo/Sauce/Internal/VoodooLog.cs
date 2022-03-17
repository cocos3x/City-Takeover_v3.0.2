namespace Voodoo.Sauce.Internal
{
	public static class VoodooLog
	{
		public enum Module
		{
			NONE = 0,
			ADS = 1,
			ANALYTICS = 2,
			APP_RATER = 4,
			CROSS_PROMO = 8,
			GDPR = 0x10,
			VOODOO_TUNE = 0x20,
			IAP = 0x40,
			COMMON = 0x80
		}

		private static VoodooLogLevel _logLevel;

		private const string TAG = "VoodooSauce";

		public const string LOGS_DISPLAY_SETTING = "LogsDisplaySetting";

		public const string LOG_LEVEL_PLAYER_PREFS_KEY = "VoodooLogLevel";

		public const string FILTER_PLAYER_PREFS_KEY = "VoodooLogFilter";

		public const string ENABLE_LOGS = "EnableLogs";

		public const string DISABLE_LOGS = "DisableLogs";

		public const int ALL_MODULES = 255;

		private static int _currentFilter;

		private static VoodooSettings _settings;

		public static void Initialize(VoodooSettings settings)
		{
		}

		private static void UpdateAnalyticsLogLevel(bool logsEnabled = true)
		{
		}

		public static void LogDebug(Module module, string tag, string message)
		{
		}

		public static void LogError(Module module, string tag, string message)
		{
		}

		public static void LogWarning(Module module, string tag, string message)
		{
		}

		private static string Format(Module module, string tag, string message)
		{
			return "";
		}

		public static void DisableLogs()
		{
		}

		public static void EnableLogs()
		{
		}

		public static bool IsLogsEnabled()
		{
			return false;
		}

		internal static void SetLogLevel(int value)
		{
		}

		internal static void ToggleLogModule(int value)
		{
		}

		internal static VoodooLogLevel GetLogLevel()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooLogLevel)null;
		}

		internal static int GetModuleFilter()
		{
			return 0;
		}
	}
}
