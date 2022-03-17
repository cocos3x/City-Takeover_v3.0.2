using System;

namespace com.adjust.sdk.purchase
{
	public class ADJPConfig
	{
		internal string appToken;

		internal ADJPLogLevel? logLevel;

		internal ADJPEnvironment environment;

		internal Action<ADJPVerificationInfo> attributionChangedDelegate;

		public ADJPConfig(string appToken, ADJPEnvironment environment)
		{
		}

		public void SetLogLevel(ADJPLogLevel logLevel)
		{
		}
	}
}
