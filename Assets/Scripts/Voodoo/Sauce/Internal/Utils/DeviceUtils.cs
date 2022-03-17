namespace Voodoo.Sauce.Internal.Utils
{
	public static class DeviceUtils
	{
		private const string TAG = "DeviceUtils";

		private static string _operatingSystemVersion;

		private static string _manufacturer;

		private static string _model;

		private const string BuildClassName = "android.os.Build";

		private static string _versionClassName;

		private const string ConnectivityOffline = "Offline";

		private const string ConnectivityNetwork = "Network";

		private const string ConnectivityWifi = "Wifi";

		private const string ConnectivityUnknown = "Unknown";

		private static string _lastConnectivity;

		public static string OperatingSystemVersion => "";

		public static string Manufacturer => "";

		public static string Model => "";

		public static bool HasBottomSafeArea()
		{
			return false;
		}

		public static string GetResolution()
		{
			return "";
		}

		private static T CallDeviceInformationMethod<T>(string className, string method)
		{
			return (T)null;
		}

		public static string GetManufacturer()
		{
			return "";
		}

		public static string GetModel()
		{
			return "";
		}

		public static string GetOperatingSystemVersion()
		{
			return "";
		}

		internal static string GetConnectivity()
		{
			return "";
		}

		internal static string GetLocale()
		{
			return "";
		}
	}
}
