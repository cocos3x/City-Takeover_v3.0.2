using System;
using Voodoo.Sauce.Internal.SDKs;
using Voodoo.Sauce.Internal.SDKs.Models;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class FirebaseAnalyticsProviderSDK : IAnalyticsProviderSDK
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<AndroidPackage> _003C_003E9__0_0;

			internal bool _003CGetSDKInformations_003Eb__0_0(AndroidPackage x)
			{
				return false;
			}
		}

		public SDK GetSDKInformations()
		{
			return null;
		}
	}
}
