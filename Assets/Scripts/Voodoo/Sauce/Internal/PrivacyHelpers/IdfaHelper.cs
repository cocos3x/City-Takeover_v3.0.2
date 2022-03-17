namespace Voodoo.Sauce.Internal.PrivacyHelpers
{
	public static class IdfaHelper
	{
		public delegate void RequestAdvertisingIdCallback(string advertisingId, bool trackingEnabled, string error);

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public bool forceZerosForLimitedAdTrackingAndroid;

			public RequestAdvertisingIdCallback callBack;

			internal void _003CRequestAdvertisingId_003Eb__0(string advertisingId, bool adTrackingEnabled, string error)
			{
			}
		}

		public const string LimitedAdTrackingId = "00000000-0000-0000-0000-000000000000";

		public static void RequestAdvertisingId(RequestAdvertisingIdCallback callBack, bool forceZerosForLimitedAdTrackingIos, bool forceZerosForLimitedAdTrackingAndroid)
		{
		}
	}
}
