using System;
using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class AnalyticsConfig : IConfig
	{
		public int waitIntervalSeconds;

		public int maxNumberOfEventsPerFile;

		public string enabledEvents;

		public int sessionIdRenewalIntervalInSeconds;

		public int GetSenderWaitIntervalSeconds()
		{
			return 0;
		}

		public int GetMaxNumberOfEventsPerFile()
		{
			return 0;
		}

		public string[] EnabledEvents()
		{
			return null;
		}

		public int SessionIdRenewalIntervalInSeconds()
		{
			return 0;
		}

		public override string ToString()
		{
			return "";
		}
	}
}
