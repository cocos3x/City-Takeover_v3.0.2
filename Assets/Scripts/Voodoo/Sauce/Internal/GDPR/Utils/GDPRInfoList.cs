using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.GDPR.Utils
{
	internal class GDPRInfoList : List<GDPRInfo>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<GDPRInfo, string> _003C_003E9__0_0;

			public static Func<GDPRInfo, string> _003C_003E9__1_0;

			internal string _003CGetNames_003Eb__0_0(GDPRInfo info)
			{
				return "";
			}

			internal string _003CGetPrivacyPolicyUrls_003Eb__1_0(GDPRInfo info)
			{
				return "";
			}
		}

		internal string[] GetNames()
		{
			return null;
		}

		internal IEnumerable<string> GetPrivacyPolicyUrls()
		{
			return null;
		}
	}
}
