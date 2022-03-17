using System;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AdUnits
	{
		public enum AdUnit
		{
			Banner,
			Interstitial,
			RewardedVideo
		}

		public string BannerAdUnit;

		public string InterstitialAdUnit;

		public string RewardedVideoAdUnit;

		public string InterstitialAtLaunchAdUnit;

		public bool IsEmpty()
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
