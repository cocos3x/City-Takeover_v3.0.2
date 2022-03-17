using System.Collections.Generic;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class MixpanelIntegrationCheck : IIntegrationCheck
	{
		private const string SettingsNoMixpanelWarning = "VoodooSauce Settings is missing Mixpanel token! Mixpanel will be disabled.";

		public List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}
	}
}
