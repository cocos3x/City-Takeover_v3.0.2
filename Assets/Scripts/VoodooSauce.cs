using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.Ads;
using Voodoo.Sauce.Internal.Analytics;
using Voodoo.Sauce.Internal.CrossPromo;
using Voodoo.Sauce.Internal.CrossPromo.Models;

public static class VoodooSauce
{
	public delegate void AppResumedEventHandler();

	public enum AnalyticsProvider
	{
		VoodooAnalytics,
		GameAnalytics,
		Mixpanel,
		FirebaseAnalytics,
		Adjust
	}

	public static bool UserRequestedToBeForgotten => false;

	private static IAPCore _iap => null;

	public static event AppResumedEventHandler SubscriptionsRefreshed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static string Version()
	{
		return "";
	}

	public static bool IsChinaApp()
	{
		return false;
	}

	public static bool IsIAPEnabled()
	{
		return false;
	}

	public static void SubscribeOnInitFinishedEvent(Action onInitFinished)
	{
	}

	internal static void UnSubscribeOnInitFinishedEvent(Action onInitFinished)
	{
	}

	internal static void InvokeAppResumed()
	{
	}

	public static string GetPlayerCohort()
	{
		return "";
	}

	public static void OnGameStarted(GameStartedParameters parameters)
	{
	}

	public static void OnGameFinished(GameFinishedParameters parameters)
	{
	}

	public static void OnGameStarted()
	{
	}

	public static void OnGameStarted(string levelNumber, [Optional] Dictionary<string, object> eventProperties)
	{
	}

	public static void OnGameFinished(float score)
	{
	}

	public static void OnGameFinished(bool levelComplete, float score, [Optional] Dictionary<string, object> eventProperties)
	{
	}

	public static void OnGameFinished(bool levelComplete, float score, string levelNumber, [Optional] Dictionary<string, object> eventProperties)
	{
	}

	public static void OnItemTransaction(ItemTransactionParameters parameters)
	{
	}

	public static void TrackCustomEvent(string eventName, [Optional] Dictionary<string, object> eventProperties, [Optional] string type, [Optional] List<AnalyticsProvider> analyticsProviders)
	{
	}

	public static void SetCrashlyticsKey(string key, string value)
	{
	}

	public static void LogException(Exception exception)
	{
	}

	public static void RegisterPurchaseDelegate(IPurchaseDelegate purchaseDelegate)
	{
	}

	public static void UnregisterPurchaseDelegate(IPurchaseDelegate purchaseDelegate)
	{
	}

	public static void Purchase(string productId, [Optional] IPurchaseDelegate caller)
	{
	}

	public static void RestorePurchases([Optional] Action<RestorePurchasesResult> successCallback)
	{
	}

	public static SubscriptionInfoContainer GetSubscriptionInfo(string productId)
	{
		return null;
	}

	public static bool IsSubscribed(string productId)
	{
		return false;
	}

	public static void ShowBanner([Optional] Action<float> onBannerDisplayed)
	{
	}

	public static void HideBanner()
	{
	}

	public static void ShowInterstitial([Optional] Action onComplete, bool ignoreConditions = false, [Optional] string interstitialType)
	{
	}

	public static bool IsRewardedVideoAvailable()
	{
		return false;
	}

	public static void SubscribeOnRewardedVideoLoaded(Action<bool> onRewardedVideoLoadComplete)
	{
	}

	public static void UnSubscribeOnRewardedVideoLoaded(Action<bool> onRewardedVideoLoadComplete)
	{
	}

	public static bool IsInterstitialAvailable()
	{
		return false;
	}

	public static bool IsBannerAvailable()
	{
		return false;
	}

	public static void ShowRewardedVideo(Action<bool> onComplete, [Optional] string rewardedType)
	{
	}

	public static void OnRewardedVideoButtonShown(string rewardedType)
	{
	}

	public static void SetInterstitialAdsDisplayConditions(int delayInSecondsBeforeFirstInterstitialAd, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial = -1)
	{
	}

	public static void SetInterstitialAtLaunchConditions(bool interstitialAtLaunch, int interstitialAtLaunchDelay, int interstitialAtLaunchTimeout)
	{
	}

	public static void SetAdUnit(AdUnitType adUnitType, string adUnit)
	{
	}

	public static void EnablePremium()
	{
	}

	public static void SetPremiumPeriod(bool isPremiumPeriodActive)
	{
	}

	public static bool IsPremium()
	{
		return false;
	}

	public static bool IsIAPPremium()
	{
		return false;
	}

	public static bool HasPremiumPeriod()
	{
		return false;
	}

	public static void ShowCrossPromo([Optional] Action<AssetModel> onSuccess, [Optional] Action<CPShowFailType> onFailure)
	{
	}

	public static void HideCrossPromo()
	{
	}

	public static string GetLocalizedProductPrice(string productId)
	{
		return "";
	}

	public static void TryToShowAppRater()
	{
	}

	public static void ShowGDPRSettings([Optional] Action onSettingsClosed)
	{
	}

	public static void RequestGdprApplicability(Action<bool> callback)
	{
	}

	public static void ShowGDPRBanner()
	{
	}

	public static string[] GetAbTests()
	{
		return null;
	}

	public static void SetPlayerCohort(string cohortName)
	{
	}

	public static void ShowCohortDebugMenu()
	{
	}

	public static List<T> GetSubclassesItems<T>() where T : class, new()
	{
		return null;
	}

	public static List<T> GetItems<T>() where T : class, new()
	{
		return null;
	}

	public static List<T> GetItemsOrDefaults<T>() where T : class, new()
	{
		return null;
	}

	public static T GetItem<T>() where T : class, new()
	{
		return null;
	}

	public static T GetItemOrDefault<T>() where T : class, new()
	{
		return null;
	}

	public static bool AdsConsentGiven()
	{
		return false;
	}

	public static bool AnalyticsConsentGiven()
	{
		return false;
	}

	public static bool AreInterstitialDisplayConditionsMet()
	{
		return false;
	}
}
