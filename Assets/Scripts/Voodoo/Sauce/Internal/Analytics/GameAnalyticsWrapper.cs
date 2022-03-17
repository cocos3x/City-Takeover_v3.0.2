using GameAnalyticsSDK;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class GameAnalyticsWrapper
	{
		public const string TAG = "GameAnalyticsWrapper";

		private static bool _isInitialized;

		private static bool _isDisabled;

		private static readonly Queue<GameAnalyticsEvent> QueuedEvents;

		internal static bool Initialize(bool consent)
		{
			return false;
		}

		internal static void TrackProgressEvent(GAProgressionStatus status, string progress, int? score)
		{
		}

		internal static void TrackDesignEvent(string eventName)
		{
		}

		internal static void TrackPurchase(VoodooIAPAnalyticsInfo purchaseInfo)
		{
		}

		private static void InstantiateGameAnalytics()
		{
		}

		private static void SetBuildVersion(string buildVersion)
		{
		}

		private static void Disable()
		{
		}
	}
}
