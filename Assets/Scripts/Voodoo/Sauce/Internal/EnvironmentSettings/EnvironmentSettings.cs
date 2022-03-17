using Voodoo.Sauce.Internal.VoodooTune;

namespace Voodoo.Sauce.Internal.EnvironmentSettings
{
	public static class EnvironmentSettings
	{
		public enum Server
		{
			Tech,
			Staging,
			Dev
		}

		public enum Api
		{
			VoodooTune,
			Analytics
		}

		internal static Server GetServer(Api api)
		{
			//IL_0003: Expected I4, but got O
			return (Server)null;
		}

		internal static string GetURL(string path, Api api)
		{
			return "";
		}

		internal static void SaveVoodooTuneServer(Server server, Api api)
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

		internal static string GetProxyServer()
		{
			return "";
		}

		internal static void SaveProxyServer(string proxyServer)
		{
		}
	}
}
