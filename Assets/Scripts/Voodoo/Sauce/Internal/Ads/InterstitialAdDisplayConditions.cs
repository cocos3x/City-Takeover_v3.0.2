namespace Voodoo.Sauce.Internal.Ads
{
	public class InterstitialAdDisplayConditions
	{
		private enum InterstitialAdConditionState
		{
			FirstInterstitialReadyToShow,
			FirstInterstitialTooEarly,
			InterstitialTooEarlyAndNotEnoughGamesPlayed,
			EnoughGamesWerePlayed,
			RewardedVideoWasPlayedRecently,
			InterstitialReadyToShow
		}

		private const string TAG = "AdDisplayConditions";

		private const string PrefsFirstAppLaunch = "VoodooSauce.Interstitial.FirstAppLaunch";

		private const int DefaultDelayInSecondsBeforeFirstInterstitialAdAd = 30;

		private const int DefaultDelayInSecondsBetweenInterstitialAds = 30;

		private const int DefaultMaxGamesBetweenInterstitialAds = 3;

		private const int DefaultDelayInSecondsBetweenRewardedVideoAndInterstitial = 5;

		private readonly int _delayInSecondsBeforeFirstInterstitialAd;

		private readonly int _delayInSecondsBetweenInterstitialAds;

		private readonly int _maxGamesPlayedBetweenInterstitials;

		private bool _firstInterstitialDisplayed;

		private int _gamesPlayedSinceLastInterstitial;

		private float _lastInterstitialTime;

		private readonly bool _rewardedVideosDelayFullscreen;

		private float _lastRewardedVideoTime;

		private readonly int _delayInSecondsBetweenRewardedVideoAndInterstitial;

		public InterstitialAdDisplayConditions()
		{
		}

		public InterstitialAdDisplayConditions(int delayInSecondsBeforeFirstInterstitialAdAd, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial)
		{
		}

		public bool AreConditionsMet()
		{
			return false;
		}

		private InterstitialAdConditionState GetCurrentConditionState()
		{
			//IL_0003: Expected I4, but got O
			return (InterstitialAdConditionState)null;
		}

		public void InterstitialDisplayed()
		{
		}

		public void RewardedVideoDisplayed(bool completed)
		{
		}

		public void GamePlayed()
		{
		}

		public override string ToString()
		{
			return "";
		}

		private string GetStateString(InterstitialAdConditionState state)
		{
			return "";
		}

		public string GetInterstitialConditionStatusInfoString()
		{
			return "";
		}

		public string GetInterstitialConditionStatusString()
		{
			return "";
		}
	}
}
