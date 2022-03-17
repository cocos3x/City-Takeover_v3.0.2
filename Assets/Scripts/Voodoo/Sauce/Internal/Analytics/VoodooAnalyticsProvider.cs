using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class VoodooAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<string, float> _003C_003E9__6_0;

			public static Action<string> _003C_003E9__6_1;

			public static Action<string, string> _003C_003E9__6_2;

			internal void _003CRegisterEvents_003Eb__6_0(string adUnit, float height)
			{
			}

			internal void _003CRegisterEvents_003Eb__6_1(string adUnit)
			{
			}

			internal void _003CRegisterEvents_003Eb__6_2(string adUnit, string impressionData)
			{
			}
		}

		private readonly VoodooAnalyticsParameters _parameters;

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			//IL_0003: Expected I4, but got O
			return (VoodooSauce.AnalyticsProvider)null;
		}

		public VoodooAnalyticsProvider()
		{
		}

		internal VoodooAnalyticsProvider(VoodooAnalyticsParameters parameters)
		{
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(bool consent, bool isChinaBuild)
		{
		}

		private static void RegisterEvents()
		{
		}

		private static void OnNoAdsClickEvent()
		{
		}

		private static void OnInterstitialClickedEvent(string interstitialType, string adUnit, int adCount)
		{
		}

		private static void OnShowInterstitialEvent(string interstitialType, int rvCount, int adCount)
		{
		}

		private static void OnInterstitialTriggeredEvent(string interstitialType, bool interstitialLoaded, int adCount)
		{
		}

		private static void OnInterstitialDismissedEvent(string interstitialType, string adUnits, int adDuration, int adCount)
		{
		}

		private static void OnRewardedVideoClickedEvent(string rewardedType, string adUnit, int adCount)
		{
		}

		private static void OnShowRewardedVideoEvent(string rewardedType, int rvCount, int adCount)
		{
		}

		private static void OnRewardedVideoClosedEvent(string rewardedType, string adUnits, int adDuration, int adCount, bool reward)
		{
		}

		private static void OnRewardedVideoButtonShownEvent(string rewardedType, int adCount)
		{
		}

		private static void OnCrossPromoInitEvent(CrossPromoInitInfo parameters)
		{
		}

		private static void OnCrossPromoShownEvent(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		private static void OnCrossPromoClickEvent(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		private static void OnApplicationFirstLaunch()
		{
		}

		private static void OnApplicationLaunchEvent()
		{
		}

		private static void OnGameStarted(GameStartedParameters parameters)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void OnTrackItemTransactionEvent(ItemTransactionParameters parameters)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, string eventType, List<VoodooSauce.AnalyticsProvider> analyticsProviders)
		{
		}

		private static void TrackVoodooTuneInitEvent(VoodooTuneInitAnalyticsInfo info)
		{
		}

		private static void TrackPerformanceMetrics(PerformanceMetricsAnalyticsInfo performanceMetrics)
		{
		}
	}
}
