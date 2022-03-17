using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.IntegrationCheck
{
	public interface IIntegrationCheck
	{
		List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings);
	}
}
