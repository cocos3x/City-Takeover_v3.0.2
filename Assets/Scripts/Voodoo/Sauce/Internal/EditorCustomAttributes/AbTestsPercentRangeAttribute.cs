using System.Runtime.InteropServices;
using UnityEngine;

namespace Voodoo.Sauce.Internal.EditorCustomAttributes
{
	public class AbTestsPercentRangeAttribute : PropertyAttribute
	{
		private readonly VoodooSettings setting;

		private readonly RuntimePlatform platform;

		public const float min = 0.001f;

		private string _003CNewName_003Ek__BackingField;

		public float max => 0f;

		public string NewName
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public AbTestsPercentRangeAttribute(RuntimePlatform runtimePlatform, [Optional] string newName)
		{
		}
	}
}
