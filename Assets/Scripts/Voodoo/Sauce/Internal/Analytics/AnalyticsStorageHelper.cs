namespace Voodoo.Sauce.Internal.Analytics
{
	internal static class AnalyticsStorageHelper
	{
		private const string GameCountPrefKey = "VoodooSauce_GameCount";

		private const string SuccessfulGameCountPrefKey = "VoodooSauce_SuccessfulGameCount";

		private const string LevelPrefKey = "VoodooSauce_Level";

		private const string LaunchCountPrefKey = "VoodooSauce_AppLaunchCount";

		private const string HighestScorePrefKey = "VoodooSauce_HighScore";

		private const string FSShownCountPrefKey = "VoodooSauce_FSShownCount";

		private const string RVShownCountPrefKey = "VoodooSauce_RVShownCount";

		private static int _gameCount;

		private static string _currentRoundId;

		private static int _rvUsed;

		private static int _appLaunchCount;

		internal static int GetGameCount()
		{
			return 0;
		}

		private static int GetStoredGameCount()
		{
			return 0;
		}

		internal static void IncrementGameCount()
		{
		}

		internal static int GetSuccessfulGameCount()
		{
			return 0;
		}

		internal static void IncrementSuccessfulGameCount()
		{
		}

		internal static double GetWinRate()
		{
			return 0.0;
		}

		internal static bool HasWinRate()
		{
			return false;
		}

		internal static string GetLevel()
		{
			return "";
		}

		internal static void UpdateLevel(string level)
		{
		}

		internal static bool HasLevel()
		{
			return false;
		}

		public static float GetGameHighestScore()
		{
			return 0f;
		}

		internal static bool HasGameHighestScore()
		{
			return false;
		}

		internal static bool UpdateGameHighestScore(float score)
		{
			return false;
		}

		internal static int GetAppLaunchCount()
		{
			return 0;
		}

		private static int GetStoredAppLaunchCount()
		{
			return 0;
		}

		internal static bool IsFirstAppLaunch()
		{
			return false;
		}

		internal static void IncrementAppLaunchCount()
		{
		}

		internal static int GetInterstitialShownCount()
		{
			return 0;
		}

		internal static int IncrementInterstitialShownCount()
		{
			return 0;
		}

		internal static int GetRewardedVideoShownCount()
		{
			return 0;
		}

		internal static int IncrementRewardedVideoShownCount()
		{
			return 0;
		}

		internal static string GetGameRoundId()
		{
			return "";
		}

		internal static string CreateRoundId()
		{
			return "";
		}

		internal static void IncreaseRvUsed()
		{
		}

		internal static void ResetRvUsed()
		{
		}

		internal static object GetRvUsed()
		{
			return null;
		}
	}
}
