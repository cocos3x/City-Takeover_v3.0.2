using System;
using UnityEngine;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.Ads;
using Voodoo.Sauce.Internal.Analytics;
using Voodoo.Sauce.Internal.CrossPromo;

namespace Voodoo.Sauce.Internal
{
	[Serializable]
	public class VoodooSettings : ScriptableObject
	{
		public const string NAME = "VoodooSettings";

		public const string STORE_WORLDWIDE = "worldwide";

		public const string STORE_CHINA = "china";

		public const string DEFAULT_STORE = "worldwide";

		public string Store;

		public string AccessTokenID;

		public string LastUpdateDate;

		public bool EnableInEditorUnityAds;

		public bool EnableInEditorRVAds;

		public bool EnableInEditorFSAds;

		public bool EnableIosABTests;

		public bool EnableCustomIosABTestsCountryCodes;

		public float MaxPercentOfTotalIosCohorts;

		public float MixpanelUsersPercentPerCohort;

		public string[] RunningIosABTests;

		public string[] CustomIosABTestsCountryCodes;

		public DebugForcedCohortIos DebugForcedCohort;

		public bool EnableAndroidABTests;

		public bool EnableCustomAndroidABTestsCountryCodes;

		public float MaxPercentOfTotalAndroidCohorts;

		public float AndroidUsersPercentPerCohort;

		public string[] RunningAndroidABTests;

		public string[] CustomAndroidABTestsCountryCodes;

		public DebugForcedCohortAndroid DebugAndroidForcedCohort;

		public bool AndroidIAPEnabled;

		public bool iOSIAPEnabled;

		public string NoAdsBundleId;

		public ProductDescriptor[] Products;

		public string SubscriptionSharedKey;

		public Texture2D StudioLogoForSplashScreen;

		public bool DisableSplashScreen;

		public string AppleStoreId;

		public bool iOSAppRaterEnabled;

		public bool AndroidAppRaterEnabled;

		public int AppRaterDelayAfterLaunchInSeconds;

		public int AppRaterPostponeCooldownInSeconds;

		public int AppRaterMinimumNumberOfGamesPlayed;

		public Color GdprPrimaryColor;

		public VoodooLogLevel VoodooLogLevelInEditor;

		public int VoodooLogFilter;

		public CrossPromoSettings CrossPromo;

		public bool iOSCrossPromotionEnabled;

		public bool AndroidCrossPromotionEnabled;

		public string EditorIdfa;

		public bool IgnoreTheGoogleKeyError;

		public string IOSBundleID;

		public string AndroidBundleID;

		public bool UseRemoteConfig;

		public bool UseVoodooAnalytics;

		public bool UseFirebaseAnalytics;

		public string MixpanelProdToken;

		public string GameAnalyticsIosGameKey;

		public string GameAnalyticsIosSecretKey;

		public string GameAnalyticsAndroidGameKey;

		public string GameAnalyticsAndroidSecretKey;

		public AdUnits MopubIosAdUnits;

		public AdUnits MopubAndroidAdUnits;

		public bool IsSecondaryInterstitialAdUnitEnabled;

		public bool IsSecondaryRewardedVideoAdUnitEnabled;

		public string SecondaryIosInterstitialAdUnit;

		public string SecondaryIosRewardedVideoAdUnit;

		public string SecondaryAndroidInterstitialAdUnit;

		public string SecondaryAndroidRewardedVideoAdUnit;

		public AdUnits MaxAdsIosAdUnits;

		public AdUnits MaxAdsAndroidAdUnits;

		public string MaxSdkKey;

		public string TapjoyIosSdkKey;

		public string TapjoyAndroidSdkKey;

		public string AdMobAndroidAppId;

		public string AdMobIosAppId;

		public string PangleAndroidAppId;

		public string PangleIosAppId;

		public string OguryAndroidAppKey;

		public string OguryIosAppKey;

		public string SnapIosAppId;

		public string SnapAndroidAppId;

		public string VungleIosAppId;

		public string VungleAndroidAppId;

		public string TencentIosAppId;

		public string AdColonyIosAppId;

		public string AdColonyIosBannerZoneId;

		public string AdColonyIosInterstitialZoneId;

		public string AdColonyIosRewardedVideoZoneId;

		public string AdColonyAndroidAppId;

		public string AdColonyAndroidBannerZoneId;

		public string AdColonyAndroidInterstitialZoneId;

		public string AdColonyAndroidRewardedVideoZoneId;

		public string IronSourceIosAppId;

		public string IronSourceAndroidAppId;

		public string VerizonIosSiteId;

		public string VerizonAndroidSiteId;

		public string ChatboostIosAppId;

		public string ChatboostIosAppSignature;

		public string ChatboostAndroidAppId;

		public string ChatboostAndroidAppSignature;

		public string FyberIosAppId;

		public string FyberAndroidAppId;

		public string FiveIosAppId;

		public string FiveAndroidAppId;

		public bool FiveTestMode;

		public string AdjustIosAppToken;

		public string AdjustAndroidAppToken;

		public bool IsIAPEnabled => false;

		public static VoodooSettings Load()
		{
			return null;
		}

		public bool IsChinaStore()
		{
			return false;
		}

		public string GetAdjustAppToken()
		{
			return "";
		}

		public static bool IsAdUnitFieldName(string fieldName)
		{
			return false;
		}

		public static bool IsSecondaryAdUnitFieldName(string fieldName)
		{
			return false;
		}
	}
}
