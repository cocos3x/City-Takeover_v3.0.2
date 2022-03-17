using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Ads
{
	internal static class AdsManager
	{
		public struct AdEvent
		{
			public enum Type
			{
				START,
				STOP
			}

			public Type type;

			public DateTime time;

			public AdEvent(Type type, DateTime time)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass46_0
		{
			public DateTime start;

			internal void _003CBaseShowInterstitial_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass47_0
		{
			public string tag;

			internal void _003CShowInterstitial_003Eb__0(Action newOnComplete)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<string> _003C_003E9__47_1;

			public static Action<string> _003C_003E9__48_1;

			public static Action<string> _003C_003E9__49_1;

			public static Action<string> _003C_003E9__57_1;

			public static Action<string> _003C_003E9__58_1;

			public static Action<string> _003C_003E9__59_1;

			internal void _003CShowInterstitial_003Eb__47_1(string newTag)
			{
			}

			internal void _003CVSDebuggerShowPrimaryInterstitial_003Eb__48_1(string newTag)
			{
			}

			internal void _003CVSDebuggerShowSecondaryInterstitial_003Eb__49_1(string newTag)
			{
			}

			internal void _003CShowRewardedVideo_003Eb__57_1(string newTag)
			{
			}

			internal void _003CVSDebuggerShowPrimaryRewardedVideo_003Eb__58_1(string newTag)
			{
			}

			internal void _003CVSDebuggerShowSecondaryRewardedVideo_003Eb__59_1(string newTag)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass48_0
		{
			public string tag;

			internal void _003CVSDebuggerShowPrimaryInterstitial_003Eb__0(Action newOnComplete)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass49_0
		{
			public string tag;

			internal void _003CVSDebuggerShowSecondaryInterstitial_003Eb__0(Action newOnComplete)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass56_0
		{
			public DateTime start;

			internal void _003CBaseShowRewardedVideo_003Eb__0(bool b)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass57_0
		{
			public string tag;

			internal void _003CShowRewardedVideo_003Eb__0(Action<bool> newOnComplete)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass58_0
		{
			public string tag;

			internal void _003CVSDebuggerShowPrimaryRewardedVideo_003Eb__0(Action<bool> newOnComplete)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass59_0
		{
			public string tag;

			internal void _003CVSDebuggerShowSecondaryRewardedVideo_003Eb__0(Action<bool> newOnComplete)
			{
			}
		}

		private const string TAG = "AdsManager";

		private const string FS_COUNT_KEY = "FsCount";

		private const string RV_COUNT_KEY = "RvCount";

		private static InterstitialAdDisplayConditions _interstitialAdDisplayConditions;

		private static bool _initialized;

		private static bool _bannerShown;

		private static bool _bannerShouldShow;

		private static string _003CAdTag_003Ek__BackingField;

		private static Action<float> _bannerCallback;

		private static IMediationAdapter _mediationAdapter;

		internal static bool interstitialAtLaunch;

		internal static float interstitialAtLaunchDelay;

		internal static float interstitialAtLaunchTimeout;

		internal static int interstitialDuration;

		internal static int rewardedDuration;

		private static List<AdEvent> _003CAdEvents_003Ek__BackingField;

		private static int _interstitialCount;

		private static int _rewardedVideoCount;

		public static string AdTag
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public static List<AdEvent> AdEvents
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static IMediationAdapter MediationAdapter => null;

		internal static string SelectMediation()
		{
			return "";
		}

		internal static int GetMediationChoice()
		{
			return 0;
		}

		internal static void SetMediationChoice(int mediationChoice)
		{
		}

		internal static List<Type> GetMediationAdaptersClasses()
		{
			return null;
		}

		public static void Initialize(VoodooSettings settings, bool consent)
		{
		}

		private static void InitializeMediation(VoodooSettings settings, bool consent)
		{
		}

		private static void OnSdkInitialized()
		{
		}

		public static void SetConsent(bool consent)
		{
		}

		public static void SetAdUnit(AdUnitType type, string adUnit)
		{
		}

		public static void SetInterstitialAdsDisplayConditions(int delayInSecondsBeforeFirstInterstitialAd, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial)
		{
		}

		public static void SetInterstitialAtLaunchConditions(bool interstitialAtLaunchEnabled, int delayInterstitialAtLaunch, int timeoutInterstitialAtLaunch)
		{
		}

		internal static string GetInterstitialConditionSettings()
		{
			return "";
		}

		internal static string GetInterstitialConditionStatusString()
		{
			return "";
		}

		internal static string GetInterstitialConditionStatusInfoString()
		{
			return "";
		}

		internal static bool AreInterstitialDisplayConditionsMet()
		{
			return false;
		}

		public static void ShowBanner(Action<float> onBannerDisplayed)
		{
		}

		public static void HideBanner()
		{
		}

		public static void OnGamePlayed()
		{
		}

		internal static bool IsInterstitialAvailable()
		{
			return false;
		}

		internal static bool IsPrimaryInterstitialAvailable()
		{
			return false;
		}

		internal static bool IsSecondaryInterstitialAvailable()
		{
			return false;
		}

		private static void BaseShowInterstitial(Func<bool> interstitialAvailable, Action<Action> showInterstitial, Action onComplete, bool ignoreConditions = false, string interstitialType = "Best")
		{
		}

		public static void ShowInterstitial(Action onComplete, bool ignoreConditions = false, [Optional] string tag)
		{
		}

		internal static void VSDebuggerShowPrimaryInterstitial(Action onComplete, bool ignoreConditions = false, [Optional] string tag)
		{
		}

		internal static void VSDebuggerShowSecondaryInterstitial(Action onComplete, bool ignoreConditions = false, [Optional] string tag)
		{
		}

		public static int GetInterstitialCount()
		{
			return 0;
		}

		private static void IncrementInterstitialCount()
		{
		}

		public static bool IsRewardedVideoAvailable()
		{
			return false;
		}

		public static bool IsPrimaryRewardedVideoAvailable()
		{
			return false;
		}

		public static bool IsSecondaryRewardedVideoAvailable()
		{
			return false;
		}

		private static void BaseShowRewardedVideo(Action<Action<bool>> showRewardedVideo, Action<bool> onComplete, string rewardedVideoType = "Best")
		{
		}

		public static void ShowRewardedVideo(Action<bool> onComplete, [Optional] string tag)
		{
		}

		internal static void VSDebuggerShowPrimaryRewardedVideo(Action<bool> onComplete, [Optional] string tag)
		{
		}

		internal static void VSDebuggerShowSecondaryRewardedVideo(Action<bool> onComplete, [Optional] string tag)
		{
		}

		public static int GetRewardedVideoCount()
		{
			return 0;
		}

		private static void IncrementRewardedVideoCount()
		{
		}

		public static void DisableBannerAndInterstitial()
		{
		}

		public static void EnableBannerAndInterstitial()
		{
		}
	}
}
