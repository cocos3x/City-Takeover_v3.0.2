using System.Collections.Generic;
using Voodoo.Sauce.Internal;
using Voodoo.Sauce.Internal.DebugScreen;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Core
{
	public interface IModule
	{
		void ShowDebugGeneralInfo(DebugGeneralInfoScreen screen, VoodooSettings settings);

		List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings);
	}
}
