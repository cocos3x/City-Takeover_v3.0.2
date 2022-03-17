using Voodoo.Sauce.Internal.VoodooTune;

namespace Voodoo.Sauce.Internal.EnvironmentSettings
{
	public static class EnvironmentSettingsLocalStorage
	{
		private const string VOODOO_TUNE_SERVER_KEY = "RemoteConfigServer";

		private const string ANALYTICS_SERVER_KEY = "AnalyticsServer";

		private const string VOODOO_TUNE_VERSION_KEY = "RemoteConfigVersion";

		private const string PROXY_SERVER_KEY = "ProxyServer";

		internal static EnvironmentSettings.Server GetVoodooTuneServer()
		{
			//IL_0003: Expected I4, but got O
			return (EnvironmentSettings.Server)null;
		}

		internal static EnvironmentSettings.Server GetAnalyticsServer()
		{
			//IL_0003: Expected I4, but got O
			return (EnvironmentSettings.Server)null;
		}

		internal static string GetProxyServer()
		{
			return "";
		}

		internal static void SaveVoodooTuneServer(EnvironmentSettings.Server server)
		{
		}

		internal static void SaveAnalyticsServer(EnvironmentSettings.Server server)
		{
		}

		internal static VoodooTuneClusterApi.ConfigVersion GetVoodooTuneVersion()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooTuneClusterApi.ConfigVersion)null;
		}

		internal static void SaveVoodooTuneVersion(VoodooTuneClusterApi.ConfigVersion configVersion)
		{
		}

		internal static void SaveProxyServer(string proxyServer)
		{
		}
	}
}
