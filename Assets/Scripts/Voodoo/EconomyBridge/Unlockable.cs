using System;

namespace Voodoo.EconomyBridge
{
	[Serializable]
	public class Unlockable
	{
		public string type;

		public string id;

		public string name;

		public UnlockableViewBase viewPrefab;
	}
}
