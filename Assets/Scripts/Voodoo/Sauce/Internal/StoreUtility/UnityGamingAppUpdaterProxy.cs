namespace Voodoo.Sauce.Internal.StoreUtility
{
	internal static class UnityGamingAppUpdaterProxy
	{
		public delegate void RequestAppUpdateCallback(int status, string version);

		private static RequestAppUpdateCallback _requestAppUpdaterCallback;

		public static void RequestAppUpdaterReceived(int response, string version)
		{
		}

		public static void RequestAppUpdaterDelegatesConfiguration(RequestAppUpdateCallback callback)
		{
		}

		public static void OpenAppStoreProxy()
		{
		}
	}
}
