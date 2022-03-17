namespace GameAnalyticsSDK.Events
{
	public static class GA_Ads
	{
		public static void NewEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement, long duration)
		{
		}

		public static void NewEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason)
		{
		}

		public static void NewEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement)
		{
		}
	}
}
