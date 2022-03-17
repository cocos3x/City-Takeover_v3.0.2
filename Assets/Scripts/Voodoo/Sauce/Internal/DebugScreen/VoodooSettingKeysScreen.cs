using System;
using System.Collections.Generic;
using System.Reflection;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class VoodooSettingKeysScreen : DebugScreen
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<FieldInfo> _003C_003E9__2_0;

			internal int _003CDisplayVoodooSettingKeys_003Eb__2_0(FieldInfo a, FieldInfo b)
			{
				return 0;
			}
		}

		private readonly HashSet<string> _ignoreKeySet;

		private void Awake()
		{
		}

		private void DisplayVoodooSettingKeys()
		{
		}
	}
}
