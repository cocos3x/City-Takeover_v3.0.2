using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Internal.Extension
{
	public static class SettingsExtension
	{
		public static string[] GetRunningABTests(this VoodooSettings settings)
		{
			return null;
		}

		public static bool IsCustomABTestsCountryCodesEnabled(this VoodooSettings settings)
		{
			return false;
		}

		public static string[] GetCustomABTestsCountryCodes(this VoodooSettings settings)
		{
			return null;
		}

		public static DebugForcedCohort GetDebugForcedCohort(this VoodooSettings settings)
		{
			return null;
		}

		public static float GeUsersPercentPerCohort(this VoodooSettings settings)
		{
			return 0f;
		}

		public static float GeMaxPercentOfTotalCohorts(this VoodooSettings settings)
		{
			return 0f;
		}

		public static bool IsABTestingEnabled(this VoodooSettings settings)
		{
			return false;
		}
	}
}
