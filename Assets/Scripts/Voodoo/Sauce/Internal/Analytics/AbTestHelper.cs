namespace Voodoo.Sauce.Internal.Analytics
{
	public static class AbTestHelper
	{
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public float randomValue;

			public float usersPercentPerCohort;

			internal bool _003CGenerateNewRandomCohort_003Eb__0(string abTest, int index)
			{
				return false;
			}
		}

		private const string PrefCohort = "VoodooSauce_Cohort";

		private const string CohortDefault = "Control";

		public const int ControlCohortCount = 1;

		public const string ABTestDefaultCountryCode = "us";

		internal static string GenerateNewRandomCohort(string[] runningAbTests, float usersPercentPerCohort)
		{
			return "";
		}

		internal static string[] AddControlCohortsToAbTests(string[] runningAbTests)
		{
			return null;
		}

		internal static bool HasSavedPlayerCohort()
		{
			return false;
		}

		internal static string GetSavedPlayerCohort()
		{
			return "";
		}

		public static void SavePlayerCohort(string cohort)
		{
		}
	}
}
