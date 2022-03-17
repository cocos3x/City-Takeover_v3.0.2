using System;
using System.Collections.Generic;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class ABTestIntegrationCheck : IIntegrationCheck
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<string, bool> _003C_003E9__5_0;

			internal bool _003CIntegrationCheck_003Eb__5_0(string code)
			{
				return false;
			}
		}

		private const string SettingsAbTestingRemotelyDeactivatedError = "You have added A/B Tests under 'Running AB Tests' but A/B testing is remotely deactivated. Please contact Voodoo if you believe this is a mistake";

		private const string SettingsAbTestsCustomCountriesRemotelyDeactivatedError = "You have added countries under 'Custom AB Tests Country Codes' but  A/B testing is remotely deactivated for countries other than the 'US'. Please contact Voodoo if you believe this is a mistake";

		private const string SettingsAbTestsEmptyCustomCountriesError = "You have added A/B Tests under 'Running AB Tests' but the 'Custom AB Tests Country Codes' is empty.";

		private const string SettingsAbTestsWrongCountryCodeError = "You have placed an invalid country code {0} in your 'Custom AB Tests Country Codes'";

		private const string SettingsAbTestsTotalPercentExceedsMaxError = "The total percentage of A/B test users is {0} * {1} = {2}.  This exceeds the max value of {3}";

		public List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}
	}
}
