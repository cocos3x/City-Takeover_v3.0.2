using System;
using Voodoo.Sauce.Internal.SDKs;
using Voodoo.Sauce.Internal.SDKs.Models;

namespace Voodoo.Sauce.Internal.Ads.MaxMediation
{
	public class MaxMediationAdapterSDK : IMediationAdapterSDK
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<AndroidPackage> _003C_003E9__4_0;

			public static Predicate<AndroidPackage> _003C_003E9__4_1;

			public static Predicate<IosPod> _003C_003E9__4_2;

			internal bool _003CGetSDKInformations_003Eb__4_0(AndroidPackage x)
			{
				return false;
			}

			internal bool _003CGetSDKInformations_003Eb__4_1(AndroidPackage x)
			{
				return false;
			}

			internal bool _003CGetSDKInformations_003Eb__4_2(IosPod x)
			{
				return false;
			}
		}

		private const string NAME = "MaxAds";

		private const string MEDIATION_FOLDER_PATH = "/VoodooSauce/Ads/Mediations/MaxAds/3rdParty/MaxSdk/";

		private string AD_NETWORKS_FOLDER_PATH;

		private const string AD_NETWORK_DEPENDENCIES_PATH = "/Editor/Dependencies.xml";

		public MediationSDK GetSDKInformations()
		{
			return null;
		}
	}
}
