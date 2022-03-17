using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal static class AnalyticsManager
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<IAnalyticsProvider, IAnalyticsAttributionProvider> _003C_003E9__93_0;

			public static Func<IAnalyticsAttributionProvider, bool> _003C_003E9__93_1;

			internal IAnalyticsAttributionProvider _003CAnalyticsAttributionProviders_003Eb__93_0(IAnalyticsProvider provider)
			{
				return null;
			}

			internal bool _003CAnalyticsAttributionProviders_003Eb__93_1(IAnalyticsAttributionProvider provider)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass95_0
		{
			public string mediation;

			internal void _003CInstantiate_003Eb__0(IAnalyticsProvider provider)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass97_0
		{
			public bool consent;

			internal void _003CInitialize_003Eb__0(IAnalyticsProvider provider)
			{
			}
		}

		private const string TAG = "VoodooAnalytics";

		private const string NO_GAME_LEVEL = "game";

		private static bool _003CHasGameStarted_003Ek__BackingField;

		private static readonly VoodooSettings Settings;

		private static readonly List<VoodooSauce.AnalyticsProvider> DefaultAnalyticsProvider;

		private static readonly List<IAnalyticsProvider> AnalyticsProviders;

		private static DateTime GameStart;

		internal static bool HasGameStarted
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		internal static event Action<int, bool> OnGamePlayed
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> OnConsentChangeEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<GameStartedParameters> OnGameStartedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<GameFinishedParameters> OnGameFinishedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, Dictionary<string, object>, string, List<VoodooSauce.AnalyticsProvider>> OnTrackCustomEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, int> OnRewardedVideoButtonShownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<VoodooIAPAnalyticsInfo> OnTrackPurchaseEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<ItemTransactionParameters> OnTrackItemTransactionEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action OnNoAdsClickEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action OnApplicationFirstLaunchEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action OnApplicationLaunchEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action OnApplicationResumeEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, float> OnBannerShownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string> OnBannerClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, int, int> OnShowInterstitialEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, bool, int> OnInterstitialTriggeredEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, string, int> OnInterstitialClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, string, int, int> OnInterstitialDismissedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, int, int> OnShowRewardedVideoEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, string, int> OnRewardedVideoClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, string, int, int, bool> OnRewardedVideoClosedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string, string> OnImpressionTrackedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<CrossPromoAnalyticsInfo> OnCrossPromoShownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<CrossPromoAnalyticsInfo> OnCrossPromoClickEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<CrossPromoInitInfo> OnCrossPromoInitEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<string> OnCrossPromoErrorEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<VoodooTuneInitAnalyticsInfo> OnTrackVoodooTuneInitEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<PerformanceMetricsAnalyticsInfo> OnTrackPerformanceMetricsEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private static List<IAnalyticsAttributionProvider> AnalyticsAttributionProviders()
		{
			return null;
		}

		internal static void Instantiate(string mediation)
		{
		}

		internal static void InitializePerformanceMetricMonitor()
		{
		}

		internal static void Initialize(bool consent)
		{
		}

		internal static AttributionData GetAttributionData()
		{
			return null;
		}

		internal static void SetConsent(bool consent)
		{
		}

		internal static void OnApplicationResume()
		{
		}

		internal static void SetLogLevel(bool enable, VoodooLogLevel globalLevel)
		{
		}

		internal static void TrackApplicationLaunch()
		{
		}

		internal static void TrackGameStarted(GameStartedParameters parameters)
		{
		}

		internal static void TrackRewardedVideoButtonShown(string rewardedType)
		{
		}

		internal static void TrackGameFinished(GameFinishedParameters parameters)
		{
		}

		internal static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, [Optional] string type, [Optional] List<VoodooSauce.AnalyticsProvider> analyticsProviders)
		{
		}

		internal static void TrackNoAdsClick()
		{
		}

		internal static void TrackPurchase(VoodooIAPAnalyticsInfo purchaseInfo)
		{
		}

		internal static void TrackItemTransaction(ItemTransactionParameters parameters)
		{
		}

		internal static void TrackBannerShown(string adUnit, float height)
		{
		}

		internal static void TrackBannerClick(string adUnit)
		{
		}

		internal static void TrackShowInterstitial(string tag)
		{
		}

		internal static void TrackInterstitialTriggered(string tag, bool interstitialLoaded)
		{
		}

		internal static void TrackInterstitialClick(string tag, string adUnit)
		{
		}

		internal static void TrackInterstitialDismiss(string tag, string adUnit, int adDuration)
		{
		}

		internal static void TrackShowRewardedVideo(string tag)
		{
		}

		internal static void TrackRewardedVideoClick(string tag, string adUnit)
		{
		}

		internal static void TrackRewardedVideoClose(string tag, string adUnit, int adDuration, bool reward)
		{
		}

		internal static void TrackImpression(string adUnit, string data)
		{
		}

		internal static void TrackCrossPromoShown(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		internal static void TrackCrossPromoClick(CrossPromoAnalyticsInfo crossPromoInfo)
		{
		}

		internal static void TrackCrossPromoError(string error)
		{
		}

		internal static void TrackCrossPromoInit(CrossPromoInitInfo info)
		{
		}

		internal static void TrackVoodooTuneInitEvent(VoodooTuneInitAnalyticsInfo info)
		{
		}

		internal static void TrackPerformanceMetrics(PerformanceMetricsAnalyticsInfo info)
		{
		}

		internal static BaseAnalyticsProviderWithLogger GetProviderLoggerWithEnum(VoodooSauce.AnalyticsProvider providerEnum)
		{
			return null;
		}
	}
}
