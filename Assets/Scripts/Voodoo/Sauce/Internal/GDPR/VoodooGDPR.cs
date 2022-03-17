using System;
using System.Runtime.InteropServices;
using UnityEngine;
using Voodoo.Sauce.Internal.StoreUtility;

namespace Voodoo.Sauce.Internal.GDPR
{
	public static class VoodooGDPR
	{
		public class GdprConsent
		{
			public bool IsGdprApplicable;

			public bool ExplicitConsentGivenForAds;

			public bool ExplicitConsentGivenForAnalytics;

			public bool IsEmbargoedCountry;

			public bool IsChinaCountry;

			public override string ToString()
			{
				return "";
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<int, bool> _003C_003E9__17_0;

			public static Application.AdvertisingIdentifierCallback _003C_003E9__20_0;

			internal void _003CInit_003Eb__17_0(int gameCount, bool newHighScore)
			{
			}

			internal void _003CAskForConsentWithIdfa_003Eb__20_0(string advertisingId, bool trackingEnabled, string errorMsg)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public Application.AdvertisingIdentifierCallback callback;

			internal void _003CRequestIdfaAsyncWrapper_003Eb__0(string advertisingId, bool trackingEnabled, string errorMsg)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass36_0
		{
			public bool adsConsent;

			public bool analyticsConsent;

			internal void _003CConsentInsights_003Eb__0(string id, bool enabled, string msg)
			{
			}
		}

		private const string TAG = "VoodooGDPR";

		private const string PlayerPref_GdprAdsConsent = "Voodoo.GDPRConsent.Ads";

		private const string PlayerPref_GdprAnalyticsConsent = "Voodoo.GDPRConsent.Analytics";

		private const string PlayerPref_GdprApplicable = "Voodoo.GDPRApplicable";

		private const string PlayerPref_GdprTexts = "Voodoo.GDPRTexts";

		private const string PlayerPref_VoodooPopupCount = "VoodooPopupCount";

		private const string PlayerPref_GdprPrivacyScreenShown = "Vodooo.GDPRPrivacyScreenShown";

		private static bool _enabled;

		private static bool _adsConsent;

		private static bool _analyticsConsent;

		private static string _idfa;

		private static bool _isGdprApplicable;

		private static bool _limitAdTracking;

		private static Action<GdprConsent> _onConsentGiven;

		private static Action<GdprConsent> _onConsentUpdated;

		private static Action _onGdprSettingsClosed;

		public static void Init()
		{
		}

		private static void InitWithIdfa()
		{
		}

		public static bool HasLimitAdTrackingEnabled()
		{
			return false;
		}

		private static void AskForConsentWithIdfa()
		{
		}

		private static void AskForConsentWithoutIdfa()
		{
		}

		private static void RequestIdfaAsyncWrapper(Application.AdvertisingIdentifierCallback callback)
		{
		}

		private static void TryToShow()
		{
		}

		private static void OnNeedConsentSuccess(NeedConsent consent)
		{
		}

		private static void OnNeedConsentError()
		{
		}

		private static void ShowPrivacyAuthorizationIfNeeded()
		{
		}

		private static void AskForConsent(string idfa, bool limitAdTracking)
		{
		}

		private static void ApplyGdpr(NeedConsent consent)
		{
		}

		private static void DoNotApplyGdpr([Optional] NeedConsent consent)
		{
		}

		private static void UpdateGdpr(bool adsConsent, bool analyticsConsent, string consentTexts)
		{
		}

		internal static void ShowPrivacyAuthorization()
		{
		}

		internal static void ShowSettings(Action onSettingsClosed)
		{
		}

		public static void ShowGDPRBanner(bool forceDisplay)
		{
		}

		public static void GiveConsent(bool adsConsent, bool analyticsConsent)
		{
		}

		public static void CloseSettings()
		{
		}

		private static void ConsentInsights(bool adsConsent, bool analyticsConsent)
		{
		}

		private static void SendConsentInsights(bool adsConsent, bool analyticsConsent)
		{
		}

		private static void SetConsent(bool adsConsent, bool analyticsConsent)
		{
		}

		private static bool HasAlreadyAnswered()
		{
			return false;
		}

		public static bool HasAdsConsent()
		{
			return false;
		}

		private static bool HasAnalyticsConsent()
		{
			return false;
		}

		public static int GetVoodooPopupCount()
		{
			return 0;
		}

		public static void IncrementVoodooPopupCount()
		{
		}

		public static void SetCallbacks(Action<GdprConsent> onConsentGiven, Action<GdprConsent> onConsentUpdated)
		{
		}

		public static void TryToShowDebugger()
		{
		}

		private static void OnAppUpdateStatusReceived(AppUpdateStatus status)
		{
		}

		public static void OnGDPRAccepted()
		{
		}

		public static bool IsGdprApplicable()
		{
			return false;
		}

		public static string GetIdfa()
		{
			return "";
		}

		internal static bool AdsConsent()
		{
			return false;
		}

		internal static bool AnalyticsConsent()
		{
			return false;
		}
	}
}
