using System;
using System.Runtime.InteropServices;

namespace Voodoo.Sauce.Internal.Ads
{
	public interface IMediationAdapter
	{
		event Action<bool> OnRewardedVideoAvailabilityChangeEvent;

		MediationType GetMediationType();

		void Initialize(AdsKeys keys, bool consent, Action sdkInitialized);

		bool IsSdkInitialized();

		void SetConsent(bool consent);

		bool IsBannerAvailable();

		void ShowBanner(Action<float> onBannerDisplayed);

		void HideBanner();

		bool IsPrimaryInterstitialAvailable();

		bool IsSecondaryInterstitialAvailable();

		void ShowInterstitial(Action onComplete, [Optional] string tag, [Optional] Action<string> beforeShow);

		void ShowPrimaryInterstitial(Action onComplete, [Optional] string tag, [Optional] Action<string> beforeShow);

		void ShowSecondaryInterstitial(Action onComplete, [Optional] string tag, [Optional] Action<string> beforeShow);

		bool IsPrimaryRewardedVideoAvailable();

		bool IsSecondaryRewardedVideoAvailable();

		void ShowRewardedVideo(Action<bool> onComplete, [Optional] string tag, [Optional] Action<string> beforeShow);

		void ShowPrimaryRewardedVideo(Action<bool> onComplete, [Optional] string tag, [Optional] Action<string> beforeShow);

		void ShowSecondaryRewardedVideo(Action<bool> onComplete, [Optional] string tag, [Optional] Action<string> beforeShow);

		void DisableBannerAndInterstitial();

		void EnableBannerAndInterstitial();

		void SetAdUnit(AdUnitType type, string adUnit);

		bool HasDebugger();

		void ShowDebugger();

		string GetBannerAdNetworkName();

		TimeSpan GetBannerLoadingTime();

		string GetInterstitialAdNetworkName();

		TimeSpan GetInterstitialLoadingTime();

		TimeSpan GetPrimaryInterstitialLoadingTime();

		TimeSpan GetSecondaryInterstitialLoadingTime();

		string GetRewardedVideoAdNetworkName();

		TimeSpan GetRewardedVideoLoadingTime();

		TimeSpan GetPrimaryRewardedVideoLoadingTime();

		TimeSpan GetSecondaryRewardedVideoLoadingTime();
	}
}
