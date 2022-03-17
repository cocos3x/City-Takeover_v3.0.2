using System;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class AdFrequencyConfiguration
	{
		public int delayInSecondsBeforeFirstInterstitialAd;

		public int delayInSecondsBetweenInterstitialAds;

		public int maxGamesBetweenInterstitialAds;

		public int delayInSecondsBetweenRewardedVideoAndInterstitial;

		public bool isSecondaryInterstitialEnabled;

		public bool useSecondaryInterstitialFirst;

		public bool isSecondaryRewardedVideoEnabled;

		public bool useSecondaryRewardedVideoFirst;

		public float secondaryDelayTimerInSeconds;

		public bool shouldSecondaryWaitForPrimary;

		public override string ToString()
		{
			return "";
		}
	}
}
