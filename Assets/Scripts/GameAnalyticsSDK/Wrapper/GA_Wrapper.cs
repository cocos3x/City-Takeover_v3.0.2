using System.Collections.Generic;
using UnityEngine;

namespace GameAnalyticsSDK.Wrapper
{
	public class GA_Wrapper
	{
		private static readonly AndroidJavaClass GA;

		private static readonly AndroidJavaClass UNITY_GA;

		private static readonly AndroidJavaClass GA_IMEI;

		private static void configureAvailableCustomDimensions01(string list)
		{
		}

		private static void configureAvailableCustomDimensions02(string list)
		{
		}

		private static void configureAvailableCustomDimensions03(string list)
		{
		}

		private static void configureAvailableResourceCurrencies(string list)
		{
		}

		private static void configureAvailableResourceItemTypes(string list)
		{
		}

		private static void configureSdkGameEngineVersion(string unitySdkVersion)
		{
		}

		private static void configureGameEngineVersion(string unityEngineVersion)
		{
		}

		private static void configureBuild(string build)
		{
		}

		private static void configureUserId(string userId)
		{
		}

		private static void configureAutoDetectAppVersion(bool flag)
		{
		}

		private static void initialize(string gamekey, string gamesecret)
		{
		}

		private static void setCustomDimension01(string customDimension)
		{
		}

		private static void setCustomDimension02(string customDimension)
		{
		}

		private static void setCustomDimension03(string customDimension)
		{
		}

		private static void addBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, string fields)
		{
		}

		private static void addBusinessEventWithReceipt(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string store, string signature, string fields)
		{
		}

		private static void addResourceEvent(int flowType, string currency, float amount, string itemType, string itemId, string fields)
		{
		}

		private static void addProgressionEvent(int progressionStatus, string progression01, string progression02, string progression03, string fields)
		{
		}

		private static void addProgressionEventWithScore(int progressionStatus, string progression01, string progression02, string progression03, int score, string fields)
		{
		}

		private static void addDesignEvent(string eventId, string fields)
		{
		}

		private static void addDesignEventWithValue(string eventId, float value, string fields)
		{
		}

		private static void addErrorEvent(int severity, string message, string fields)
		{
		}

		private static void addAdEventWithDuration(int adAction, int adType, string adSdkName, string adPlacement, long duration)
		{
		}

		private static void addAdEventWithReason(int adAction, int adType, string adSdkName, string adPlacement, int noAdReason)
		{
		}

		private static void addAdEvent(int adAction, int adType, string adSdkName, string adPlacement)
		{
		}

		private static void setEnabledInfoLog(bool enabled)
		{
		}

		private static void setEnabledVerboseLog(bool enabled)
		{
		}

		private static void setManualSessionHandling(bool enabled)
		{
		}

		private static void setEventSubmission(bool enabled)
		{
		}

		private static void gameAnalyticsStartSession()
		{
		}

		private static void gameAnalyticsEndSession()
		{
		}

		private static string getRemoteConfigsValueAsString(string key, string defaultValue)
		{
			return "";
		}

		private static bool isRemoteConfigsReady()
		{
			return false;
		}

		private static string getRemoteConfigsContentAsString()
		{
			return "";
		}

		private static string getABTestingId()
		{
			return "";
		}

		private static string getABTestingVariantId()
		{
			return "";
		}

		private static void startTimer(string key)
		{
		}

		private static void pauseTimer(string key)
		{
		}

		private static void resumeTimer(string key)
		{
		}

		private static long stopTimer(string key)
		{
			return 0L;
		}

		private static void subscribeMoPubImpressions()
		{
		}

		private static void MopubImpressionHandler(string json)
		{
		}

		private static void subscribeFyberImpressions()
		{
		}

		private static void FyberImpressionHandler(string json)
		{
		}

		private static void subscribeIronSourceImpressions()
		{
		}

		private static void IronSourceImpressionHandler(string json)
		{
		}

		public static void SetAvailableCustomDimensions01(string list)
		{
		}

		public static void SetAvailableCustomDimensions02(string list)
		{
		}

		public static void SetAvailableCustomDimensions03(string list)
		{
		}

		public static void SetAvailableResourceCurrencies(string list)
		{
		}

		public static void SetAvailableResourceItemTypes(string list)
		{
		}

		public static void SetUnitySdkVersion(string unitySdkVersion)
		{
		}

		public static void SetUnityEngineVersion(string unityEngineVersion)
		{
		}

		public static void SetBuild(string build)
		{
		}

		public static void SetCustomUserId(string userId)
		{
		}

		public static void SetEnabledManualSessionHandling(bool enabled)
		{
		}

		public static void SetEnabledEventSubmission(bool enabled)
		{
		}

		public static void SetAutoDetectAppVersion(bool flag)
		{
		}

		public static void StartSession()
		{
		}

		public static void EndSession()
		{
		}

		public static void Initialize(string gamekey, string gamesecret)
		{
		}

		public static void SetCustomDimension01(string customDimension)
		{
		}

		public static void SetCustomDimension02(string customDimension)
		{
		}

		public static void SetCustomDimension03(string customDimension)
		{
		}

		public static void AddBusinessEventWithReceipt(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string store, string signature, IDictionary<string, object> fields)
		{
		}

		public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, IDictionary<string, object> fields)
		{
		}

		public static void AddResourceEvent(GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId, IDictionary<string, object> fields)
		{
		}

		public static void AddProgressionEvent(GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, IDictionary<string, object> fields)
		{
		}

		public static void AddProgressionEventWithScore(GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score, IDictionary<string, object> fields)
		{
		}

		public static void AddDesignEvent(string eventID, float eventValue, IDictionary<string, object> fields)
		{
		}

		public static void AddDesignEvent(string eventID, IDictionary<string, object> fields)
		{
		}

		public static void AddErrorEvent(GAErrorSeverity severity, string message, IDictionary<string, object> fields)
		{
		}

		public static void AddAdEventWithDuration(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement, long duration)
		{
		}

		public static void AddAdEventWithReason(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason)
		{
		}

		public static void AddAdEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement)
		{
		}

		public static void SetInfoLog(bool enabled)
		{
		}

		public static void SetVerboseLog(bool enabled)
		{
		}

		public static string GetRemoteConfigsValueAsString(string key, string defaultValue)
		{
			return "";
		}

		public static bool IsRemoteConfigsReady()
		{
			return false;
		}

		public static string GetRemoteConfigsContentAsString()
		{
			return "";
		}

		public static string GetABTestingId()
		{
			return "";
		}

		public static string GetABTestingVariantId()
		{
			return "";
		}

		private static string DictionaryToJsonString(IDictionary<string, object> dict)
		{
			return "";
		}

		public static void StartTimer(string key)
		{
		}

		public static void PauseTimer(string key)
		{
		}

		public static void ResumeTimer(string key)
		{
		}

		public static long StopTimer(string key)
		{
			return 0L;
		}

		public static void SubscribeMoPubImpressions()
		{
		}

		public static void SubscribeFyberImpressions()
		{
		}

		public static void SubscribeIronSourceImpressions()
		{
		}
	}
}
