namespace Voodoo.Sauce.Internal.Analytics
{
	internal static class AbTestManager
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public string locale;

			internal bool _003CShouldCreateCohort_003Eb__0(string code)
			{
				return false;
			}
		}

		private const string TAG = "AbTestManager";

		private static bool _debugModeForced;

		private static string[] _runningAbTests;

		private static bool _useVoodooTune;

		internal static void Initialize(VoodooSettings settings)
		{
		}

		private static bool ShouldCreateCohort(VoodooSettings settings)
		{
			return false;
		}

		internal static bool PlayerIsInACohort()
		{
			return false;
		}

		internal static string GetPlayerCohort()
		{
			return "";
		}

		internal static int GetPlayerCohortIndex()
		{
			return 0;
		}

		internal static void SetPlayerCohort(string cohort)
		{
		}

		internal static string[] GetAbTests()
		{
			return null;
		}

		internal static bool IsDebugModeForced()
		{
			return false;
		}
	}
}
