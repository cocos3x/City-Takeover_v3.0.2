using System;

namespace Voodoo.EconomyBridge
{
	[Serializable]
	public class RewardConfig
	{
		public string configId;

		public int rewardGroupId;

		public string type;

		public int amount;

		public string replacementConfigId;
	}
}
