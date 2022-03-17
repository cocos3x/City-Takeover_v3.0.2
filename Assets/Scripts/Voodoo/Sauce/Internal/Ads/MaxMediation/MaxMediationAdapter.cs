using System;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Ads.MaxMediation
{
	public class MaxMediationAdapter : IMediationAdapter
	{
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public MaxMediationAdapter _003C_003E4__this;

			public Action sdkInitialized;

			internal void _003CInitialize_003Eb__0(MaxSdkBase.SdkConfiguration config)
			{
			}
		}

		private const string TAG = "MaxMediationAdapter";

		private const int BannerHeight = 50;

		private AdUnits _adUnits;

		private AdTimers _adTimers;

		private Action<float> _bannerCallback;

		private Action _interstitialCallback;

		private Action<bool> _rewardedCallback;

		private string _rewardedType;

		private string _interstitialType;

		private string _bannerAdUnitBackup;

		private string _interstitialAdUnitBackup;

		public event Action<bool> OnRewardedVideoAvailabilityChangeEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Initialize(AdsKeys keys, bool consent, Action sdkInitialized)
		{
		}

		private void OnSdkInitialized()
		{
		}

		public MediationType GetMediationType()
		{
			//IL_0003: Expected I4, but got O
			return (MediationType)null;
		}

		public bool IsSdkInitialized()
		{
			return false;
		}

		public void SetConsent(bool consent)
		{
		}

		public bool IsBannerAvailable()
		{
			return false;
		}

		public void ShowBanner(Action<float> onBannerDisplayed)
		{
		}

		public void HideBanner()
		{
		}

		public bool IsPrimaryInterstitialAvailable()
		{
			return false;
		}

		public bool IsInterstitialAvailable()
		{
			return false;
		}

		public void ShowInterstitial(Action onComplete, [Optional] string tag, [Optional] Action<string> beforeShow)
		{
		}

		public void ShowPrimaryInterstitial(Action onComplete, [Optional] string tag, [Optional] Action<string> beforeShow)
		{
		}

		public bool IsSecondaryInterstitialAvailable()
		{
			return false;
		}

		public void ShowSecondaryInterstitial(Action onComplete, [Optional] string tag, [Optional] Action<string> beforeShow)
		{
		}

		public bool IsPrimaryRewardedVideoAvailable()
		{
			return false;
		}

		public bool IsRewardedVideoAvailable()
		{
			return false;
		}

		public void ShowPrimaryRewardedVideo(Action<bool> onComplete, [Optional] string tag, [Optional] Action<string> beforeShow)
		{
		}

		public bool IsSecondaryRewardedVideoAvailable()
		{
			return false;
		}

		public void ShowSecondaryRewardedVideo(Action<bool> onComplete, [Optional] string tag, [Optional] Action<string> beforeShow)
		{
		}

		public void ShowRewardedVideo(Action<bool> onComplete, [Optional] string tag, [Optional] Action<string> beforeShow)
		{
		}

		public void DisableBannerAndInterstitial()
		{
		}

		public void EnableBannerAndInterstitial()
		{
		}

		public void SetAdUnit(AdUnitType type, string adUnit)
		{
		}

		public bool HasDebugger()
		{
			return false;
		}

		public void ShowDebugger()
		{
		}

		public string GetBannerAdNetworkName()
		{
			return "";
		}

		public TimeSpan GetBannerLoadingTime()
		{
			return (TimeSpan)null;
		}

		public string GetInterstitialAdNetworkName()
		{
			return "";
		}

		public TimeSpan GetInterstitialLoadingTime()
		{
			return (TimeSpan)null;
		}

		public TimeSpan GetPrimaryInterstitialLoadingTime()
		{
			return (TimeSpan)null;
		}

		public TimeSpan GetSecondaryInterstitialLoadingTime()
		{
			return (TimeSpan)null;
		}

		public string GetRewardedVideoAdNetworkName()
		{
			return "";
		}

		public TimeSpan GetRewardedVideoLoadingTime()
		{
			return (TimeSpan)null;
		}

		public TimeSpan GetPrimaryRewardedVideoLoadingTime()
		{
			return (TimeSpan)null;
		}

		public TimeSpan GetSecondaryRewardedVideoLoadingTime()
		{
			return (TimeSpan)null;
		}

		private void OnAdRevenuePaidEvent(MaxSdkBase.AdInfo adInfo, string adUnitFormat)
		{
		}

		private void InitializeBannerAds()
		{
		}

		private void OnBannerAdLoaded(string adUnitId)
		{
		}

		private void OnBannerAdLoadFailed(string adUnitId, int errorCode)
		{
		}

		private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InitializeInterstitialAds()
		{
		}

		private void LoadInterstitial()
		{
		}

		private static void SetSessionId()
		{
		}

		private void OnInterstitialLoaded(string adUnitId)
		{
		}

		private void OnInterstitialFailed(string adUnitId, int errorCode)
		{
		}

		private void OnInterstitialFailedToDisplay(string adUnitId, int errorCode)
		{
		}

		private void OnInterstitialDismissed(string adUnitId)
		{
		}

		private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InitializeRewardedAds()
		{
		}

		private void LoadRewardedAd()
		{
		}

		private void OnRewardedAdLoaded(string adUnitId)
		{
		}

		private void OnRewardedAdReceivedReward(string adUnitId, MaxSdkBase.Reward reward)
		{
		}

		private void OnRewardedAdHidden(string adUnitId)
		{
		}

		private void OnRewardedAdFailed(string adUnitId, int errorCode)
		{
		}

		private void OnRewardedAdFailedToDisplay(string adUnitId, int errorCode)
		{
		}

		private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void _003CInitializeInterstitialAds_003Eb__54_0(string adUnit)
		{
		}

		private void _003CInitializeRewardedAds_003Eb__62_0(string adUnit)
		{
		}
	}
}
