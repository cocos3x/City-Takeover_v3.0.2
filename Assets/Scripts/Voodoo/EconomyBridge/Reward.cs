namespace Voodoo.EconomyBridge
{
	public class Reward
	{
		private string _configId;

		private RewardConfig _config;

		private string _unlockableId;

		private Unlockable _unlockable;

		public string configId
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string unlockableId
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public RewardConfig GetConfig()
		{
			return null;
		}

		public Unlockable GetUnlockable()
		{
			return null;
		}
	}
}
