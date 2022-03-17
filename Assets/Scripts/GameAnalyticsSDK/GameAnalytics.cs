using GameAnalyticsSDK.Setup;
using System;
using UnityEngine;

namespace GameAnalyticsSDK
{
	public class GameAnalytics : MonoBehaviour
	{
		private static Settings _settings;

		private static GameAnalytics _instance;

		private static bool _hasInitializeBeenCalled;

		public static Settings SettingsGA
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static event Action OnRemoteConfigsUpdatedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private static void InitAPI()
		{
		}

		private static void InternalInitialize()
		{
		}

		public static void Initialize()
		{
		}

		public static void NewBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType)
		{
		}

		public static void NewBusinessEventGooglePlay(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string signature)
		{
		}

		public static void NewDesignEvent(string eventName)
		{
		}

		public static void NewDesignEvent(string eventName, float eventValue)
		{
		}

		public static void NewProgressionEvent(GAProgressionStatus progressionStatus, string progression01)
		{
		}

		public static void NewProgressionEvent(GAProgressionStatus progressionStatus, string progression01, string progression02)
		{
		}

		public static void NewProgressionEvent(GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03)
		{
		}

		public static void NewProgressionEvent(GAProgressionStatus progressionStatus, string progression01, int score)
		{
		}

		public static void NewProgressionEvent(GAProgressionStatus progressionStatus, string progression01, string progression02, int score)
		{
		}

		public static void NewProgressionEvent(GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score)
		{
		}

		public static void NewResourceEvent(GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId)
		{
		}

		public static void NewErrorEvent(GAErrorSeverity severity, string message)
		{
		}

		public static void NewAdEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement, long duration)
		{
		}

		public static void NewAdEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason)
		{
		}

		public static void NewAdEvent(GAAdAction adAction, GAAdType adType, string adSdkName, string adPlacement)
		{
		}

		public static void SetCustomId(string userId)
		{
		}

		public static void SetEnabledManualSessionHandling(bool enabled)
		{
		}

		public static void SetEnabledEventSubmission(bool enabled)
		{
		}

		public static void StartSession()
		{
		}

		public static void EndSession()
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

		public void OnRemoteConfigsUpdated()
		{
		}

		public static void RemoteConfigsUpdated()
		{
		}

		public static string GetRemoteConfigsValueAsString(string key)
		{
			return "";
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

		private static string GetUnityVersion()
		{
			return "";
		}

		private static int GetPlatformIndex()
		{
			return 0;
		}

		public static void SetBuildAllPlatforms(string build)
		{
		}
	}
}
